using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //変数の宣言
            int valueLeft;   //入力値1用の整数型変数
            int valueRight;  //入力値2用の整数型変数
            int valueAnswer; //計算結果用整数型変数

            //入力値チェック
            valueLeft = InputCheck(Input1TextBox.Text,out valueLeft); 
            valueRight = InputCheck(Input2TextBox.Text, out valueRight);
            
            //取り込んだ値の計算
            valueAnswer = valueLeft + valueRight;

            //計算結果を出力
            AnswerTextBox.Text = valueAnswer.ToString(); //文字列に変換後入力
        }
        private int InputCheck(string textValue, out int value)
        {
            if (int.TryParse(textValue, out value) == true)
            {
                value = int.Parse(textValue);
            }
            else
            {
                value = 0;
            }
            return value;
        }
    }
}
