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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextNumTicketSer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.74419F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.25581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckTicketButton);
            this.panel1.Controls.Add(this.SerTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 108);
            this.panel1.TabIndex = 0;
            // 
            // CheckTicketButton
            // 
            this.CheckTicketButton.Location = new System.Drawing.Point(331, 39);
            this.CheckTicketButton.Name = "CheckTicketButton";
            this.CheckTicketButton.Size = new System.Drawing.Size(60, 27);
            this.CheckTicketButton.TabIndex = 11;
            this.CheckTicketButton.Text = "lupa";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.TextNumTicketSer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 60);
            this.panel2.TabIndex = 1;
            // 
            // TextNumTicketSer
            // 
            this.TextNumTicketSer.AutoSize = true;
            this.TextNumTicketSer.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNumTicketSer.Location = new System.Drawing.Point(139, 16);
            this.TextNumTicketSer.Name = "TextNumTicketSer";
            this.TextNumTicketSer.Size = new System.Drawing.Size(244, 33);
            this.TextNumTicketSer.TabIndex = 6;
            this.TextNumTicketSer.Text = "Número de Ticket";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CheckButton);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Controls.Add(this.NewButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 80);
            this.panel3.TabIndex = 2;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(353, 22);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(107, 30);
            this.CheckButton.TabIndex = 10;
            this.CheckButton.Text = "Comprobar";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(74, 22);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(113, 30);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Cerrar";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(217, 22);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(108, 30);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "Nuevo Servicio";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // ServiceCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(545, 266);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "ServiceCode";
            this.Text = "ServiceCode";
            this.Load += new System.EventHandler(this.ServiceCode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label TextNumTicketSer;
        private System.Windows.Forms.RichTextBox SerTicket;
        private System.Windows.Forms.Button CheckTicketButton;
    }
}