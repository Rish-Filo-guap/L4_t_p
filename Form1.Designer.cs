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
            CreateTreeBTN = new Button();
            DelBTN = new Button();
            AddBTN = new Button();
            InfoLBL = new Label();
            ((System.ComponentModel.ISupportInitialize)SearchNUD).BeginInit();
            SuspendLayout();
            // 
            // SearchNUD
            // 
            SearchNUD.Location = new Point(402, 569);
            SearchNUD.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
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
            // CreateTreeBTN
            // 
            CreateTreeBTN.Location = new Point(700, 568);
            CreateTreeBTN.Margin = new Padding(2);
            CreateTreeBTN.Name = "CreateTreeBTN";
            CreateTreeBTN.Size = new Size(103, 27);
            CreateTreeBTN.TabIndex = 4;
            CreateTreeBTN.Text = "Построить";
            CreateTreeBTN.UseVisualStyleBackColor = true;
            CreateTreeBTN.Click += CreateTreeBTN_Click;
            // 
            // DelBTN
            // 
            DelBTN.Location = new Point(295, 569);
            DelBTN.Margin = new Padding(2);
            DelBTN.Name = "DelBTN";
            DelBTN.Size = new Size(87, 27);
            DelBTN.TabIndex = 5;
            DelBTN.Text = "Удалить";
            DelBTN.UseVisualStyleBackColor = true;
            DelBTN.Click += DelBTN_Click;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(425, 601);
            AddBTN.Margin = new Padding(2);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(87, 27);
            AddBTN.TabIndex = 6;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // InfoLBL
            // 
            InfoLBL.AutoSize = true;
            InfoLBL.Location = new Point(417, 528);
            InfoLBL.Name = "InfoLBL";
            InfoLBL.Size = new Size(95, 20);
            InfoLBL.TabIndex = 7;
            InfoLBL.Text = "пока ничего";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 656);
            Controls.Add(InfoLBL);
            Controls.Add(AddBTN);
            Controls.Add(DelBTN);
            Controls.Add(CreateTreeBTN);
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
        private Button CreateTreeBTN;
        private Button DelBTN;
        private Button AddBTN;
        private Label InfoLBL;
    }
}
