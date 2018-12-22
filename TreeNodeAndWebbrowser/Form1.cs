﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TreeNodeAndWebbrowser.Extension;

namespace TreeNodeAndWebbrowser
{
    public partial class Form1 : Form
    {
       // MyTreeView mtv;
        public Form1()
        {            
            InitializeComponent();
           // mtv = new MyTreeView();
           // mtv.VScrollEvent += delegate {
           //     mtv.Nodes.ResetPictureBoxButtonVisibility();
           // };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var node = new TreeNode("测试");
            //treeView1.Nodes.Add(node);
            //treeView1.AddTrizNode(null, new TreeNode("dfdferer"), Update, Remove, GetData()[0]);
            //treeView1.ExpandAll();


            var p = new Person();
            var frm = new Form2(p);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var node = new TreeNode("", 1, 2);
                treeView1.AddTreeNode(null, node, Update, Remove, p);
               // mtv.AddTreeNode(null, node, Update, Remove, p);
            }
        }

        private void Update(TreeNode currentNode)
        {
            var p = ((TreeNodeTag)currentNode.Tag ).person;
            var frm = new Form2(p);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                currentNode.ResetNodeText(p.Name,true);//重绘text和编辑删除按钮的位置
            }
        }

        private void Remove(TreeNode currentNode)
        {
               // treeView1.Nodes.Remove(currentNode);
           
        }
        #region
        //数据
        private List<Person> GetData()
        {
            var datas = new List<Person>();
            datas.Add(new Person {
                Name="zhangsan",
                Age=20,
                Gender="male",
                Tel="12345678",
                Desc="asjdhfjas圣诞节发顺丰手动阀手动阀"
            });
            datas.Add(new Person {
                Name = "lisi",
                Age = 22,
                Gender = "male",
                Tel = "12334578",
                Desc = "asj恢复解放军s圣诞节发顺丰手动阀手动阀"
            });
            datas.Add(new Person
            {
                Name = "amy",
                Age = 27,
                Gender = "female",
                Tel = "6553454578",
                Desc = "依然有人手动阀手动阀"
            });
            return datas;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*mtv.Parent = this;
            mtv.Size = new Size(140, 320);
            mtv.Location = new Point(13, 60);
            mtv.BackColor = Color.AliceBlue;*/
        }
    }

}
