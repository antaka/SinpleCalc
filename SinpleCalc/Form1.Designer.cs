namespace SinpleCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Input1TextBox = new System.Windows.Forms.TextBox();
            this.PlusLabel = new System.Windows.Forms.Label();
            this.Input2TextBox = new System.Windows.Forms.TextBox();
            this.EqualLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input1TextBox
            // 
            this.Input1TextBox.Location = new System.Drawing.Point(13, 13);
            this.Input1TextBox.Name = "Input1TextBox";
            this.Input1TextBox.Size = new System.Drawing.Size(100, 19);
            this.Input1TextBox.TabIndex = 0;
            // 
            // PlusLabel
            // 
            this.PlusLabel.AutoSize = true;
            this.PlusLabel.Location = new System.Drawing.Point(119, 16);
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(11, 12);
            this.PlusLabel.TabIndex = 1;
            this.PlusLabel.Text = "+";
            // 
            // Input2TextBox
            // 
            this.Input2TextBox.Location = new System.Drawing.Point(137, 12);
            this.Input2TextBox.Name = "Input2TextBox";
            this.Input2TextBox.Size = new System.Drawing.Size(100, 19);
            this.Input2TextBox.TabIndex = 2;
            // 
            // EqualLabel
            // 
            this.EqualLabel.AutoSize = true;
            this.EqualLabel.Location = new System.Drawing.Point(243, 15);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(11, 12);
            this.EqualLabel.TabIndex = 3;
            this.EqualLabel.Text = "=";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(261, 12);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(100, 19);
            this.AnswerTextBox.TabIndex = 4;
            this.AnswerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBox_TextChanged);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(13, 39);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(348, 23);
            this.CalcButton.TabIndex = 5;
            this.CalcButton.Text = "計算する";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "変更１";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.EqualLabel);
            this.Controls.Add(this.Input2TextBox);
            this.Controls.Add(this.PlusLabel);
            this.Controls.Add(this.Input1TextBox);
            this.Name = "Form1";
            this.Text = "簡単計算プログラム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1TextBox;
        private System.Windows.Forms.Label PlusLabel;
        private System.Windows.Forms.TextBox Input2TextBox;
        private System.Windows.Forms.Label EqualLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label label1;
    }
}

