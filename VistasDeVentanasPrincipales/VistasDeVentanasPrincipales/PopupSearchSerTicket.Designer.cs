﻿namespace VistasDeVentanasPrincipales
{
    partial class PopupSearchSerTicket
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
            this.DataTickets = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTickets)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataTickets, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.72317F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.27684F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DataTickets
            // 
            this.DataTickets.AllowUserToAddRows = false;
            this.DataTickets.AllowUserToDeleteRows = false;
            this.DataTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket,
            this.Plate,
            this.Driver,
            this.Client,
            this.EntryWeight});
            this.DataTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTickets.Location = new System.Drawing.Point(3, 3);
            this.DataTickets.Name = "DataTickets";
            this.DataTickets.RowHeadersVisible = false;
            this.DataTickets.Size = new System.Drawing.Size(748, 365);
            this.DataTickets.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SelectButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 51);
            this.panel1.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(59, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(127, 33);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Cerrar";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(465, 9);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(127, 33);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Seleccionar";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            // 
            // Plate
            // 
            this.Plate.HeaderText = "Placa";
            this.Plate.Name = "Plate";
            // 
            // Driver
            // 
            this.Driver.HeaderText = "Conductor";
            this.Driver.Name = "Driver";
            // 
            // Client
            // 
            this.Client.HeaderText = "Cliente";
            this.Client.Name = "Client";
            // 
            // EntryWeight
            // 
            this.EntryWeight.HeaderText = "Peso de Entrada";
            this.EntryWeight.Name = "EntryWeight";
            // 
            // PopupSearchSerTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "PopupSearchSerTicket";
            this.Text = "PopupSearchSerTicket";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTickets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DataTickets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryWeight;
    }
}