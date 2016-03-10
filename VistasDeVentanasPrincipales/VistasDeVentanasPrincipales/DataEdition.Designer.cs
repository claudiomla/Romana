namespace VistasDeVentanasPrincipales
{
    partial class DataEdition
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
            this.labelDataEdition = new System.Windows.Forms.Label();
            this.TypeDocument = new System.Windows.Forms.ComboBox();
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.labelcode = new System.Windows.Forms.Label();
            this.labelidentityCard = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelplate = new System.Windows.Forms.Label();
            this.labelmodel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxcard = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxplate = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.Modify2 = new System.Windows.Forms.Button();
            this.Modify3 = new System.Windows.Forms.Button();
            this.Modify1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDataEdition
            // 
            this.labelDataEdition.AutoSize = true;
            this.labelDataEdition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataEdition.Location = new System.Drawing.Point(150, 22);
            this.labelDataEdition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataEdition.Name = "labelDataEdition";
            this.labelDataEdition.Size = new System.Drawing.Size(129, 18);
            this.labelDataEdition.TabIndex = 0;
            this.labelDataEdition.Text = "Edicion de Datos";
            // 
            // TypeDocument
            // 
            this.TypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeDocument.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeDocument.FormattingEnabled = true;
            this.TypeDocument.Items.AddRange(new object[] {
            "COT",
            "PED",
            "ODC"});
            this.TypeDocument.Location = new System.Drawing.Point(162, 89);
            this.TypeDocument.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TypeDocument.Name = "TypeDocument";
            this.TypeDocument.Size = new System.Drawing.Size(100, 25);
            this.TypeDocument.TabIndex = 3;
            // 
            // textBoxcode
            // 
            this.textBoxcode.Location = new System.Drawing.Point(162, 129);
            this.textBoxcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxcode.MaxLength = 10;
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.ShortcutsEnabled = false;
            this.textBoxcode.Size = new System.Drawing.Size(100, 20);
            this.textBoxcode.TabIndex = 4;
            this.textBoxcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxcode_KeyDown);
            this.textBoxcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcode_KeyPress);
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltype.Location = new System.Drawing.Point(51, 91);
            this.labeltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(84, 18);
            this.labeltype.TabIndex = 5;
            this.labeltype.Text = "Correlativo";
            // 
            // labelcode
            // 
            this.labelcode.AutoSize = true;
            this.labelcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcode.Location = new System.Drawing.Point(79, 128);
            this.labelcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcode.Name = "labelcode";
            this.labelcode.Size = new System.Drawing.Size(60, 18);
            this.labelcode.TabIndex = 6;
            this.labelcode.Text = "Codigo";
            // 
            // labelidentityCard
            // 
            this.labelidentityCard.AutoSize = true;
            this.labelidentityCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidentityCard.Location = new System.Drawing.Point(79, 214);
            this.labelidentityCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelidentityCard.Name = "labelidentityCard";
            this.labelidentityCard.Size = new System.Drawing.Size(27, 18);
            this.labelidentityCard.TabIndex = 7;
            this.labelidentityCard.Text = "C.I";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(75, 245);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 18);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Nombre";
            // 
            // labelplate
            // 
            this.labelplate.AutoSize = true;
            this.labelplate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplate.Location = new System.Drawing.Point(75, 327);
            this.labelplate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelplate.Name = "labelplate";
            this.labelplate.Size = new System.Drawing.Size(48, 18);
            this.labelplate.TabIndex = 9;
            this.labelplate.Text = "Placa";
            // 
            // labelmodel
            // 
            this.labelmodel.AutoSize = true;
            this.labelmodel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmodel.Location = new System.Drawing.Point(75, 363);
            this.labelmodel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelmodel.Name = "labelmodel";
            this.labelmodel.Size = new System.Drawing.Size(60, 18);
            this.labelmodel.TabIndex = 10;
            this.labelmodel.Text = "Modelo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxcard
            // 
            this.textBoxcard.Location = new System.Drawing.Point(162, 214);
            this.textBoxcard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxcard.Name = "textBoxcard";
            this.textBoxcard.Size = new System.Drawing.Size(100, 20);
            this.textBoxcard.TabIndex = 12;
            this.textBoxcard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxcard_KeyDown);
            this.textBoxcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcard_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(162, 246);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxplate
            // 
            this.textBoxplate.Location = new System.Drawing.Point(162, 327);
            this.textBoxplate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxplate.Name = "textBoxplate";
            this.textBoxplate.Size = new System.Drawing.Size(100, 20);
            this.textBoxplate.TabIndex = 14;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(162, 363);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 15;
            // 
            // Modify2
            // 
            this.Modify2.Location = new System.Drawing.Point(307, 228);
            this.Modify2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Modify2.Name = "Modify2";
            this.Modify2.Size = new System.Drawing.Size(74, 23);
            this.Modify2.TabIndex = 17;
            this.Modify2.Text = "Modificar";
            this.Modify2.UseVisualStyleBackColor = true;
            this.Modify2.Click += new System.EventHandler(this.Modify2_Click);
            // 
            // Modify3
            // 
            this.Modify3.Location = new System.Drawing.Point(307, 343);
            this.Modify3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Modify3.Name = "Modify3";
            this.Modify3.Size = new System.Drawing.Size(74, 23);
            this.Modify3.TabIndex = 19;
            this.Modify3.Text = "Modificar";
            this.Modify3.UseVisualStyleBackColor = true;
            this.Modify3.Click += new System.EventHandler(this.Modify3_Click);
            // 
            // Modify1
            // 
            this.Modify1.Location = new System.Drawing.Point(307, 110);
            this.Modify1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Modify1.Name = "Modify1";
            this.Modify1.Size = new System.Drawing.Size(74, 23);
            this.Modify1.TabIndex = 21;
            this.Modify1.Text = "Modificar";
            this.Modify1.UseVisualStyleBackColor = true;
            this.Modify1.Click += new System.EventHandler(this.Modify1_Click);
            // 
            // DataEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 488);
            this.Controls.Add(this.Modify1);
            this.Controls.Add(this.Modify3);
            this.Controls.Add(this.Modify2);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxplate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxcard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelmodel);
            this.Controls.Add(this.labelplate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelidentityCard);
            this.Controls.Add(this.labelcode);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.textBoxcode);
            this.Controls.Add(this.TypeDocument);
            this.Controls.Add(this.labelDataEdition);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "DataEdition";
            this.Text = "DataEdition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataEdition;
        private System.Windows.Forms.ComboBox TypeDocument;
        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label labelcode;
        private System.Windows.Forms.Label labelidentityCard;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelplate;
        private System.Windows.Forms.Label labelmodel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxcard;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxplate;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button Modify2;
        private System.Windows.Forms.Button Modify3;
        private System.Windows.Forms.Button Modify1;
    }
}