using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 网盘spi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //窗口启动
        private void Main_Load(object sender, EventArgs e)
        {
            //默认选中第一个
            comboBox_type.SelectedIndex = 0;
            //取消跨线程访问控件的限制
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //开始搞
        private void button_start_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(worker);
            th.IsBackground = true;
            th.Start();
            /*
            String[] uks = textBox_startuserid.Lines;
            for (int i = 0; i < uks.Length;i++ )
            {
                int count = PanAPI.getFollowCount(uks[i]);
                for (int j = 0; j < count; j += 25)
                {
                    String[] output = PanAPI.getfollowlist(uks[i], j, 25);
                    if (output != null)
                    {
                        for (int k = 0; k < output.Length; k++)
                        {
                            textBox_output.AppendText(output[k]);
                            textBox_output.AppendText("\r\n");
                        }
                    }
                }
            }*/
        }

        //工作线程
        void worker()
        {
            //关闭一些控件
            button_start.Enabled = false;
            textBox_output.Enabled = false;
            textBox_startuserid.Enabled = false;
            comboBox_type.Enabled = false;
            checkBox_ifinfile.Enabled = false;

            //进度条初始化
            toolStripProgressBar_all.Value = 0;
            toolStripProgressBar_one.Value = 0;


            //开搞
            String[] uks = textBox_startuserid.Lines;
            toolStripProgressBar_all.Maximum = uks.Length;

            for (int i = 0; i < uks.Length; i++)
            {
                int count = PanAPI.getFollowCount(uks[i]);
                toolStripProgressBar_one.Maximum = count;
                for (int j = 0; j < count; j += 25)
                {
                    String[] output = PanAPI.getfollowlist(uks[i], j, 25);
                    if (output != null)
                    {
                        for (int k = 0; k < output.Length; k++)
                        {
                            textBox_output.AppendText(output[k]);
                            textBox_output.AppendText("\r\n");
                        }
                    }
                    if (toolStripProgressBar_one.Maximum - toolStripProgressBar_one.Value >= 25)
                        toolStripProgressBar_one.Value += 25;
                    else
                        toolStripProgressBar_one.Value = toolStripProgressBar_one.Maximum;
                }
                toolStripProgressBar_all.Value++;
                toolStripProgressBar_one.Value = 0;
            }
            



            //打开控件
            button_start.Enabled = true;
            textBox_output.Enabled = true;
            textBox_startuserid.Enabled = true;
            comboBox_type.Enabled = true;
            checkBox_ifinfile.Enabled = true;
        }


    }
}
