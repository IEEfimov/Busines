namespace Busines.Forms
{
    partial class ClientsList
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
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrivateCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReciev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.clientName,
            this.Surname,
            this.Telephone,
            this.PrivateCard,
            this.SummToPay,
            this.DateOrder,
            this.DateReciev,
            this.Delivery,
            this.CostDelivery});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1045, 438);
            this.dataGrid.TabIndex = 0;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // clientName
            // 
            this.clientName.HeaderText = "Ім\'я";
            this.clientName.Name = "clientName";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Прізвище";
            this.Surname.Name = "Surname";
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Телефон";
            this.Telephone.Name = "Telephone";
            // 
            // PrivateCard
            // 
            this.PrivateCard.HeaderText = "Нормер карти";
            this.PrivateCard.Name = "PrivateCard";
            // 
            // SummToPay
            // 
            this.SummToPay.HeaderText = "Сума";
            this.SummToPay.Name = "SummToPay";
            // 
            // DateOrder
            // 
            this.DateOrder.HeaderText = "Дата замовлення";
            this.DateOrder.Name = "DateOrder";
            // 
            // DateReciev
            // 
            this.DateReciev.HeaderText = "Дата отримання";
            this.DateReciev.Name = "DateReciev";
            // 
            // Delivery
            // 
            this.Delivery.HeaderText = "Вид доставки";
            this.Delivery.Name = "Delivery";
            // 
            // CostDelivery
            // 
            this.CostDelivery.HeaderText = "Сума доставки";
            this.CostDelivery.Name = "CostDelivery";
            // 
            // ClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid);
            this.Name = "ClientsList";
            this.Text = "ClientsList";
            this.Load += new System.EventHandler(this.ClientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrivateCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummToPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReciev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostDelivery;
    }
}