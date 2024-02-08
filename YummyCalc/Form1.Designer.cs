namespace YummyCalc {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circ2Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price1Text = new System.Windows.Forms.TextBox();
            this.price2Text = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.surfaceArea1 = new System.Windows.Forms.Label();
            this.surfaceArea2 = new System.Windows.Forms.Label();
            this.ratio1Text = new System.Windows.Forms.Label();
            this.ratio2Text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circ1Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // circ2Text
            // 
            this.circ2Text.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.circ2Text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.circ2Text.Location = new System.Drawing.Point(317, 103);
            this.circ2Text.Name = "circ2Text";
            this.circ2Text.Size = new System.Drawing.Size(163, 41);
            this.circ2Text.TabIndex = 1;
            this.circ2Text.Text = "diameter";
            this.circ2Text.Click += new System.EventHandler(this.circ2Text_Click);
            this.circ2Text.TextChanged += new System.EventHandler(this.circ2Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(314, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Pizza";
            // 
            // price1Text
            // 
            this.price1Text.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.price1Text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.price1Text.Location = new System.Drawing.Point(12, 183);
            this.price1Text.Name = "price1Text";
            this.price1Text.Size = new System.Drawing.Size(161, 41);
            this.price1Text.TabIndex = 6;
            this.price1Text.Text = "price";
            this.price1Text.Click += new System.EventHandler(this.price1Text_Click);
            this.price1Text.TextChanged += new System.EventHandler(this.price1Text_TextChanged);
            // 
            // price2Text
            // 
            this.price2Text.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.price2Text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.price2Text.Location = new System.Drawing.Point(317, 183);
            this.price2Text.Name = "price2Text";
            this.price2Text.Size = new System.Drawing.Size(163, 41);
            this.price2Text.TabIndex = 7;
            this.price2Text.Text = "price";
            this.price2Text.Click += new System.EventHandler(this.price2Text_Click);
            this.price2Text.TextChanged += new System.EventHandler(this.price2Text_TextChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BackColor = System.Drawing.Color.Silver;
            this.output.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.output.Location = new System.Drawing.Point(12, 327);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(206, 34);
            this.output.TabIndex = 8;
            this.output.Text = "The better deal is";
            // 
            // surfaceArea1
            // 
            this.surfaceArea1.AutoSize = true;
            this.surfaceArea1.BackColor = System.Drawing.Color.Silver;
            this.surfaceArea1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceArea1.Location = new System.Drawing.Point(12, 146);
            this.surfaceArea1.Name = "surfaceArea1";
            this.surfaceArea1.Size = new System.Drawing.Size(246, 34);
            this.surfaceArea1.TabIndex = 9;
            this.surfaceArea1.Text = "Surface area is 0cm²";
            // 
            // surfaceArea2
            // 
            this.surfaceArea2.AutoSize = true;
            this.surfaceArea2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.surfaceArea2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.surfaceArea2.Location = new System.Drawing.Point(314, 146);
            this.surfaceArea2.Name = "surfaceArea2";
            this.surfaceArea2.Size = new System.Drawing.Size(246, 34);
            this.surfaceArea2.TabIndex = 10;
            this.surfaceArea2.Text = "Surface area is 0cm²";
            // 
            // ratio1Text
            // 
            this.ratio1Text.AutoSize = true;
            this.ratio1Text.BackColor = System.Drawing.Color.Silver;
            this.ratio1Text.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.ratio1Text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ratio1Text.Location = new System.Drawing.Point(12, 227);
            this.ratio1Text.Name = "ratio1Text";
            this.ratio1Text.Size = new System.Drawing.Size(260, 34);
            this.ratio1Text.TabIndex = 11;
            this.ratio1Text.Text = "Pizza to price ratio is";
            // 
            // ratio2Text
            // 
            this.ratio2Text.AutoSize = true;
            this.ratio2Text.BackColor = System.Drawing.Color.Silver;
            this.ratio2Text.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.ratio2Text.ForeColor = System.Drawing.Color.Black;
            this.ratio2Text.Location = new System.Drawing.Point(12, 276);
            this.ratio2Text.Name = "ratio2Text";
            this.ratio2Text.Size = new System.Drawing.Size(260, 34);
            this.ratio2Text.TabIndex = 12;
            this.ratio2Text.Text = "Pizza to price ratio is";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Pizza";
            // 
            // circ1Text
            // 
            this.circ1Text.BackColor = System.Drawing.SystemColors.Window;
            this.circ1Text.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold);
            this.circ1Text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.circ1Text.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.circ1Text.Location = new System.Drawing.Point(9, 103);
            this.circ1Text.Name = "circ1Text";
            this.circ1Text.Size = new System.Drawing.Size(164, 41);
            this.circ1Text.TabIndex = 0;
            this.circ1Text.Text = "diameter";
            this.circ1Text.Click += new System.EventHandler(this.circ1Text_Click);
            this.circ1Text.TextChanged += new System.EventHandler(this.circ1Text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YummyCalc.Properties.Resources.pizza;
            this.ClientSize = new System.Drawing.Size(613, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ratio2Text);
            this.Controls.Add(this.ratio1Text);
            this.Controls.Add(this.surfaceArea2);
            this.Controls.Add(this.surfaceArea1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.price2Text);
            this.Controls.Add(this.price1Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.circ2Text);
            this.Controls.Add(this.circ1Text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Yummy Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox circ2Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price1Text;
        private System.Windows.Forms.TextBox price2Text;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label surfaceArea1;
        private System.Windows.Forms.Label surfaceArea2;
        private System.Windows.Forms.Label ratio1Text;
        private System.Windows.Forms.Label ratio2Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox circ1Text;
    }
}

