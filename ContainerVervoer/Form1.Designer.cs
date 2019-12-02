namespace ContainerVervoer
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
            this.addContainer = new System.Windows.Forms.Button();
            this.valueSetter = new System.Windows.Forms.ComboBox();
            this.cooledSetter = new System.Windows.Forms.ComboBox();
            this.weightSetter = new System.Windows.Forms.TextBox();
            this.containersToSortList = new System.Windows.Forms.ListBox();
            this.startSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shipLengthSelector = new System.Windows.Forms.TextBox();
            this.shipWidthSelector = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addContainer
            // 
            this.addContainer.Location = new System.Drawing.Point(92, 477);
            this.addContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addContainer.Name = "addContainer";
            this.addContainer.Size = new System.Drawing.Size(182, 35);
            this.addContainer.TabIndex = 0;
            this.addContainer.Text = "Add containers";
            this.addContainer.UseVisualStyleBackColor = true;
            this.addContainer.Click += new System.EventHandler(this.AddContainer_Click);
            // 
            // valueSetter
            // 
            this.valueSetter.FormattingEnabled = true;
            this.valueSetter.Location = new System.Drawing.Point(92, 260);
            this.valueSetter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valueSetter.Name = "valueSetter";
            this.valueSetter.Size = new System.Drawing.Size(180, 28);
            this.valueSetter.TabIndex = 1;
            // 
            // cooledSetter
            // 
            this.cooledSetter.FormattingEnabled = true;
            this.cooledSetter.Location = new System.Drawing.Point(92, 337);
            this.cooledSetter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cooledSetter.Name = "cooledSetter";
            this.cooledSetter.Size = new System.Drawing.Size(180, 28);
            this.cooledSetter.TabIndex = 2;
            // 
            // weightSetter
            // 
            this.weightSetter.Location = new System.Drawing.Point(92, 414);
            this.weightSetter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightSetter.Name = "weightSetter";
            this.weightSetter.Size = new System.Drawing.Size(180, 26);
            this.weightSetter.TabIndex = 3;
            // 
            // containersToSortList
            // 
            this.containersToSortList.FormattingEnabled = true;
            this.containersToSortList.ItemHeight = 20;
            this.containersToSortList.Location = new System.Drawing.Point(468, 134);
            this.containersToSortList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containersToSortList.Name = "containersToSortList";
            this.containersToSortList.Size = new System.Drawing.Size(370, 164);
            this.containersToSortList.TabIndex = 4;
            // 
            // startSort
            // 
            this.startSort.Location = new System.Drawing.Point(92, 538);
            this.startSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startSort.Name = "startSort";
            this.startSort.Size = new System.Drawing.Size(182, 35);
            this.startSort.TabIndex = 5;
            this.startSort.Text = "Create stacks";
            this.startSort.UseVisualStyleBackColor = true;
            this.startSort.Click += new System.EventHandler(this.StartSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Value";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Cooled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ship length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ship width";
            // 
            // shipLengthSelector
            // 
            this.shipLengthSelector.Location = new System.Drawing.Point(91, 103);
            this.shipLengthSelector.Name = "shipLengthSelector";
            this.shipLengthSelector.Size = new System.Drawing.Size(181, 26);
            this.shipLengthSelector.TabIndex = 11;
            // 
            // shipWidthSelector
            // 
            this.shipWidthSelector.Location = new System.Drawing.Point(91, 184);
            this.shipWidthSelector.Name = "shipWidthSelector";
            this.shipWidthSelector.Size = new System.Drawing.Size(181, 26);
            this.shipWidthSelector.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.shipWidthSelector);
            this.Controls.Add(this.shipLengthSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startSort);
            this.Controls.Add(this.containersToSortList);
            this.Controls.Add(this.weightSetter);
            this.Controls.Add(this.cooledSetter);
            this.Controls.Add(this.valueSetter);
            this.Controls.Add(this.addContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addContainer;
        private System.Windows.Forms.ComboBox valueSetter;
        private System.Windows.Forms.ComboBox cooledSetter;
        private System.Windows.Forms.TextBox weightSetter;
        private System.Windows.Forms.ListBox containersToSortList;
        private System.Windows.Forms.Button startSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shipLengthSelector;
        private System.Windows.Forms.TextBox shipWidthSelector;
    }
}

