namespace Busines.Forms
{
    partial class AddFlaw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderIDEdit = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.OrderEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CountEdit = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.SummToPayEdit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OrderIDEdit);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.OrderEdit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CountEdit);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 106);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Товар";
            // 
            // OrderIDEdit
            // 
            this.OrderIDEdit.AutoSize = true;
            this.OrderIDEdit.Location = new System.Drawing.Point(49, 60);
            this.OrderIDEdit.Name = "OrderIDEdit";
            this.OrderIDEdit.Size = new System.Drawing.Size(13, 13);
            this.OrderIDEdit.TabIndex = 21;
            this.OrderIDEdit.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(14, 13);
            this.label.TabIndex = 20;
            this.label.Text = "#";
            // 
            // OrderEdit
            // 
            this.OrderEdit.Location = new System.Drawing.Point(18, 30);
            this.OrderEdit.Name = "OrderEdit";
            this.OrderEdit.Size = new System.Drawing.Size(296, 20);
            this.OrderEdit.TabIndex = 10;
            this.OrderEdit.Text = "Натисніть для вибору товару";
            this.OrderEdit.Click += new System.EventHandler(this.OrderEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Кількість";
            // 
            // CountEdit
            // 
            this.CountEdit.Location = new System.Drawing.Point(194, 79);
            this.CountEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CountEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountEdit.Name = "CountEdit";
            this.CountEdit.Size = new System.Drawing.Size(120, 20);
            this.CountEdit.TabIndex = 15;
            this.CountEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountEdit.ValueChanged += new System.EventHandler(this.CountEdit_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(212, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = " грн";
            // 
            // SummToPayEdit
            // 
            this.SummToPayEdit.AutoSize = true;
            this.SummToPayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummToPayEdit.Location = new System.Drawing.Point(139, 135);
            this.SummToPayEdit.Name = "SummToPayEdit";
            this.SummToPayEdit.Size = new System.Drawing.Size(45, 24);
            this.SummToPayEdit.TabIndex = 30;
            this.SummToPayEdit.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Витрати: ";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(264, 179);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 33;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Відміна";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFlaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 214);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SummToPayEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddFlaw";
            this.Text = "Бракований товар";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label OrderIDEdit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox OrderEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CountEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label SummToPayEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button1;
    }
}