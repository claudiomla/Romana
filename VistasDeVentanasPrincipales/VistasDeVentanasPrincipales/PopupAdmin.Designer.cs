namespace VistasDeVentanasPrincipales
{
    partial class PopupAdmin
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.TextUser = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.TextPopup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(134, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(337, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(114, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Aceptar";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // TextUser
            // 
            this.TextUser.AutoSize = true;
            this.TextUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.Location = new System.Drawing.Point(168, 23);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(62, 18);
            this.TextUser.TabIndex = 2;
            this.TextUser.Text = "Usuario";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.Location = new System.Drawing.Point(156, 52);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(89, 18);
            this.TextPassword.TabIndex = 3;
            this.TextPassword.Text = "Contraseña";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(270, 20);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(181, 22);
            this.UserName.TabIndex = 4;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserPassword
            // 
            this.UserPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(270, 48);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.Size = new System.Drawing.Size(181, 22);
            this.UserPassword.TabIndex = 5;
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPopup
            // 
            this.TextPopup.AutoSize = true;
            this.TextPopup.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPopup.Location = new System.Drawing.Point(21, 9);
            this.TextPopup.Name = "TextPopup";
            this.TextPopup.Size = new System.Drawing.Size(557, 24);
            this.TextPopup.TabIndex = 6;
            this.TextPopup.Text = "Para Continuar Ingrese los Datos del Supervisor de Turno";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 188);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextPopup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextUser);
            this.panel2.Controls.Add(this.UserPassword);
            this.panel2.Controls.Add(this.TextPassword);
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 86);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CancelButton);
            this.panel3.Controls.Add(this.NextButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 42);
            this.panel3.TabIndex = 2;
            // 
            // PopupAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(588, 188);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "PopupAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupAdmin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label TextUser;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label TextPopup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}