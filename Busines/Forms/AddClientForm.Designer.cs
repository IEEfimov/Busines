namespace Busines.Forms
{
    partial class AddClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameEdit = new System.Windows.Forms.TextBox();
            this.SurnameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelephoneEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrivatCardEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdressEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateOrderEdit = new System.Windows.Forms.DateTimePicker();
            this.CountEdit = new System.Windows.Forms.NumericUpDown();
            this.DateRecievEdit = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.DeliveryTypeEdit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OrderEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(17, 34);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(200, 20);
            this.NameEdit.TabIndex = 1;
            // 
            // SurnameEdit
            // 
            this.SurnameEdit.Location = new System.Drawing.Point(17, 60);
            this.SurnameEdit.Name = "SurnameEdit";
            this.SurnameEdit.Size = new System.Drawing.Size(200, 20);
            this.SurnameEdit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прізвище";
            // 
            // TelephoneEdit
            // 
            this.TelephoneEdit.Location = new System.Drawing.Point(17, 86);
            this.TelephoneEdit.Name = "TelephoneEdit";
            this.TelephoneEdit.Size = new System.Drawing.Size(200, 20);
            this.TelephoneEdit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер телефону";
            // 
            // PrivatCardEdit
            // 
            this.PrivatCardEdit.Location = new System.Drawing.Point(17, 112);
            this.PrivatCardEdit.Name = "PrivatCardEdit";
            this.PrivatCardEdit.Size = new System.Drawing.Size(200, 20);
            this.PrivatCardEdit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Нормер картки";
            // 
            // AdressEdit
            // 
            this.AdressEdit.Location = new System.Drawing.Point(17, 138);
            this.AdressEdit.Name = "AdressEdit";
            this.AdressEdit.Size = new System.Drawing.Size(200, 20);
            this.AdressEdit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Адреса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата замовлення";
            // 
            // DateOrderEdit
            // 
            this.DateOrderEdit.Location = new System.Drawing.Point(40, 234);
            this.DateOrderEdit.Name = "DateOrderEdit";
            this.DateOrderEdit.Size = new System.Drawing.Size(200, 20);
            this.DateOrderEdit.TabIndex = 13;
            // 
            // CountEdit
            // 
            this.CountEdit.Location = new System.Drawing.Point(18, 63);
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
            // 
            // DateRecievEdit
            // 
            this.DateRecievEdit.Location = new System.Drawing.Point(40, 260);
            this.DateRecievEdit.Name = "DateRecievEdit";
            this.DateRecievEdit.Size = new System.Drawing.Size(200, 20);
            this.DateRecievEdit.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата отримання";
            // 
            // DeliveryTypeEdit
            // 
            this.DeliveryTypeEdit.FormattingEnabled = true;
            this.DeliveryTypeEdit.Location = new System.Drawing.Point(395, 154);
            this.DeliveryTypeEdit.Name = "DeliveryTypeEdit";
            this.DeliveryTypeEdit.Size = new System.Drawing.Size(200, 21);
            this.DeliveryTypeEdit.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Кількість";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Вид доставки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameEdit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SurnameEdit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TelephoneEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PrivatCardEdit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AdressEdit);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 197);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація про клієнта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OrderEdit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CountEdit);
            this.groupBox2.Location = new System.Drawing.Point(377, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 106);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Товар";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Відміна";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Додати";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OrderEdit
            // 
            this.OrderEdit.Location = new System.Drawing.Point(18, 30);
            this.OrderEdit.Name = "OrderEdit";
            this.OrderEdit.Size = new System.Drawing.Size(296, 20);
            this.OrderEdit.TabIndex = 10;
            this.OrderEdit.Text = "Натисніть для вибору товару";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(436, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Вартість: 0,00 грн";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeliveryTypeEdit);
            this.Controls.Add(this.DateRecievEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateOrderEdit);
            this.Controls.Add(this.label7);
            this.Name = "AddClientForm";
            this.Text = "Додати клієнта";
            ((System.ComponentModel.ISupportInitialize)(this.CountEdit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameEdit;
        private System.Windows.Forms.TextBox SurnameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelephoneEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrivatCardEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdressEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateOrderEdit;
        private System.Windows.Forms.NumericUpDown CountEdit;
        private System.Windows.Forms.DateTimePicker DateRecievEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DeliveryTypeEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OrderEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}