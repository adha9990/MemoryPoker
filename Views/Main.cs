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
            InitializeGame();
        }
        /// <summary>
        /// 初始化遊戲
        /// </summary>
        private void InitializeGame()
        {
            pokerController.InitializeData();
            ScoreLabel.Text = pokerController.GetScore().ToString();
            PokerPanel.Controls.Clear();
            Point poker_point = new Point(0, 0);
            foreach (Poker poker in pokerController.GetPokers())
            {
                Button pokerButton = CreatePokerButton(poker.Value, poker.Parents,poker_point);
                PokerPanel.Controls.Add(pokerButton);
                poker_point = UpdateNewPoint(poker_point);
            }
        }
        /// <summary>
        /// 以6筆為一列更新座標
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private Point UpdateNewPoint(Point point)
        {
            point.X++;
            if(point.X >= 6)
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
        private Button CreatePokerButton(string text, string tag, Point point)
        {
            Button btn = new Button();
            btn.BackColor = DefaultBackColor;
            btn.ForeColor = DefaultBackColor;
            btn.Text = text;
            btn.Tag = tag;
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
                if (pokerController.CheckEquals(poker_cache[0].Text, poker_cache[1].Tag.ToString()))
                {
                    pokerController.AddScore();
                    ScoreLabel.Text = pokerController.GetScore().ToString();
                    poker_cache[0].Hide();
                    poker_cache[1].Hide();
                }
                foreach (Button button in poker_cache)
                {
                    button.ForeColor = DefaultBackColor;
                }
                poker_cache.Clear();
            }
        }
        /// <summary>
        /// 除錯
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        private void dd(string text)
        {
            MessageBox.Show(text);
        }

        private void 新遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void 新增單字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDataForm f = new InputDataForm();
            f.ShowDialog();
        }

        private void 離開遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }

        private void 所有單字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();
            string msg = String.Format("{0} \t{1}\t{2}\n\n", "索引","英文","中文");
            int index = 0;
            Point point = new Point(0, 0);
            foreach (Data data in dataController.GetDatas())
            {
                index++;
                msg += String.Format("{0}.\t{1}\t{2}\n", index, data.English, data.Chinese);
                point = UpdateNewPoint(point);
            }
            MessageBox.Show(msg, "單字庫");
        }
    }
}