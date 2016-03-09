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
            this.TextDocType = new System.Windows.Forms.Label();
            this.TextLastDigits = new System.Windows.Forms.Label();
            this.TextAddOrderCode = new System.Windows.Forms.Label();
            this.DocType = new System.Windows.Forms.ComboBox();
            this.RelevantCode = new System.Windows.Forms.TextBox();
            this.BackButtonAOC = new System.Windows.Forms.Button();
            this.NextButtonAOC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextDocType
            // 
            this.TextDocType.AutoSize = true;
            this.TextDocType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDocType.Location = new System.Drawing.Point(12, 82);
            this.TextDocType.Name = "TextDocType";
            this.TextDocType.Size = new System.Drawing.Size(144, 18);
            this.TextDocType.TabIndex = 0;
            this.TextDocType.Text = "Tipo de Documento";
            // 
            // TextLastDigits
            // 
            this.TextLastDigits.AutoSize = true;
            this.TextLastDigits.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLastDigits.Location = new System.Drawing.Point(171, 82);
            this.TextLastDigits.Name = "TextLastDigits";
            this.TextLastDigits.Size = new System.Drawing.Size(114, 18);
            this.TextLastDigits.TabIndex = 1;
            this.TextLastDigits.Text = "Ultimos Digitos";
            // 
            // TextAddOrderCode
            // 
            this.TextAddOrderCode.AutoSize = true;
            this.TextAddOrderCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAddOrderCode.Location = new System.Drawing.Point(63, 25);
            this.TextAddOrderCode.Name = "TextAddOrderCode";
            this.TextAddOrderCode.Size = new System.Drawing.Size(197, 18);
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
            this.DocType.Location = new System.Drawing.Point(66, 115);
            this.DocType.Name = "DocType";
            this.DocType.Size = new System.Drawing.Size(53, 21);
            this.DocType.TabIndex = 3;
            // 
            // RelevantCode
            // 
            this.RelevantCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelevantCode.Location = new System.Drawing.Point(173, 115);
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
            this.BackButtonAOC.Image = ((System.Drawing.Image)(resources.GetObject("BackButtonAOC.Image")));
            this.BackButtonAOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButtonAOC.Location = new System.Drawing.Point(45, 198);
            this.BackButtonAOC.Name = "BackButtonAOC";
            this.BackButtonAOC.Size = new System.Drawing.Size(92, 23);
            this.BackButtonAOC.TabIndex = 5;
            this.BackButtonAOC.Text = "Cerrar";
            this.BackButtonAOC.UseVisualStyleBackColor = true;
            // 
            // NextButtonAOC
            // 
            this.NextButtonAOC.Image = ((System.Drawing.Image)(resources.GetObject("NextButtonAOC.Image")));
            this.NextButtonAOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextButtonAOC.Location = new System.Drawing.Point(174, 198);
            this.NextButtonAOC.Name = "NextButtonAOC";
            this.NextButtonAOC.Size = new System.Drawing.Size(99, 23);
            this.NextButtonAOC.TabIndex = 6;
            this.NextButtonAOC.Text = "Siguiente";
            this.NextButtonAOC.UseVisualStyleBackColor = true;
            // 
            // AddOperationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 233);
            this.Controls.Add(this.NextButtonAOC);
            this.Controls.Add(this.BackButtonAOC);
            this.Controls.Add(this.RelevantCode);
            this.Controls.Add(this.DocType);
            this.Controls.Add(this.TextAddOrderCode);
            this.Controls.Add(this.TextLastDigits);
            this.Controls.Add(this.TextDocType);
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
        private System.Windows.Forms.Label TextDocType;
    }
}