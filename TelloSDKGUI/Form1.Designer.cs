
namespace TelloSDKGUI
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inputNumOfTello = new System.Windows.Forms.TextBox();
            this.labelNumOfTello = new System.Windows.Forms.Label();
            this.numOfTello = new System.Windows.Forms.NumericUpDown();
            this.serialNumberPanel = new System.Windows.Forms.Panel();
            this.serialNumbarTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTello)).BeginInit();
            this.serialNumberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(486, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // inputNumOfTello
            // 
            this.inputNumOfTello.Location = new System.Drawing.Point(486, 213);
            this.inputNumOfTello.Name = "inputNumOfTello";
            this.inputNumOfTello.Size = new System.Drawing.Size(150, 31);
            this.inputNumOfTello.TabIndex = 1;
            this.inputNumOfTello.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNumOfTello
            // 
            this.labelNumOfTello.AutoSize = true;
            this.labelNumOfTello.Location = new System.Drawing.Point(55, 15);
            this.labelNumOfTello.Name = "labelNumOfTello";
            this.labelNumOfTello.Size = new System.Drawing.Size(90, 25);
            this.labelNumOfTello.TabIndex = 2;
            this.labelNumOfTello.Text = "텔로 개수";
            this.labelNumOfTello.Click += new System.EventHandler(this.label1_Click);
            // 
            // numOfTello
            // 
            this.numOfTello.Location = new System.Drawing.Point(151, 13);
            this.numOfTello.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfTello.Name = "numOfTello";
            this.numOfTello.Size = new System.Drawing.Size(180, 31);
            this.numOfTello.TabIndex = 3;
            this.numOfTello.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // serialNumberPanel
            // 
            this.serialNumberPanel.Controls.Add(this.serialNumbarTable);
            this.serialNumberPanel.Location = new System.Drawing.Point(55, 61);
            this.serialNumberPanel.Name = "serialNumberPanel";
            this.serialNumberPanel.Size = new System.Drawing.Size(300, 150);
            this.serialNumberPanel.TabIndex = 4;
            // 
            // serialNumbarTable
            // 
            this.serialNumbarTable.ColumnCount = 2;
            this.serialNumbarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serialNumbarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serialNumbarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.serialNumbarTable.Location = new System.Drawing.Point(0, 0);
            this.serialNumbarTable.Name = "serialNumbarTable";
            this.serialNumbarTable.RowCount = 2;
            this.serialNumbarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serialNumbarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serialNumbarTable.Size = new System.Drawing.Size(300, 150);
            this.serialNumbarTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serialNumberPanel);
            this.Controls.Add(this.numOfTello);
            this.Controls.Add(this.labelNumOfTello);
            this.Controls.Add(this.inputNumOfTello);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfTello)).EndInit();
            this.serialNumberPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox inputNumOfTello;
        private System.Windows.Forms.Label labelNumOfTello;
        private System.Windows.Forms.NumericUpDown numOfTello;
        private System.Windows.Forms.Panel serialNumberPanel;
        private System.Windows.Forms.TableLayoutPanel serialNumbarTable;
    }
}

