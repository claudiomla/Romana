namespace VistasDeVentanasPrincipales
{
    partial class EMRegistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMRegistry));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CITD = new System.Windows.Forms.TextBox();
            this.notice2 = new System.Windows.Forms.TextBox();
            this.notice1 = new System.Windows.Forms.TextBox();
            this.checkVehicle = new System.Windows.Forms.Button();
            this.checkTD = new System.Windows.Forms.Button();
            this.ModelVehicle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Plate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeCI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 394);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CITD);
            this.panel1.Controls.Add(this.notice2);
            this.panel1.Controls.Add(this.notice1);
            this.panel1.Controls.Add(this.checkVehicle);
            this.panel1.Controls.Add(this.checkTD);
            this.panel1.Controls.Add(this.ModelVehicle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Plate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TypeCI);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 288);
            this.panel1.Size = new System.Drawing.Size(463, 277);
            this.panel1.TabIndex = 0;
            // 
            // CITD
            // 
            this.CITD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CITD.Location = new System.Drawing.Point(251, 52);
            this.CITD.MaxLength = 10;
            this.CITD.Name = "CITD";
            this.CITD.ShortcutsEnabled = false;
            this.CITD.Size = new System.Drawing.Size(108, 24);
            this.CITD.TabIndex = 16;
            this.CITD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CITD_KeyPress);
            // 
            // notice2
            // 
            this.notice2.BackColor = System.Drawing.SystemColors.Control;
            this.notice2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice2.ForeColor = System.Drawing.Color.Red;
            this.notice2.Location = new System.Drawing.Point(69, 218);
            this.notice2.Name = "notice2";
            this.notice2.ShortcutsEnabled = false;
            this.notice2.Size = new System.Drawing.Size(312, 17);
            this.notice2.TabIndex = 29;
            this.notice2.Text = "Placa no registrada. Ingrese Nuevo Vehiculo";
            this.notice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notice2.Visible = false;
            // 
            // notice1
            // 
            this.notice1.BackColor = System.Drawing.SystemColors.Control;
            this.notice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice1.ForeColor = System.Drawing.Color.Red;
            this.notice1.Location = new System.Drawing.Point(69, 113);
            this.notice1.Name = "notice1";
            this.notice1.ShortcutsEnabled = false;
            this.notice1.Size = new System.Drawing.Size(311, 17);
            this.notice1.TabIndex = 28;
            this.notice1.Text = "Cedula no registrada. Ingrese Nuevo Cliente";
            this.notice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notice1.Visible = false;
            // 
            // checkVehicle
            // 
            this.checkVehicle.BackColor = System.Drawing.SystemColors.Control;
            this.checkVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkVehicle.ForeColor = System.Drawing.Color.Yellow;
            this.checkVehicle.Image = global::VistasDeVentanasPrincipales.Properties.Resources.Field_Lookup;
            this.checkVehicle.Location = new System.Drawing.Point(359, 157);
            this.checkVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.checkVehicle.Name = "checkVehicle";
            this.checkVehicle.Size = new System.Drawing.Size(26, 24);
            this.checkVehicle.TabIndex = 25;
            this.checkVehicle.UseVisualStyleBackColor = false;
            // 
            // checkTD
            // 
            this.checkTD.BackColor = System.Drawing.SystemColors.Control;
            this.checkTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkTD.Image = global::VistasDeVentanasPrincipales.Properties.Resources.Field_Lookup;
            this.checkTD.Location = new System.Drawing.Point(359, 52);
            this.checkTD.Margin = new System.Windows.Forms.Padding(0);
            this.checkTD.Name = "checkTD";
            this.checkTD.Size = new System.Drawing.Size(26, 24);
            this.checkTD.TabIndex = 24;
            this.checkTD.UseVisualStyleBackColor = false;
            // 
            // ModelVehicle
            // 
            this.ModelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelVehicle.Location = new System.Drawing.Point(210, 188);
            this.ModelVehicle.MaxLength = 10;
            this.ModelVehicle.Name = "ModelVehicle";
            this.ModelVehicle.Size = new System.Drawing.Size(175, 24);
            this.ModelVehicle.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Modelo";
            // 
            // Plate
            // 
            this.Plate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plate.Location = new System.Drawing.Point(210, 157);
            this.Plate.MaxLength = 10;
            this.Plate.Name = "Plate";
            this.Plate.Size = new System.Drawing.Size(149, 24);
            this.Plate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Placa";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(210, 83);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 24);
            this.textBox2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // TypeCI
            // 
            this.TypeCI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCI.FormattingEnabled = true;
            this.TypeCI.Items.AddRange(new object[] {
            "V",
            "E"});
            this.TypeCI.Location = new System.Drawing.Point(210, 52);
            this.TypeCI.Name = "TypeCI";
            this.TypeCI.Size = new System.Drawing.Size(35, 26);
            this.TypeCI.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cédula de Identidad";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 44);
            this.panel2.Size = new System.Drawing.Size(463, 63);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(276, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Siguiente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(88, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 27;
            this.button4.Text = "Cerrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(464, 50);
            this.label5.Size = new System.Drawing.Size(463, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Registro de Datos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // EMRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(469, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EMRegistry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vehículo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox notice2;
        private System.Windows.Forms.TextBox notice1;
        private System.Windows.Forms.Button checkVehicle;
        private System.Windows.Forms.Button checkTD;
        private System.Windows.Forms.TextBox ModelVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Plate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeCI;
        private System.Windows.Forms.TextBox CITD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;

    }
}

