namespace L4_t_p
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
            SearchNUD = new NumericUpDown();
            SearchButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)SearchNUD).BeginInit();
            SuspendLayout();
            // 
            // SearchNUD
            // 
            SearchNUD.Location = new Point(402, 569);
            SearchNUD.Name = "SearchNUD";
            SearchNUD.Size = new Size(150, 27);
            SearchNUD.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(581, 569);
            SearchButton.Margin = new Padding(2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(87, 27);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Искать";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 572);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 656);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(SearchNUD);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)SearchNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown SearchNUD;
        private Button SearchButton;
        private Label label1;
    }
}
