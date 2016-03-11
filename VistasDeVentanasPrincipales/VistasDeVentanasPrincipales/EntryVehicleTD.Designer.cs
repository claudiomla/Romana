namespace VistasDeVentanasPrincipales
{
    partial class EntryVehicleTD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryVehicleTD));
            this.label1 = new System.Windows.Forms.Label();
            this.CITD = new System.Windows.Forms.TextBox();
            this.TypeCI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Plate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelVehicle = new System.Windows.Forms.TextBox();
            this.checkTD = new System.Windows.Forms.Button();
            this.checkVehicle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notice1 = new System.Windows.Forms.TextBox();
            this.notice2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula de Identidad";
            // 
            // CITD
            // 
            this.CITD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CITD.Location = new System.Drawing.Point(227, 47);
            this.CITD.MaxLength = 10;
            this.CITD.Name = "CITD";
            this.CITD.ShortcutsEnabled = false;
            this.CITD.Size = new System.Drawing.Size(108, 25);
            this.CITD.TabIndex = 1;
            this.CITD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CITD_KeyPress);
            // 
            // TypeCI
            // 
            this.TypeCI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCI.FormattingEnabled = true;
            this.TypeCI.Items.AddRange(new object[] {
            "V",
            "E"});
            this.TypeCI.Location = new System.Drawing.Point(186, 47);
            this.TypeCI.Name = "TypeCI";
            this.TypeCI.Size = new System.Drawing.Size(35, 25);
            this.TypeCI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre completo";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(186, 78);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 25);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // Plate
            // 
            this.Plate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plate.Location = new System.Drawing.Point(186, 150);
            this.Plate.MaxLength = 10;
            this.Plate.Name = "Plate";
            this.Plate.Size = new System.Drawing.Size(149, 25);
            this.Plate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modelo";
            // 
            // ModelVehicle
            // 
            this.ModelVehicle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelVehicle.Location = new System.Drawing.Point(186, 181);
            this.ModelVehicle.MaxLength = 10;
            this.ModelVehicle.Name = "ModelVehicle";
            this.ModelVehicle.Size = new System.Drawing.Size(175, 25);
            this.ModelVehicle.TabIndex = 8;
            // 
            // checkTD
            // 
            this.checkTD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkTD.Image = ((System.Drawing.Image)(resources.GetObject("checkTD.Image")));
            this.checkTD.Location = new System.Drawing.Point(335, 46);
            this.checkTD.Margin = new System.Windows.Forms.Padding(0);
            this.checkTD.Name = "checkTD";
            this.checkTD.Size = new System.Drawing.Size(26, 27);
            this.checkTD.TabIndex = 9;
            this.checkTD.UseVisualStyleBackColor = true;
            this.checkTD.Click += new System.EventHandler(this.checkTD_Click);
            // 
            // checkVehicle
            // 
            this.checkVehicle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkVehicle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkVehicle.Image = ((System.Drawing.Image)(resources.GetObject("checkVehicle.Image")));
            this.checkVehicle.Location = new System.Drawing.Point(335, 149);
            this.checkVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.checkVehicle.Name = "checkVehicle";
            this.checkVehicle.Size = new System.Drawing.Size(26, 27);
            this.checkVehicle.TabIndex = 10;
            this.checkVehicle.UseVisualStyleBackColor = false;
            this.checkVehicle.Click += new System.EventHandler(this.checkVehicle_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(297, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Siguiente";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(52, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Cerrar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // notice1
            // 
            this.notice1.BackColor = System.Drawing.SystemColors.Control;
            this.notice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notice1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice1.ForeColor = System.Drawing.Color.Red;
            this.notice1.Location = new System.Drawing.Point(159, 109);
            this.notice1.Name = "notice1";
            this.notice1.ShortcutsEnabled = false;
            this.notice1.Size = new System.Drawing.Size(223, 14);
            this.notice1.TabIndex = 13;
            this.notice1.Text = "Cedula no registrada. Ingrese Nuevo Cliente";
            this.notice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notice1.Visible = false;
            // 
            // notice2
            // 
            this.notice2.BackColor = System.Drawing.SystemColors.Control;
            this.notice2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notice2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice2.ForeColor = System.Drawing.Color.Red;
            this.notice2.Location = new System.Drawing.Point(159, 212);
            this.notice2.Name = "notice2";
            this.notice2.ShortcutsEnabled = false;
            this.notice2.Size = new System.Drawing.Size(223, 14);
            this.notice2.TabIndex = 14;
            this.notice2.Text = "Placa no registrada. Ingrese Nuevo Vehiculo";
            this.notice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notice2.Visible = false;
            // 
            // EntryVehicleTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(451, 336);
            this.Controls.Add(this.notice2);
            this.Controls.Add(this.notice1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkVehicle);
            this.Controls.Add(this.checkTD);
            this.Controls.Add(this.ModelVehicle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Plate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeCI);
            this.Controls.Add(this.CITD);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntryVehicleTD";
            this.Text = "Ingreso de Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CITD;
        private System.Windows.Forms.ComboBox TypeCI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Plate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelVehicle;
        private System.Windows.Forms.Button checkTD;
        private System.Windows.Forms.Button checkVehicle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox notice1;
        private System.Windows.Forms.TextBox notice2;
    }
}

