namespace VistasDeVentanasPrincipales
{
    partial class SMCode
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckTicketButton = new System.Windows.Forms.Button();
            this.SerTicket = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 208);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckTicketButton);
            this.panel1.Controls.Add(this.SerTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 102);
            this.panel1.TabIndex = 0;
            // 
            // CheckTicketButton
            // 
            this.CheckTicketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckTicketButton.Image = global::VistasDeVentanasPrincipales.Properties.Resources.Field_Lookup;
            this.CheckTicketButton.Location = new System.Drawing.Point(330, 38);
            this.CheckTicketButton.Name = "CheckTicketButton";
            this.CheckTicketButton.Size = new System.Drawing.Size(30, 27);
            this.CheckTicketButton.TabIndex = 11;
            this.CheckTicketButton.UseVisualStyleBackColor = true;
            this.CheckTicketButton.Click += new System.EventHandler(this.CheckTicketButton_Click);
            // 
            // SerTicket
            // 
            this.SerTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerTicket.Location = new System.Drawing.Point(145, 38);
            this.SerTicket.MaxLength = 17;
            this.SerTicket.Multiline = false;
            this.SerTicket.Name = "SerTicket";
            this.SerTicket.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerTicket.ShortcutsEnabled = false;
            this.SerTicket.Size = new System.Drawing.Size(180, 27);
            this.SerTicket.TabIndex = 7;
            this.SerTicket.Text = "SER-   ";
            this.SerTicket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerTicket_KeyDown);
            this.SerTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerTicket_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CheckButton);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Controls.Add(this.NewButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 44);
            this.panel3.TabIndex = 2;
            // 
            // CheckButton
            // 
            this.CheckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Location = new System.Drawing.Point(379, 4);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(100, 35);
            this.CheckButton.TabIndex = 10;
            this.CheckButton.Text = "Verificar";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(60, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 35);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Cerrar";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(220, 4);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(100, 35);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "Nuevo Servicio";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SMCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(545, 208);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "SMCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceCode";
            this.Load += new System.EventHandler(this.ServiceCode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RichTextBox SerTicket;
        private System.Windows.Forms.Button CheckTicketButton;
        private System.Windows.Forms.Label label1;
    }
}