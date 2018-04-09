namespace Lab1SGBF
{
    partial class Interfata
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
            this.parinteGrid = new System.Windows.Forms.DataGridView();
            this.fiuGrid = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.numeLabel = new System.Windows.Forms.Label();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.salariuLabel = new System.Windows.Forms.Label();
            this.numeText = new System.Windows.Forms.TextBox();
            this.prenumeText = new System.Windows.Forms.TextBox();
            this.salariuText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parinteGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiuGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // parinteGrid
            // 
            this.parinteGrid.BackgroundColor = System.Drawing.Color.Cyan;
            this.parinteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parinteGrid.Location = new System.Drawing.Point(12, 133);
            this.parinteGrid.MultiSelect = false;
            this.parinteGrid.Name = "parinteGrid";
            this.parinteGrid.RowTemplate.Height = 24;
            this.parinteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parinteGrid.Size = new System.Drawing.Size(327, 322);
            this.parinteGrid.TabIndex = 0;
            this.parinteGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parinteGrid_CellContentClick);
            // 
            // fiuGrid
            // 
            this.fiuGrid.BackgroundColor = System.Drawing.Color.Cyan;
            this.fiuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fiuGrid.Location = new System.Drawing.Point(845, 133);
            this.fiuGrid.Name = "fiuGrid";
            this.fiuGrid.RowTemplate.Height = 24;
            this.fiuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fiuGrid.Size = new System.Drawing.Size(327, 322);
            this.fiuGrid.TabIndex = 1;
            this.fiuGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fiuGrid_CellContentClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(118, 70);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(668, 139);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(45, 17);
            this.numeLabel.TabIndex = 3;
            this.numeLabel.Text = "Nume";
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(668, 167);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeLabel.TabIndex = 4;
            this.prenumeLabel.Text = "Prenume";
            // 
            // salariuLabel
            // 
            this.salariuLabel.AutoSize = true;
            this.salariuLabel.Location = new System.Drawing.Point(668, 195);
            this.salariuLabel.Name = "salariuLabel";
            this.salariuLabel.Size = new System.Drawing.Size(52, 17);
            this.salariuLabel.TabIndex = 5;
            this.salariuLabel.Text = "Salariu";
            // 
            // numeText
            // 
            this.numeText.Location = new System.Drawing.Point(739, 134);
            this.numeText.Name = "numeText";
            this.numeText.Size = new System.Drawing.Size(100, 22);
            this.numeText.TabIndex = 6;
            // 
            // prenumeText
            // 
            this.prenumeText.Location = new System.Drawing.Point(739, 162);
            this.prenumeText.Name = "prenumeText";
            this.prenumeText.Size = new System.Drawing.Size(100, 22);
            this.prenumeText.TabIndex = 7;
            // 
            // salariuText
            // 
            this.salariuText.Location = new System.Drawing.Point(739, 190);
            this.salariuText.Name = "salariuText";
            this.salariuText.Size = new System.Drawing.Size(100, 22);
            this.salariuText.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(658, 241);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Adauga";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(658, 281);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Sterge";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(739, 241);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Actualizeaza\r\n\r\n";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Interfata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 590);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.salariuText);
            this.Controls.Add(this.prenumeText);
            this.Controls.Add(this.numeText);
            this.Controls.Add(this.salariuLabel);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.numeLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.fiuGrid);
            this.Controls.Add(this.parinteGrid);
            this.Name = "Interfata";
            this.Text = "Interfata";
            ((System.ComponentModel.ISupportInitialize)(this.parinteGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiuGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parinteGrid;
        private System.Windows.Forms.DataGridView fiuGrid;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.Label salariuLabel;
        private System.Windows.Forms.TextBox numeText;
        private System.Windows.Forms.TextBox prenumeText;
        private System.Windows.Forms.TextBox salariuText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}