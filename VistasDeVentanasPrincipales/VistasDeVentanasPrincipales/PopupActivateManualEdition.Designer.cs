namespace VistasDeVentanasPrincipales
{
    partial class PopupActivateManualEdition
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
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(116, 108);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(222, 108);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Continuar";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // TextUser
            // 
            this.TextUser.AutoSize = true;
            this.TextUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.Location = new System.Drawing.Point(70, 41);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(62, 18);
            this.TextUser.TabIndex = 2;
            this.TextUser.Text = "Usuario";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.Location = new System.Drawing.Point(58, 70);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(89, 18);
            this.TextPassword.TabIndex = 3;
            this.TextPassword.Text = "Contraseña";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(172, 38);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(181, 22);
            this.UserName.TabIndex = 4;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserPassword
            // 
            this.UserPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(172, 66);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.Size = new System.Drawing.Size(181, 22);
            this.UserPassword.TabIndex = 5;
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextPopup
            // 
            this.TextPopup.AutoSize = true;
            this.TextPopup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPopup.Location = new System.Drawing.Point(23, 9);
            this.TextPopup.Name = "TextPopup";
            this.TextPopup.Size = new System.Drawing.Size(396, 18);
            this.TextPopup.TabIndex = 6;
            this.TextPopup.Text = "Para continuar ingrese los datos del Supervisor de turno";
            // 
            // PopupActivateManualEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 136);
            this.Controls.Add(this.TextPopup);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "PopupActivateManualEdition";
            this.Text = "PopupActivateManualEdition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label TextUser;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label TextPopup;
    }
}