namespace VistasDeVentanasPrincipales
{
    partial class ServiceCode
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
            this.TextNumTicketSer = new System.Windows.Forms.Label();
            this.SerTicket = new System.Windows.Forms.RichTextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CheckTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextNumTicketSer
            // 
            this.TextNumTicketSer.AutoSize = true;
            this.TextNumTicketSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNumTicketSer.Location = new System.Drawing.Point(188, 28);
            this.TextNumTicketSer.Name = "TextNumTicketSer";
            this.TextNumTicketSer.Size = new System.Drawing.Size(112, 24);
            this.TextNumTicketSer.TabIndex = 0;
            this.TextNumTicketSer.Text = "N° de Ticket";
            // 
            // SerTicket
            // 
            this.SerTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerTicket.Location = new System.Drawing.Point(147, 95);
            this.SerTicket.Multiline = false;
            this.SerTicket.Name = "SerTicket";
            this.SerTicket.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerTicket.ShortcutsEnabled = false;
            this.SerTicket.Size = new System.Drawing.Size(180, 27);
            this.SerTicket.TabIndex = 1;
            this.SerTicket.Text = "SER-   ";
            this.SerTicket.Select(0, 7);
            this.SerTicket.SelectionProtected = true;
            this.SerTicket.SelectionStart = this.SerTicket.Text.Length;
            this.SerTicket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerTicket_KeyDown);
            this.SerTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerTicket_KeyPress);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(72, 164);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(94, 30);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Cerrar";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(210, 164);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(90, 30);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "Nuevo Servicio";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(340, 164);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(88, 30);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "Comprobar";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // CheckTicketButton
            // 
            this.CheckTicketButton.Location = new System.Drawing.Point(333, 95);
            this.CheckTicketButton.Name = "CheckTicketButton";
            this.CheckTicketButton.Size = new System.Drawing.Size(60, 27);
            this.CheckTicketButton.TabIndex = 5;
            this.CheckTicketButton.Text = "lupa";
            this.CheckTicketButton.UseVisualStyleBackColor = true;
            this.CheckTicketButton.Click += new System.EventHandler(this.CheckTicketButton_Click);
            // 
            // ServiceCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(499, 220);
            this.Controls.Add(this.CheckTicketButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SerTicket);
            this.Controls.Add(this.TextNumTicketSer);
            this.MaximizeBox = false;
            this.Name = "ServiceCode";
            this.Text = "ServiceCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SerTicket;
        private System.Windows.Forms.Label TextNumTicketSer;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button CheckTicketButton;
    }
}