using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業提示
{

    public partial class Fm作業提示 : Form
    {
        //類別變數
        List<Label> listLebles = new List<Label>();
        List<Label> listLebles1 = new List<Label>();
        public Fm作業提示()
        {
            InitializeComponent();
        }

        private void Fm作業提示_Load(object sender, EventArgs e)
        {
            listLebles.Add(lblOne);
            listLebles.Add(lblTwo);
            listLebles.Add(lblThree);
            listLebles.Add(lblfour);
            listLebles.Add(lblfive);
            listLebles.Add(lblsix);
            listLebles1.Add(lblseven);
        }

        private void btn產生號碼_Click(object sender, EventArgs e)
        {
            Random myRnd = new Random();
            //傳隨機數
            //Console.WriteLine(random.Next());
            ////傳出非負值的隨機整數，32位元

            //Console.WriteLine(random.NextDouble());
            ////輸出倍精度的隨機數

            //Console.WriteLine(random.Next(100));
            ////輸出0到99之間的任何一個整數

            //Console.WriteLine(random.Next(1,39));
            ////輸出1~38的任何一個整數
            //Console.WriteLine(myRnd.Next(0, 10));

            for (int i = 0; i < listLebles.Count; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = myRnd.Next(1, 39);
                } while (listLebles.Any(label => label.Text == randomNumber.ToString())); // 檢查是否重複

                listLebles[i].Text = string.Format("{0}", randomNumber);
            }

            for (int i = 0; i < listLebles1.Count; i++)
            {
                listLebles1[i].Text = string.Format("{0}", myRnd.Next(1, 8));
            }

        }

        private void lblThree_Click(object sender, EventArgs e)
        {

        }

        private void btn加入選號_Click(object sender, EventArgs e)
        {
            string str選號 = "";
            for (int i = 0; i < listLebles.Count; i++)
            {
                str選號 += listLebles[i].Text + "  ";
            }
            for (int i = 0; i < listLebles1.Count; i++)
            {
                str選號 += listLebles1[i].Text + "  ";
            }
            lstb選號紀錄.Items.Add(str選號);
            顯示筆數();
        }

        private void btn刪除所選號碼_Click(object sender, EventArgs e)
        {
            if (lstb選號紀錄.SelectedIndex >= 0)
            //如果所選號碼不是0
            {
                lstb選號紀錄.Items.RemoveAt(lstb選號紀錄.SelectedIndex);
                //刪除所選號碼
            }
            else
            {
                MessageBox.Show("請選取要刪除號碼");
            }
            顯示筆數();
        }

        private void btn刪除所有號碼_Click(object sender, EventArgs e)
        {
            lstb選號紀錄.Items.Clear();
            //將所有在lstb選號紀錄的Items都清除
            顯示筆數();
        }

        void 顯示筆數()
        {
            lbl筆數.Text = string.Format("共{0}筆", lstb選號紀錄.Items.Count);
        }
    }
}
