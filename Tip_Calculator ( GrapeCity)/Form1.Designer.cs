
namespace Tip_Calculator___GrapeCity_
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
            this.label1 = new System.Windows.Forms.Label();
            this.billtextbox = new System.Windows.Forms.TextBox();
            this.Tiptestbox = new System.Windows.Forms.NumericUpDown();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.persontextbox = new System.Windows.Forms.NumericUpDown();
            this.totaltextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tippersontextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tiptestbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill ";
            // 
            // billtextbox
            // 
            this.billtextbox.Location = new System.Drawing.Point(170, 19);
            this.billtextbox.Name = "billtextbox";
            this.billtextbox.Size = new System.Drawing.Size(125, 27);
            this.billtextbox.TabIndex = 1;
            this.billtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billtextbox_KeyPress);
            // 
            // Tiptestbox
            // 
            this.Tiptestbox.Location = new System.Drawing.Point(170, 68);
            this.Tiptestbox.Name = "Tiptestbox";
            this.Tiptestbox.Size = new System.Drawing.Size(150, 27);
            this.Tiptestbox.TabIndex = 2;
            // 
            // calculatebtn
            // 
            this.calculatebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculatebtn.Location = new System.Drawing.Point(170, 339);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(94, 29);
            this.calculatebtn.TabIndex = 3;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of People";
            // 
            // persontextbox
            // 
            this.persontextbox.Location = new System.Drawing.Point(170, 128);
            this.persontextbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.persontextbox.Name = "persontextbox";
            this.persontextbox.Size = new System.Drawing.Size(150, 27);
            this.persontextbox.TabIndex = 5;
            this.persontextbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // totaltextbox
            // 
            this.totaltextbox.Location = new System.Drawing.Point(170, 247);
            this.totaltextbox.Name = "totaltextbox";
            this.totaltextbox.ReadOnly = true;
            this.totaltextbox.Size = new System.Drawing.Size(125, 27);
            this.totaltextbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total (Per Person)\r\n";
            // 
            // tippersontextbox
            // 
            this.tippersontextbox.Location = new System.Drawing.Point(170, 186);
            this.tippersontextbox.Name = "tippersontextbox";
            this.tippersontextbox.ReadOnly = true;
            this.tippersontextbox.Size = new System.Drawing.Size(125, 27);
            this.tippersontextbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tip \r\nper person\r\n";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exitbtn.Location = new System.Drawing.Point(605, 339);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(94, 29);
            this.Exitbtn.TabIndex = 12;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearbtn.Location = new System.Drawing.Point(367, 339);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(94, 29);
            this.clearbtn.TabIndex = 13;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.tippersontextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totaltextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.persontextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.Tiptestbox);
            this.Controls.Add(this.billtextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            
            ((System.ComponentModel.ISupportInitialize)(this.Tiptestbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billtextbox;
        private System.Windows.Forms.NumericUpDown Tiptestbox;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown persontextbox;
        private System.Windows.Forms.TextBox totaltextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tippersontextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}

