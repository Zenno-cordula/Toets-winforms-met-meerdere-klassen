namespace _1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFactuur = new Label();
            lblFactuurID = new Label();
            lblNaamKlant = new Label();
            lblKlantNr = new Label();
            txtFactuurID = new TextBox();
            txtNaamKlant = new TextBox();
            txtKlantNr = new TextBox();
            btnFactuurAanmaken = new Button();
            lstFacturen = new ListBox();
            lblFactuurTotaal = new Label();
            lblFactuurLijn = new Label();
            lstFactuurLijnen = new ListBox();
            btnFactuurLijnAanmaken = new Button();
            txtPrijs = new TextBox();
            txtAantal = new TextBox();
            txtProduct = new TextBox();
            lblPrijs = new Label();
            lblAantal = new Label();
            lblProduct = new Label();
            SuspendLayout();
            // 
            // lblFactuur
            // 
            lblFactuur.AutoSize = true;
            lblFactuur.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFactuur.Location = new Point(44, 23);
            lblFactuur.Name = "lblFactuur";
            lblFactuur.Size = new Size(62, 20);
            lblFactuur.TabIndex = 0;
            lblFactuur.Text = "Factuur";
            // 
            // lblFactuurID
            // 
            lblFactuurID.AutoSize = true;
            lblFactuurID.Location = new Point(44, 63);
            lblFactuurID.Name = "lblFactuurID";
            lblFactuurID.Size = new Size(78, 20);
            lblFactuurID.TabIndex = 1;
            lblFactuurID.Text = "Factuur ID:";
            // 
            // lblNaamKlant
            // 
            lblNaamKlant.AutoSize = true;
            lblNaamKlant.Location = new Point(44, 108);
            lblNaamKlant.Name = "lblNaamKlant";
            lblNaamKlant.Size = new Size(88, 20);
            lblNaamKlant.TabIndex = 2;
            lblNaamKlant.Text = "Naam klant:";
            // 
            // lblKlantNr
            // 
            lblKlantNr.AutoSize = true;
            lblKlantNr.Location = new Point(44, 153);
            lblKlantNr.Name = "lblKlantNr";
            lblKlantNr.Size = new Size(101, 20);
            lblKlantNr.TabIndex = 3;
            lblKlantNr.Text = "Klantnummer:";
            // 
            // txtFactuurID
            // 
            txtFactuurID.Location = new Point(179, 60);
            txtFactuurID.Name = "txtFactuurID";
            txtFactuurID.Size = new Size(125, 27);
            txtFactuurID.TabIndex = 4;
            // 
            // txtNaamKlant
            // 
            txtNaamKlant.Location = new Point(179, 105);
            txtNaamKlant.Name = "txtNaamKlant";
            txtNaamKlant.Size = new Size(125, 27);
            txtNaamKlant.TabIndex = 5;
            // 
            // txtKlantNr
            // 
            txtKlantNr.Location = new Point(179, 150);
            txtKlantNr.Name = "txtKlantNr";
            txtKlantNr.Size = new Size(125, 27);
            txtKlantNr.TabIndex = 6;
            // 
            // btnFactuurAanmaken
            // 
            btnFactuurAanmaken.Location = new Point(44, 191);
            btnFactuurAanmaken.Name = "btnFactuurAanmaken";
            btnFactuurAanmaken.Size = new Size(260, 29);
            btnFactuurAanmaken.TabIndex = 7;
            btnFactuurAanmaken.Text = "Maak factuur aan";
            btnFactuurAanmaken.UseVisualStyleBackColor = true;
            btnFactuurAanmaken.Click += btnFactuurAanmaken_Click;
            // 
            // lstFacturen
            // 
            lstFacturen.FormattingEnabled = true;
            lstFacturen.Location = new Point(44, 236);
            lstFacturen.Name = "lstFacturen";
            lstFacturen.Size = new Size(260, 284);
            lstFacturen.TabIndex = 8;
            lstFacturen.SelectedIndexChanged += lstFacturen_SelectedIndexChanged;
            // 
            // lblFactuurTotaal
            // 
            lblFactuurTotaal.AutoSize = true;
            lblFactuurTotaal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFactuurTotaal.Location = new Point(44, 527);
            lblFactuurTotaal.Name = "lblFactuurTotaal";
            lblFactuurTotaal.Size = new Size(0, 20);
            lblFactuurTotaal.TabIndex = 9;
            // 
            // lblFactuurLijn
            // 
            lblFactuurLijn.AutoSize = true;
            lblFactuurLijn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFactuurLijn.Location = new Point(336, 23);
            lblFactuurLijn.Name = "lblFactuurLijn";
            lblFactuurLijn.Size = new Size(83, 20);
            lblFactuurLijn.TabIndex = 10;
            lblFactuurLijn.Text = "Factuurlijn";
            // 
            // lstFactuurLijnen
            // 
            lstFactuurLijnen.FormattingEnabled = true;
            lstFactuurLijnen.Location = new Point(336, 236);
            lstFactuurLijnen.Name = "lstFactuurLijnen";
            lstFactuurLijnen.Size = new Size(260, 284);
            lstFactuurLijnen.TabIndex = 18;
            // 
            // btnFactuurLijnAanmaken
            // 
            btnFactuurLijnAanmaken.Location = new Point(336, 191);
            btnFactuurLijnAanmaken.Name = "btnFactuurLijnAanmaken";
            btnFactuurLijnAanmaken.Size = new Size(260, 29);
            btnFactuurLijnAanmaken.TabIndex = 17;
            btnFactuurLijnAanmaken.Text = "Maak factuurlijn aan";
            btnFactuurLijnAanmaken.UseVisualStyleBackColor = true;
            btnFactuurLijnAanmaken.Click += btnFactuurLijnAanmaken_Click;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(471, 150);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(125, 27);
            txtPrijs.TabIndex = 16;
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(471, 105);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(125, 27);
            txtAantal.TabIndex = 15;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(471, 60);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(125, 27);
            txtProduct.TabIndex = 14;
            // 
            // lblPrijs
            // 
            lblPrijs.AutoSize = true;
            lblPrijs.Location = new Point(336, 153);
            lblPrijs.Name = "lblPrijs";
            lblPrijs.Size = new Size(39, 20);
            lblPrijs.TabIndex = 13;
            lblPrijs.Text = "Prijs:";
            // 
            // lblAantal
            // 
            lblAantal.AutoSize = true;
            lblAantal.Location = new Point(336, 108);
            lblAantal.Name = "lblAantal";
            lblAantal.Size = new Size(55, 20);
            lblAantal.TabIndex = 12;
            lblAantal.Text = "Aantal:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(336, 63);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(63, 20);
            lblProduct.TabIndex = 11;
            lblProduct.Text = "Product:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(lstFactuurLijnen);
            Controls.Add(btnFactuurLijnAanmaken);
            Controls.Add(txtPrijs);
            Controls.Add(txtAantal);
            Controls.Add(txtProduct);
            Controls.Add(lblPrijs);
            Controls.Add(lblAantal);
            Controls.Add(lblProduct);
            Controls.Add(lblFactuurLijn);
            Controls.Add(lblFactuurTotaal);
            Controls.Add(lstFacturen);
            Controls.Add(btnFactuurAanmaken);
            Controls.Add(txtKlantNr);
            Controls.Add(txtNaamKlant);
            Controls.Add(txtFactuurID);
            Controls.Add(lblKlantNr);
            Controls.Add(lblNaamKlant);
            Controls.Add(lblFactuurID);
            Controls.Add(lblFactuur);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFactuur;
        private Label lblFactuurID;
        private Label lblNaamKlant;
        private Label lblKlantNr;
        private TextBox txtFactuurID;
        private TextBox txtNaamKlant;
        private TextBox txtKlantNr;
        private Button btnFactuurAanmaken;
        private ListBox lstFacturen;
        private Label lblFactuurTotaal;
        private Label lblFactuurLijn;
        private ListBox lstFactuurLijnen;
        private Button btnFactuurLijnAanmaken;
        private TextBox txtPrijs;
        private TextBox txtAantal;
        private TextBox txtProduct;
        private Label lblPrijs;
        private Label lblAantal;
        private Label lblProduct;
    }
}
