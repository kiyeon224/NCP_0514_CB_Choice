using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0514_NCP_CB_Choice
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
        string[] SList = new string[]
        {
            "김밥", "샐러드김밥", "야채김밥",
            "소고기김밥" ,"계란김밥", "라볶이"
        };
        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0; i<this.SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }

            this.orgStr = this.lblResult.Text;
            if (SList.Count() > 0)
            {
                this.cbList.SelectedIndex = 0;  //첫번째 항목이 기본적으로 선택되어 있음
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtList.Text != "")    //txtList가 비어있지 않으면 메뉴 추가
            {
                cbList.Items.Add(this.txtList.Text);
                MessageBox.Show("아이템을 추가하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtList.Text = "";  //txtList를 비워줌
            }
            else
            {
                MessageBox.Show("아이템을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
            }

        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbList.Text != "")
            {
                this.lblResult.Text = this.orgStr + this.cbList.Text;
            }            
        }
    }
}
