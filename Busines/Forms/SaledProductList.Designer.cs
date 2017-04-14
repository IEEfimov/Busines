namespace Busines.Forms
{
    partial class SaledProductList
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.знайтиТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знайтиКлієнтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ClientID,
            this.ProductID,
            this.Сount});
            this.dataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(523, 559);
            this.dataGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.знайтиТоварToolStripMenuItem,
            this.знайтиКлієнтаToolStripMenuItem,
            this.toolStripSeparator1,
            this.видалитиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 76);
            // 
            // знайтиТоварToolStripMenuItem
            // 
            this.знайтиТоварToolStripMenuItem.Name = "знайтиТоварToolStripMenuItem";
            this.знайтиТоварToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.знайтиТоварToolStripMenuItem.Text = "Відобразити товар";
            this.знайтиТоварToolStripMenuItem.Click += new System.EventHandler(this.знайтиТоварToolStripMenuItem_Click);
            // 
            // знайтиКлієнтаToolStripMenuItem
            // 
            this.знайтиКлієнтаToolStripMenuItem.Name = "знайтиКлієнтаToolStripMenuItem";
            this.знайтиКлієнтаToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.знайтиКлієнтаToolStripMenuItem.Text = "Відобразити клієнта";
            this.знайтиКлієнтаToolStripMenuItem.Click += new System.EventHandler(this.знайтиКлієнтаToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити запис";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "Клієнт";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Width = 180;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Продукт";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 120;
            // 
            // Сount
            // 
            this.Сount.HeaderText = "Кількість";
            this.Сount.Name = "Сount";
            this.Сount.ReadOnly = true;
            // 
            // SaledProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 559);
            this.Controls.Add(this.dataGrid);
            this.Name = "SaledProductList";
            this.Text = "Проведені транзакції";
            this.Load += new System.EventHandler(this.SaledProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem знайтиТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знайтиКлієнтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сount;
    }
}