namespace VistasDeVentanasPrincipales
{
    partial class AddOperationCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOperationCode));
            this.TextLastDigits = new System.Windows.Forms.Label();
            this.TextAddOrderCode = new System.Windows.Forms.Label();
            this.DocType = new System.Windows.Forms.ComboBox();
            this.RelevantCode = new System.Windows.Forms.TextBox();
            this.BackButtonAOC = new System.Windows.Forms.Button();
            this.NextButtonAOC = new System.Windows.Forms.Button();
            this.TextSocialReason = new System.Windows.Forms.Label();
            this.TextProduct = new System.Windows.Forms.Label();
            this.SocialReason = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TextBox();
            this.TextDocType2 = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLastDigits
            // 
            this.TextLastDigits.AutoSize = true;
            this.TextLastDigits.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLastDigits.Location = new System.Drawing.Point(212, 100);
            this.TextLastDigits.Name = "TextLastDigits";
            this.TextLastDigits.Size = new System.Drawing.Size(114, 18);
            this.TextLastDigits.TabIndex = 1;
            this.TextLastDigits.Text = "Ultimos Digitos";
            // 
            // TextAddOrderCode
            // 
            this.TextAddOrderCode.AutoSize = true;
            this.TextAddOrderCode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAddOrderCode.Location = new System.Drawing.Point(101, 27);
            this.TextAddOrderCode.Name = "TextAddOrderCode";
            this.TextAddOrderCode.Size = new System.Drawing.Size(240, 22);
            this.TextAddOrderCode.TabIndex = 2;
            this.TextAddOrderCode.Text = "Ingresar Codigo de Pedido";
            // 
            // DocType
            // 
            this.DocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocType.FormattingEnabled = true;
            this.DocType.Items.AddRange(new object[] {
            "COT",
            "PED",
            "ODC"});
            this.DocType.Location = new System.Drawing.Point(110, 136);
            this.DocType.Name = "DocType";
            this.DocType.Size = new System.Drawing.Size(53, 21);
            this.DocType.TabIndex = 3;
            // 
            // RelevantCode
            // 
            this.RelevantCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelevantCode.Location = new System.Drawing.Point(215, 133);
            this.RelevantCode.MaxLength = 10;
            this.RelevantCode.Name = "RelevantCode";
            this.RelevantCode.ShortcutsEnabled = false;
            this.RelevantCode.Size = new System.Drawing.Size(100, 26);
            this.RelevantCode.TabIndex = 4;
            this.RelevantCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RelevantCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RelevantCode_KeyDown);
            this.RelevantCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RelevantCode_KeyPress);
            // 
            // BackButtonAOC
            // 
            this.BackButtonAOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButtonAOC.Location = new System.Drawing.Point(90, 402);
            this.BackButtonAOC.Name = "BackButtonAOC";
            this.BackButtonAOC.Size = new System.Drawing.Size(92, 23);
            this.BackButtonAOC.TabIndex = 5;
            this.BackButtonAOC.Text = "Regresar";
            this.BackButtonAOC.UseVisualStyleBackColor = true;
            // 
            // NextButtonAOC
            // 
            this.NextButtonAOC.Image = ((System.Drawing.Image)(resources.GetObject("NextButtonAOC.Image")));
            this.NextButtonAOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextButtonAOC.Location = new System.Drawing.Point(230, 402);
            this.NextButtonAOC.Name = "NextButtonAOC";
            this.NextButtonAOC.Size = new System.Drawing.Size(99, 23);
            this.NextButtonAOC.TabIndex = 6;
            this.NextButtonAOC.Text = "Siguiente";
            this.NextButtonAOC.UseVisualStyleBackColor = true;
            // 
            // TextSocialReason
            // 
            this.TextSocialReason.AutoSize = true;
            this.TextSocialReason.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSocialReason.Location = new System.Drawing.Point(47, 216);
            this.TextSocialReason.Name = "TextSocialReason";
            this.TextSocialReason.Size = new System.Drawing.Size(100, 18);
            this.TextSocialReason.TabIndex = 7;
            this.TextSocialReason.Text = "Razón Social";
            // 
            // TextProduct
            // 
            this.TextProduct.AutoSize = true;
            this.TextProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProduct.Location = new System.Drawing.Point(60, 316);
            this.TextProduct.Name = "TextProduct";
            this.TextProduct.Size = new System.Drawing.Size(71, 18);
            this.TextProduct.TabIndex = 8;
            this.TextProduct.Text = "Producto";
            // 
            // SocialReason
            // 
            this.SocialReason.Location = new System.Drawing.Point(154, 203);
            this.SocialReason.Multiline = true;
            this.SocialReason.Name = "SocialReason";
            this.SocialReason.ReadOnly = true;
            this.SocialReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SocialReason.Size = new System.Drawing.Size(194, 48);
            this.SocialReason.TabIndex = 9;
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(154, 301);
            this.Product.Multiline = true;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Product.Size = new System.Drawing.Size(194, 48);
            this.Product.TabIndex = 10;
            // 
            // TextDocType2
            // 
            this.TextDocType2.AutoSize = true;
            this.TextDocType2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDocType2.Location = new System.Drawing.Point(91, 100);
            this.TextDocType2.Name = "TextDocType2";
            this.TextDocType2.Size = new System.Drawing.Size(88, 18);
            this.TextDocType2.TabIndex = 11;
            this.TextDocType2.Text = "Documento";
            // 
            // DetailsButton
            // 
            this.DetailsButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsButton.Location = new System.Drawing.Point(349, 131);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(56, 28);
            this.DetailsButton.TabIndex = 12;
            this.DetailsButton.Text = "Detalles";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // AddOperationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(430, 449);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.TextDocType2);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.SocialReason);
            this.Controls.Add(this.TextProduct);
            this.Controls.Add(this.TextSocialReason);
            this.Controls.Add(this.NextButtonAOC);
            this.Controls.Add(this.BackButtonAOC);
            this.Controls.Add(this.RelevantCode);
            this.Controls.Add(this.DocType);
            this.Controls.Add(this.TextAddOrderCode);
            this.Controls.Add(this.TextLastDigits);
            this.MaximizeBox = false;
            this.Name = "AddOperationCode";
            this.Text = "AddOperationCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RelevantCode;
        private System.Windows.Forms.Button BackButtonAOC;
        private System.Windows.Forms.Button NextButtonAOC;
        private System.Windows.Forms.ComboBox DocType;
        private System.Windows.Forms.Label TextAddOrderCode;
        private System.Windows.Forms.Label TextLastDigits;
        private System.Windows.Forms.Label TextSocialReason;
        private System.Windows.Forms.Label TextProduct;
        private System.Windows.Forms.TextBox SocialReason;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.Label TextDocType2;
        private System.Windows.Forms.Button DetailsButton;
    }
}