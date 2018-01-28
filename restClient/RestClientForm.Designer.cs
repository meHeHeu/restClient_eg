namespace restClient
{
    partial class RestClientForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.statusCodeTextBox = new System.Windows.Forms.TextBox();
            this.statusCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(90, 27);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(336, 20);
            this.urlTextBox.TabIndex = 0;
            // 
            // responseTextBox
            // 
            this.responseTextBox.Location = new System.Drawing.Point(90, 283);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseTextBox.Size = new System.Drawing.Size(417, 197);
            this.responseTextBox.TabIndex = 1;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(432, 25);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 30);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 3;
            this.urlLabel.Text = "URL";
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(12, 286);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(55, 13);
            this.responseLabel.TabIndex = 4;
            this.responseLabel.Text = "Response";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(90, 80);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bodyTextBox.Size = new System.Drawing.Size(417, 197);
            this.bodyTextBox.TabIndex = 5;
            // 
            // methodComboBox
            // 
            this.methodComboBox.DisplayMember = "0";
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.methodComboBox.Location = new System.Drawing.Point(90, 53);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(121, 21);
            this.methodComboBox.TabIndex = 6;
            this.methodComboBox.Text = "GET";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(13, 53);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(43, 13);
            this.methodLabel.TabIndex = 7;
            this.methodLabel.Text = "Method";
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(16, 80);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(31, 13);
            this.bodyLabel.TabIndex = 8;
            this.bodyLabel.Text = "Body";
            // 
            // statusCodeTextBox
            // 
            this.statusCodeTextBox.Location = new System.Drawing.Point(90, 487);
            this.statusCodeTextBox.Name = "statusCodeTextBox";
            this.statusCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusCodeTextBox.TabIndex = 9;
            // 
            // statusCodeLabel
            // 
            this.statusCodeLabel.AutoSize = true;
            this.statusCodeLabel.Location = new System.Drawing.Point(13, 487);
            this.statusCodeLabel.Name = "statusCodeLabel";
            this.statusCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.statusCodeLabel.TabIndex = 10;
            this.statusCodeLabel.Text = "Status code";
            // 
            // RestClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 535);
            this.Controls.Add(this.statusCodeLabel);
            this.Controls.Add(this.statusCodeTextBox);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Name = "RestClientForm";
            this.Text = "REST client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.TextBox statusCodeTextBox;
        private System.Windows.Forms.Label statusCodeLabel;
    }
}

