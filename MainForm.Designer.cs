namespace UnicodeConverter
{
    partial class MainForm
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
            groupBox5 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            TextRTB = new System.Windows.Forms.RichTextBox();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            UnicodeRTB = new System.Windows.Forms.RichTextBox();
            DecimalRTB = new System.Windows.Forms.RichTextBox();
            groupBox5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.Controls.Add(tableLayoutPanel1);
            groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox5.Location = new System.Drawing.Point(0, 0);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new System.Drawing.Size(565, 304);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Unicode Converter";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TextRTB, 1, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(label12, 0, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 1);
            tableLayoutPanel1.Controls.Add(UnicodeRTB, 1, 1);
            tableLayoutPanel1.Controls.Add(DecimalRTB, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(4, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableLayoutPanel1.Size = new System.Drawing.Size(557, 279);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // TextRTB
            // 
            TextRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            TextRTB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextRTB.Location = new System.Drawing.Point(88, 3);
            TextRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextRTB.Name = "TextRTB";
            TextRTB.Size = new System.Drawing.Size(465, 86);
            TextRTB.TabIndex = 2;
            TextRTB.Text = "";
            TextRTB.TextChanged += new System.EventHandler(TextRTB_TextChanged);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(4, 185);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(63, 18);
            label10.TabIndex = 5;
            label10.Text = "Decimal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(4, 0);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(44, 18);
            label12.TabIndex = 0;
            label12.Text = "Text:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(4, 92);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(64, 18);
            label11.TabIndex = 3;
            label11.Text = "Unicode:";
            // 
            // UnicodeRTB
            // 
            UnicodeRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            UnicodeRTB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UnicodeRTB.Location = new System.Drawing.Point(88, 95);
            UnicodeRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UnicodeRTB.Name = "UnicodeRTB";
            UnicodeRTB.Size = new System.Drawing.Size(465, 87);
            UnicodeRTB.TabIndex = 4;
            UnicodeRTB.Text = "";
            UnicodeRTB.TextChanged += new System.EventHandler(UnicodeRTB_TextChanged);
            // 
            // DecimalRTB
            // 
            DecimalRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            DecimalRTB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DecimalRTB.Location = new System.Drawing.Point(88, 188);
            DecimalRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DecimalRTB.Name = "DecimalRTB";
            DecimalRTB.Size = new System.Drawing.Size(465, 88);
            DecimalRTB.TabIndex = 6;
            DecimalRTB.Text = "";
            DecimalRTB.TextChanged += new System.EventHandler(DecimalRTB_TextChanged);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(565, 304);
            Controls.Add(groupBox5);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(300, 150);
            Name = "MainForm";
            Text = "Unicode Converter";
            groupBox5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox TextRTB;
        private Label label10;
        private Label label12;
        private Label label11;
        private RichTextBox UnicodeRTB;
        private RichTextBox DecimalRTB;
    }
}

