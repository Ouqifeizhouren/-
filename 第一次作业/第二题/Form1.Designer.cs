
namespace 第二题
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(58, 75);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(103, 21);
            this.a.TabIndex = 0;
            this.a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(199, 76);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 21);
            this.b.TabIndex = 1;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(321, 76);
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(100, 21);
            this.res.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(136, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "点击运算符开始运算";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(164, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(33, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(19, 21);
            this.button5.TabIndex = 10;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(452, 118);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.res);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
    }
}

