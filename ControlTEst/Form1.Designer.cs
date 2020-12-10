namespace ControlTEst
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonEQ = new System.Windows.Forms.Button();
            this.textBoxRes2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число А:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число B:";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(125, 7);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 29);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxAandB_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(125, 51);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 29);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxAandB_TextChanged);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes.Location = new System.Drawing.Point(298, 23);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ReadOnly = true;
            this.textBoxRes.Size = new System.Drawing.Size(208, 42);
            this.textBoxRes.TabIndex = 4;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonADD.Location = new System.Drawing.Point(241, 23);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(51, 42);
            this.buttonADD.TabIndex = 5;
            this.buttonADD.Text = "+";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(17, 104);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 29);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(17, 130);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 29);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(17, 154);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 29);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "*";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(17, 177);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 29);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "/";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonEQ
            // 
            this.buttonEQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEQ.Location = new System.Drawing.Point(108, 130);
            this.buttonEQ.Name = "buttonEQ";
            this.buttonEQ.Size = new System.Drawing.Size(51, 42);
            this.buttonEQ.TabIndex = 10;
            this.buttonEQ.Text = "=";
            this.buttonEQ.UseVisualStyleBackColor = true;
            this.buttonEQ.Click += new System.EventHandler(this.buttonEQ_Click);
            // 
            // textBoxRes2
            // 
            this.textBoxRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes2.Location = new System.Drawing.Point(165, 130);
            this.textBoxRes2.Name = "textBoxRes2";
            this.textBoxRes2.ReadOnly = true;
            this.textBoxRes2.Size = new System.Drawing.Size(208, 42);
            this.textBoxRes2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 364);
            this.Controls.Add(this.textBoxRes2);
            this.Controls.Add(this.buttonEQ);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonEQ;
        private System.Windows.Forms.TextBox textBoxRes2;
    }
}

