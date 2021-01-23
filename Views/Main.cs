using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryPoker.Controllers;
using MemoryPoker.Models;

namespace MemoryPoker.Views
{
    public partial class Main : Form
    {
        private PokerController pokerController = new PokerController();
        private List<Button> poker_cache = new List<Button>();
        private MusicController music = new MusicController();
        private int max_poker_width = 15;
        public int def_prepare_time = 10;
        private int prepare_time = 10;

        public Main()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// 表單讀取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            // 去掉外框
            FormBorderStyle = FormBorderStyle.None;
            // 視窗最大化
            WindowState = FormWindowState.Maximized;

            InitializeGame();
        }
        /// <summary>
        /// 初始化遊戲
        /// </summary>
        private void InitializeGame()
        {
            pokerController.InitializeData();
            ScoreLabel.Text = pokerController.GetScore().ToString();
            PokerFlowPanel.ResumeLayout();
            PokerFlowPanel.Controls.Clear();
            Point poker_point = new Point(0, 0);
            foreach (Poker poker in pokerController.GetPokers())
            {
                Button pokerButton = CreatePokerButton(poker.Id,poker.Value,poker_point);
                PokerFlowPanel.Controls.Add(pokerButton);
                // 改用FlowLayoutPanel物件設計
                //poker_point = UpdateNewPoint(poker_point);
            }
            PokerFlowPanel.SuspendLayout();
            prepare_time = def_prepare_time;
            ScoreBox.Text = "記憶時間";
            ScoreLabel.ForeColor = Color.Black;
            ScoreLabel.Text = def_prepare_time.ToString();
            timer1.Start();
        }
        private void StartGame()
        {
            ScoreBox.Text = "計分表";
            ScoreLabel.Text = "0";
            ScoreLabel.ForeColor = DefaultForeColor;
            foreach (Button btn in PokerFlowPanel.Controls)
            {
                btn.ForeColor = DefaultBackColor;
            }
            timer1.Stop();
        }
        /// <summary>
        /// 遊戲開始前 一個記憶時間,顯示答案 ,計時結束後開始遊戲
        /// </summary>
        private void MemoryTime(object sender, EventArgs e)
        {
            prepare_time--;
            if (prepare_time <= 5)
            {
                ScoreLabel.ForeColor = Color.Red;
                if (prepare_time < 0)
                {
                    StartGame();
                    return;
                }
            }
            ScoreLabel.Text = prepare_time.ToString();
        }
        /// <summary>
        /// 以6筆為一列更新座標
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private Point UpdateNewPoint(Point point)
        {
            point.X++;
            if(point.X >= max_poker_width)
            {
                point.X = 0;
                point.Y++;
            }
            return point;
        }
        /// <summary>
        /// 新增撲克牌按鈕
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        private Button CreatePokerButton(int id, string text, Point point)
        {
            Button btn = new Button();
            btn.BackColor = DefaultBackColor;
            //btn.ForeColor = DefaultBackColor;
            btn.Text = text;
            btn.Tag = "id:"+id;
            btn.Font = new Font("Microsoft JhengHei",20);
            btn.Width = 125;
            btn.Height = 150;
            btn.Location = new Point(point.X * btn.Width, point.Y * btn.Height);
            btn.Click += new EventHandler(this.PokerButton_Click);
            return btn;
        }
        /// <summary>
        /// 撲克牌按鈕點擊事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void PokerButton_Click(Object sender, EventArgs e)
        {
            if (poker_cache.Count() >= 2) return;
            Button btn = (Button) sender;
            if(btn.ForeColor != DefaultForeColor)
            {
                btn.ForeColor = DefaultForeColor;
                poker_cache.Add(btn);
            }
            await Task.Delay(1500);
            if (poker_cache.Count() >= 2)
            {
                if (pokerController.CheckEquals((string)poker_cache[0].Tag, (string)poker_cache[1].Tag))
                {
                    music.Answer();
                    pokerController.AddScore();
                    ScoreLabel.Text = pokerController.GetScore().ToString();
                    poker_cache[0].Visible = false;
                    poker_cache[1].Visible = false;
                } 
                else
                {
                    music.Wrong();
                    foreach (Button button in poker_cache)
                    {
                        button.ForeColor = DefaultBackColor;
                    }
                }
                poker_cache.Clear();
            }
        }
        private void 新遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
        private void 離開遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }
        private void 後台管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DataManage().ShowDialog();
            InitializeGame();
        }

        private void 現有組合清單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = String.Format("{0}.\t{1}\t{2}\n", "編號", "中文", "英文");
            int index = 0;
            foreach (Data poker in pokerController.GetPokerList())
            {
                index++;
                msg += String.Format("{0}.\t{1}\t{2}\n",index,poker.Chinese,poker.English);
            }
            MessageBox.Show(msg, "現有組合清單");
        }

        private void 設定記憶時間ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SetPrepareMemoryTime _form = new SetPrepareMemoryTime())
            {
                if (_form.ShowDialog() == DialogResult.OK)
                {
                    def_prepare_time = _form.time;
                    InitializeGame();
                }
            }
        }
    }
}