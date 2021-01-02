using MemoryPoker.Controllers;
using MemoryPoker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPoker.Views
{
    public partial class DataManage : Form
    {
        DataController dataController = new DataController();
        int index = 0;
        public DataManage()
        {
            InitializeComponent();
        }

        private void DataManage_Load(object sender, EventArgs e)
        {
            InitialLoadData();
        }

        private void InitialLoadData()
        {
            dataController.updateDatas();
            DataTableLayoutPanel.Controls.Clear();
            DataTableLayoutPanel.Controls.Add(new Label() { Text = "Id" }, 0, 0);
            DataTableLayoutPanel.Controls.Add(new Label() { Text = "英文" }, 1, 0);
            DataTableLayoutPanel.Controls.Add(new Label() { Text = "中文" }, 2, 0);
            index = 0;
            foreach (Data data in dataController.GetDatas())
            {
                index++;
                DataTableLayoutPanel.Controls.Add(new Label() {Text = index.ToString()}, 0, index);
                DataTableLayoutPanel.Controls.Add(CreateNewEnglishLabel(data.Id, data.English), 1, index);
                DataTableLayoutPanel.Controls.Add(CreateNewChineseLabel(data.Id, data.Chinese), 2, index);
                DataTableLayoutPanel.Controls.Add(CreateNewEditButton(data.Id), 3, index);
                DataTableLayoutPanel.Controls.Add(CreateNewDeleteButton(data.Id,index), 4, index);
            }
        }
        
        private TextBox CreateNewEnglishLabel(int Id,String English)
        {
            TextBox tb = new TextBox();
            tb.Text = English;
            tb.Name = "English_" + Id;
            return tb;
        }

        private TextBox CreateNewChineseLabel(int Id,String Chinese)
        {
            TextBox tb = new TextBox();
            tb.Text = Chinese;
            tb.Name = "Chinese_" + Id;
            return tb;
        }

        private Button CreateNewEditButton(int Id)
        {
            Button btn = new Button();
            btn.Text = "修改";
            btn.Tag = Id;
            btn.Click += new EventHandler(this.EditButton_Click);
            return btn;
        }

        private Button CreateNewDeleteButton(int Id,int _index)
        {
            Button btn = new Button();
            btn.Name = "delete_" + _index;
            btn.Tag = Id;
            btn.Text = "刪除";
            btn.Click += new EventHandler(this.DeleteButton_Click);
            return btn;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            new InputDataForm().ShowDialog();
            InitialLoadData();
        }

        private void EditButton_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = (int)btn.Tag;
            TextBox entb = (TextBox)Controls.Find("English_" + id,true).First();
            TextBox chtb = (TextBox)Controls.Find("Chinese_" + id,true).First();
            dataController.editData(id,entb.Text,chtb.Text);
            MessageBox.Show("修改完成");
        }

        private void DeleteButton_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = (int)btn.Tag;
            dataController.deleteData(id);
            MessageBox.Show("刪除完成");
            InitialLoadData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
