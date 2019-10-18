namespace Shopping
{
    partial class shoppingForm
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
            this.shoppingListListBox = new System.Windows.Forms.ListBox();
            this.shoppingListListBoxLabel = new System.Windows.Forms.Label();
            this.varansNamnTextBox = new System.Windows.Forms.TextBox();
            this.varansPrisTextBox = new System.Windows.Forms.TextBox();
            this.varansNamnLabel = new System.Windows.Forms.Label();
            this.varansPrisLabel = new System.Windows.Forms.Label();
            this.billigasteVaranLabel = new System.Windows.Forms.Label();
            this.dyrasteVaranLabel = new System.Windows.Forms.Label();
            this.addVaraButton = new System.Windows.Forms.Button();
            this.dyrasteListBox = new System.Windows.Forms.ListBox();
            this.billigasteListBox = new System.Windows.Forms.ListBox();
            this.krLabel = new System.Windows.Forms.Label();
            this.taBortVaraButton = new System.Windows.Forms.Button();
            this.summaListBox = new System.Windows.Forms.ListBox();
            this.summaLabel = new System.Windows.Forms.Label();
            this.krlabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shoppingListListBox
            // 
            this.shoppingListListBox.FormattingEnabled = true;
            this.shoppingListListBox.Location = new System.Drawing.Point(36, 211);
            this.shoppingListListBox.Name = "shoppingListListBox";
            this.shoppingListListBox.Size = new System.Drawing.Size(210, 121);
            this.shoppingListListBox.TabIndex = 0;
            // 
            // shoppingListListBoxLabel
            // 
            this.shoppingListListBoxLabel.AutoSize = true;
            this.shoppingListListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListListBoxLabel.Location = new System.Drawing.Point(20, 21);
            this.shoppingListListBoxLabel.Name = "shoppingListListBoxLabel";
            this.shoppingListListBoxLabel.Size = new System.Drawing.Size(165, 33);
            this.shoppingListListBoxLabel.TabIndex = 1;
            this.shoppingListListBoxLabel.Text = "Inköpslista";
            // 
            // varansNamnTextBox
            // 
            this.varansNamnTextBox.Location = new System.Drawing.Point(118, 116);
            this.varansNamnTextBox.Name = "varansNamnTextBox";
            this.varansNamnTextBox.Size = new System.Drawing.Size(100, 20);
            this.varansNamnTextBox.TabIndex = 2;
            // 
            // varansPrisTextBox
            // 
            this.varansPrisTextBox.Location = new System.Drawing.Point(118, 151);
            this.varansPrisTextBox.Name = "varansPrisTextBox";
            this.varansPrisTextBox.Size = new System.Drawing.Size(100, 20);
            this.varansPrisTextBox.TabIndex = 3;
            this.varansPrisTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VaransPrisTextBox_KeyPress);
            this.varansPrisTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VaransPrisTextBox_KeyUp);
            // 
            // varansNamnLabel
            // 
            this.varansNamnLabel.AutoSize = true;
            this.varansNamnLabel.Location = new System.Drawing.Point(33, 123);
            this.varansNamnLabel.Name = "varansNamnLabel";
            this.varansNamnLabel.Size = new System.Drawing.Size(72, 13);
            this.varansNamnLabel.TabIndex = 4;
            this.varansNamnLabel.Text = "Varans namn:";
            // 
            // varansPrisLabel
            // 
            this.varansPrisLabel.AutoSize = true;
            this.varansPrisLabel.Location = new System.Drawing.Point(33, 158);
            this.varansPrisLabel.Name = "varansPrisLabel";
            this.varansPrisLabel.Size = new System.Drawing.Size(62, 13);
            this.varansPrisLabel.TabIndex = 5;
            this.varansPrisLabel.Text = "Varans pris:";
            // 
            // billigasteVaranLabel
            // 
            this.billigasteVaranLabel.AutoSize = true;
            this.billigasteVaranLabel.Location = new System.Drawing.Point(33, 477);
            this.billigasteVaranLabel.Name = "billigasteVaranLabel";
            this.billigasteVaranLabel.Size = new System.Drawing.Size(81, 13);
            this.billigasteVaranLabel.TabIndex = 9;
            this.billigasteVaranLabel.Text = "Billigaste varan:";
            // 
            // dyrasteVaranLabel
            // 
            this.dyrasteVaranLabel.AutoSize = true;
            this.dyrasteVaranLabel.Location = new System.Drawing.Point(33, 397);
            this.dyrasteVaranLabel.Name = "dyrasteVaranLabel";
            this.dyrasteVaranLabel.Size = new System.Drawing.Size(76, 13);
            this.dyrasteVaranLabel.TabIndex = 8;
            this.dyrasteVaranLabel.Text = "Dyraste varan:";
            // 
            // addVaraButton
            // 
            this.addVaraButton.Location = new System.Drawing.Point(143, 182);
            this.addVaraButton.Name = "addVaraButton";
            this.addVaraButton.Size = new System.Drawing.Size(75, 23);
            this.addVaraButton.TabIndex = 10;
            this.addVaraButton.Text = "Lägg till";
            this.addVaraButton.UseVisualStyleBackColor = true;
            this.addVaraButton.Click += new System.EventHandler(this.AddVaraButton_Click);
            // 
            // dyrasteListBox
            // 
            this.dyrasteListBox.BackColor = System.Drawing.Color.White;
            this.dyrasteListBox.FormattingEnabled = true;
            this.dyrasteListBox.Location = new System.Drawing.Point(156, 397);
            this.dyrasteListBox.Name = "dyrasteListBox";
            this.dyrasteListBox.Size = new System.Drawing.Size(143, 43);
            this.dyrasteListBox.TabIndex = 11;
            // 
            // billigasteListBox
            // 
            this.billigasteListBox.FormattingEnabled = true;
            this.billigasteListBox.Location = new System.Drawing.Point(156, 473);
            this.billigasteListBox.Name = "billigasteListBox";
            this.billigasteListBox.Size = new System.Drawing.Size(143, 43);
            this.billigasteListBox.TabIndex = 12;
            // 
            // krLabel
            // 
            this.krLabel.AutoSize = true;
            this.krLabel.Location = new System.Drawing.Point(224, 158);
            this.krLabel.Name = "krLabel";
            this.krLabel.Size = new System.Drawing.Size(16, 13);
            this.krLabel.TabIndex = 13;
            this.krLabel.Text = "kr";
            // 
            // taBortVaraButton
            // 
            this.taBortVaraButton.Location = new System.Drawing.Point(252, 309);
            this.taBortVaraButton.Name = "taBortVaraButton";
            this.taBortVaraButton.Size = new System.Drawing.Size(75, 23);
            this.taBortVaraButton.TabIndex = 14;
            this.taBortVaraButton.Text = "Ta bort";
            this.taBortVaraButton.UseVisualStyleBackColor = true;
            this.taBortVaraButton.Click += new System.EventHandler(this.DeleteVaraButton_Click);
            // 
            // summaListBox
            // 
            this.summaListBox.BackColor = System.Drawing.Color.White;
            this.summaListBox.FormattingEnabled = true;
            this.summaListBox.Location = new System.Drawing.Point(156, 338);
            this.summaListBox.Name = "summaListBox";
            this.summaListBox.Size = new System.Drawing.Size(46, 17);
            this.summaListBox.TabIndex = 16;
            // 
            // summaLabel
            // 
            this.summaLabel.AutoSize = true;
            this.summaLabel.Location = new System.Drawing.Point(33, 338);
            this.summaLabel.Name = "summaLabel";
            this.summaLabel.Size = new System.Drawing.Size(87, 13);
            this.summaLabel.TabIndex = 15;
            this.summaLabel.Text = "Summa av varor:";
            // 
            // krlabel2
            // 
            this.krlabel2.AutoSize = true;
            this.krlabel2.Location = new System.Drawing.Point(208, 342);
            this.krlabel2.Name = "krlabel2";
            this.krlabel2.Size = new System.Drawing.Size(16, 13);
            this.krlabel2.TabIndex = 17;
            this.krlabel2.Text = "kr";
            // 
            // shoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 552);
            this.Controls.Add(this.krlabel2);
            this.Controls.Add(this.summaListBox);
            this.Controls.Add(this.summaLabel);
            this.Controls.Add(this.taBortVaraButton);
            this.Controls.Add(this.krLabel);
            this.Controls.Add(this.billigasteListBox);
            this.Controls.Add(this.dyrasteListBox);
            this.Controls.Add(this.addVaraButton);
            this.Controls.Add(this.billigasteVaranLabel);
            this.Controls.Add(this.dyrasteVaranLabel);
            this.Controls.Add(this.varansPrisLabel);
            this.Controls.Add(this.varansNamnLabel);
            this.Controls.Add(this.varansPrisTextBox);
            this.Controls.Add(this.varansNamnTextBox);
            this.Controls.Add(this.shoppingListListBoxLabel);
            this.Controls.Add(this.shoppingListListBox);
            this.Name = "shoppingForm";
            this.Text = "Inköpslista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shoppingListListBox;
        private System.Windows.Forms.Label shoppingListListBoxLabel;
        private System.Windows.Forms.TextBox varansNamnTextBox;
        private System.Windows.Forms.TextBox varansPrisTextBox;
        private System.Windows.Forms.Label varansNamnLabel;
        private System.Windows.Forms.Label varansPrisLabel;
        private System.Windows.Forms.Label billigasteVaranLabel;
        private System.Windows.Forms.Label dyrasteVaranLabel;
        private System.Windows.Forms.Button addVaraButton;
        private System.Windows.Forms.ListBox dyrasteListBox;
        private System.Windows.Forms.ListBox billigasteListBox;
        private System.Windows.Forms.Label krLabel;
        private System.Windows.Forms.Button taBortVaraButton;
        private System.Windows.Forms.ListBox summaListBox;
        private System.Windows.Forms.Label summaLabel;
        private System.Windows.Forms.Label krlabel2;
    }
}

