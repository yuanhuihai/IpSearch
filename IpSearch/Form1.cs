using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


namespace IpSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {

           getIPlog();
        }

         
        public void getIPlog()
        {

            //获取本地机器名 
            string _myHostName = Dns.GetHostName();
            //获取本机IP 
            string _myHostIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault<IPAddress>(a => a.AddressFamily.ToString().Equals("InterNetwork")).ToString();
            //MessageBox.Show(_myHostIP);
            //截取IP网段
            string ipDuan = _myHostIP.Remove(_myHostIP.LastIndexOf('.'));
            //MessageBox.Show(ipDuan);
            //枚举网段计算机
            Ping myPing = new Ping();
            string data = "";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            for (int i = 1; i <= 10; i++)
            {
                string pingIP = ipDuan + "." + i.ToString();
                PingReply pingReply = myPing.Send(pingIP, 120, buffer);
                if (pingReply.Status == IPStatus.Success)
                {
                      onlineList.Items.Add("答复的主机地址：" +pingIP + "往返时间：" + pingReply.RoundtripTime.ToString());
                }
                else
                {            
                    offlineList.Items.Add(pingIP + "不在线");
                }

            }
        }









    }
}
