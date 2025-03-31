using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private double secondNumber; // 新增這行，宣告 secondNumber 變數
        private string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "0";
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "2";
        }



        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtNumber.Text);
            txtNumber.Text = "0";
            operation = "+"; // 修正這行，將整數 0 改為字串 "+"
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtNumber.Text);
            txtNumber.Text = "0";
            operation = "-";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtNumber.Text);
            txtNumber.Text = "0";
            operation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtNumber.Text);
            txtNumber.Text = "0";
            operation = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double finalResults = 0; //宣告最後計算結果變數
            secondNumber = Convert.ToDouble(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operation)
            {
                case "+":
                    finalResults = firstNumber + secondNumber;
                    break;
                case "-":
                    finalResults = firstNumber - secondNumber;
                    break;
                case "*":
                    finalResults = firstNumber * secondNumber;
                    break;
                case "/":
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }
    }
}
