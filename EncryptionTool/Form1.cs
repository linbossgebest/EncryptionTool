using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Newtonsoft;
using Newtonsoft.Json;

namespace EncryptionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetbtn_Click(object sender, EventArgs e)
        {
            groupname_txt.Text = "";
            expand_txt.Text = "";
            //publickeytxt.Text = "";
            ips_rtx.Text = "";
            resultrtx.Text = "";
            decrypt_rtx.Text = "";
        }

        private void encryptbtn_Click(object sender, EventArgs e)
        {
            var groupName = groupname_txt.Text.Trim();
            var expand = expand_txt.Text.Trim();
            var ips = ips_rtx.Text.Trim();
            var publicKey = publickey_txt.Text.Trim();
            if (string.IsNullOrWhiteSpace(groupName) || string.IsNullOrWhiteSpace(ips) || string.IsNullOrWhiteSpace(publicKey))
            {
                MessageBox.Show("加密信息不能为空");
                return;
            }


            InfoModel info = new InfoModel();
            info.GroupName = groupName;
            info.IPList = ips;
            info.ExpandList = expand;

            var data = JsonConvert.SerializeObject(info);

            var encryptdata = RSA.RSAEncrypt(publicKey, data);

            resultrtx.Text = encryptdata;
        }

        /// <summary>
        /// 生成公私钥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genernatekeybtn_Click(object sender, EventArgs e)
        {
            publickey_txt.Text = "";
            privatekey_txt.Text = "";

            var data = RSA.GenerateKey();
            publickey_txt.Text = data.Key;
            privatekey_txt.Text = data.Value;
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            var encryptResult = resultrtx.Text.Trim();
            var privateKey = privatekey_txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(encryptResult) || string.IsNullOrWhiteSpace(privateKey))
            {
                MessageBox.Show("解密信息不能为空");
                return;
            }

            var decryptdata = RSA.RSADecrypt(privateKey, encryptResult);
            decrypt_rtx.Text = decryptdata;
        }
    }
}
