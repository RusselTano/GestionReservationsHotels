namespace GestionReservationsHotels
{
    partial class GestionReservationsHotelsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionReservationsHotelsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informationClientGroupBox = new System.Windows.Forms.GroupBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.courrielLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.TransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.prixLabel = new System.Windows.Forms.Label();
            this.dateReservationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.typeChambreComboBox = new System.Windows.Forms.ComboBox();
            this.totalLLabel = new System.Windows.Forms.Label();
            this.prixLLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.typeChambreLabel = new System.Windows.Forms.Label();
            this.dateReservationLabel = new System.Windows.Forms.Label();
            this.gestionReservationsHotelsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.informationClientGroupBox.SuspendLayout();
            this.TransactionGroupBox.SuspendLayout();
            this.gestionReservationsHotelsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionReservationsHotels.Properties.Resources.hotel;
            this.pictureBox1.Location = new System.Drawing.Point(39, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // informationClientGroupBox
            // 
            this.informationClientGroupBox.Controls.Add(this.courrielTextBox);
            this.informationClientGroupBox.Controls.Add(this.nomTextBox);
            this.informationClientGroupBox.Controls.Add(this.courrielLabel);
            this.informationClientGroupBox.Controls.Add(this.nomLabel);
            this.informationClientGroupBox.Location = new System.Drawing.Point(39, 252);
            this.informationClientGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.informationClientGroupBox.Name = "informationClientGroupBox";
            this.informationClientGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.informationClientGroupBox.Size = new System.Drawing.Size(528, 115);
            this.informationClientGroupBox.TabIndex = 2;
            this.informationClientGroupBox.TabStop = false;
            this.informationClientGroupBox.Text = "Information du client";
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.Location = new System.Drawing.Point(236, 71);
            this.courrielTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(271, 23);
            this.courrielTextBox.TabIndex = 3;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(236, 35);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(271, 23);
            this.nomTextBox.TabIndex = 2;
            // 
            // courrielLabel
            // 
            this.courrielLabel.AutoSize = true;
            this.courrielLabel.Location = new System.Drawing.Point(29, 79);
            this.courrielLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courrielLabel.Name = "courrielLabel";
            this.courrielLabel.Size = new System.Drawing.Size(61, 17);
            this.courrielLabel.TabIndex = 1;
            this.courrielLabel.Text = "Courriel:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(29, 38);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(41, 17);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom:";
            // 
            // TransactionGroupBox
            // 
            this.TransactionGroupBox.Controls.Add(this.totalLabel);
            this.TransactionGroupBox.Controls.Add(this.prixLabel);
            this.TransactionGroupBox.Controls.Add(this.dateReservationDateTimePicker);
            this.TransactionGroupBox.Controls.Add(this.serviceComboBox);
            this.TransactionGroupBox.Controls.Add(this.typeChambreComboBox);
            this.TransactionGroupBox.Controls.Add(this.totalLLabel);
            this.TransactionGroupBox.Controls.Add(this.prixLLabel);
            this.TransactionGroupBox.Controls.Add(this.servicesLabel);
            this.TransactionGroupBox.Controls.Add(this.typeChambreLabel);
            this.TransactionGroupBox.Controls.Add(this.dateReservationLabel);
            this.TransactionGroupBox.Location = new System.Drawing.Point(39, 380);
            this.TransactionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.TransactionGroupBox.Name = "TransactionGroupBox";
            this.TransactionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.TransactionGroupBox.Size = new System.Drawing.Size(528, 236);
            this.TransactionGroupBox.TabIndex = 3;
            this.TransactionGroupBox.TabStop = false;
            this.TransactionGroupBox.Text = "Transaction";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(299, 193);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(208, 28);
            this.totalLabel.TabIndex = 13;
            // 
            // prixLabel
            // 
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prixLabel.Location = new System.Drawing.Point(299, 152);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(208, 28);
            this.prixLabel.TabIndex = 12;
            // 
            // dateReservationDateTimePicker
            // 
            this.dateReservationDateTimePicker.Location = new System.Drawing.Point(236, 35);
            this.dateReservationDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateReservationDateTimePicker.Name = "dateReservationDateTimePicker";
            this.dateReservationDateTimePicker.Size = new System.Drawing.Size(271, 23);
            this.dateReservationDateTimePicker.TabIndex = 11;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(236, 112);
            this.serviceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(271, 24);
            this.serviceComboBox.TabIndex = 10;
            // 
            // typeChambreComboBox
            // 
            this.typeChambreComboBox.FormattingEnabled = true;
            this.typeChambreComboBox.Location = new System.Drawing.Point(236, 72);
            this.typeChambreComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeChambreComboBox.Name = "typeChambreComboBox";
            this.typeChambreComboBox.Size = new System.Drawing.Size(271, 24);
            this.typeChambreComboBox.TabIndex = 9;
            // 
            // totalLLabel
            // 
            this.totalLLabel.AutoSize = true;
            this.totalLLabel.Location = new System.Drawing.Point(29, 204);
            this.totalLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLLabel.Name = "totalLLabel";
            this.totalLLabel.Size = new System.Drawing.Size(44, 17);
            this.totalLLabel.TabIndex = 4;
            this.totalLLabel.Text = "Total:";
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(29, 163);
            this.prixLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(35, 17);
            this.prixLLabel.TabIndex = 5;
            this.prixLLabel.Text = "Prix:";
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new System.Drawing.Point(29, 119);
            this.servicesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(66, 17);
            this.servicesLabel.TabIndex = 6;
            this.servicesLabel.Text = "Services:";
            // 
            // typeChambreLabel
            // 
            this.typeChambreLabel.AutoSize = true;
            this.typeChambreLabel.Location = new System.Drawing.Point(29, 79);
            this.typeChambreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeChambreLabel.Name = "typeChambreLabel";
            this.typeChambreLabel.Size = new System.Drawing.Size(123, 17);
            this.typeChambreLabel.TabIndex = 7;
            this.typeChambreLabel.Text = "Type de chambre:";
            // 
            // dateReservationLabel
            // 
            this.dateReservationLabel.AutoSize = true;
            this.dateReservationLabel.Location = new System.Drawing.Point(29, 41);
            this.dateReservationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateReservationLabel.Name = "dateReservationLabel";
            this.dateReservationLabel.Size = new System.Drawing.Size(137, 17);
            this.dateReservationLabel.TabIndex = 8;
            this.dateReservationLabel.Text = "Date de reservation:";
            // 
            // gestionReservationsHotelsMenuStrip
            // 
            this.gestionReservationsHotelsMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gestionReservationsHotelsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem1});
            this.gestionReservationsHotelsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.gestionReservationsHotelsMenuStrip.Name = "gestionReservationsHotelsMenuStrip";
            this.gestionReservationsHotelsMenuStrip.Size = new System.Drawing.Size(606, 28);
            this.gestionReservationsHotelsMenuStrip.TabIndex = 4;
            this.gestionReservationsHotelsMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem1
            // 
            this.transactionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem1,
            this.imprimerToolStripMenuItem1});
            this.transactionToolStripMenuItem1.Name = "transactionToolStripMenuItem1";
            this.transactionToolStripMenuItem1.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem1.Text = "Transaction";
            // 
            // enregistrerToolStripMenuItem1
            // 
            this.enregistrerToolStripMenuItem1.Name = "enregistrerToolStripMenuItem1";
            this.enregistrerToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.enregistrerToolStripMenuItem1.Text = "&Enregistrer";
            // 
            // imprimerToolStripMenuItem1
            // 
            this.imprimerToolStripMenuItem1.Name = "imprimerToolStripMenuItem1";
            this.imprimerToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.imprimerToolStripMenuItem1.Text = "&Imprimer";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imprimerToolStripMenuItem.Text = "&Imprimer";
            // 
            // GestionReservationsHotelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 639);
            this.Controls.Add(this.TransactionGroupBox);
            this.Controls.Add(this.informationClientGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gestionReservationsHotelsMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.gestionReservationsHotelsMenuStrip;
            this.Name = "GestionReservationsHotelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Réservations pour Hôtels";
            this.Load += new System.EventHandler(this.GestionReservationsHotelsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.informationClientGroupBox.ResumeLayout(false);
            this.informationClientGroupBox.PerformLayout();
            this.TransactionGroupBox.ResumeLayout(false);
            this.TransactionGroupBox.PerformLayout();
            this.gestionReservationsHotelsMenuStrip.ResumeLayout(false);
            this.gestionReservationsHotelsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox informationClientGroupBox;
        private System.Windows.Forms.GroupBox TransactionGroupBox;
        private System.Windows.Forms.Label courrielLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label prixLabel;
        private System.Windows.Forms.DateTimePicker dateReservationDateTimePicker;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.ComboBox typeChambreComboBox;
        private System.Windows.Forms.Label totalLLabel;
        private System.Windows.Forms.Label prixLLabel;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.Label typeChambreLabel;
        private System.Windows.Forms.Label dateReservationLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.MenuStrip gestionReservationsHotelsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem1;
    }
}

