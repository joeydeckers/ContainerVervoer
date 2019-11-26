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
            this.SuspendLayout();
            // 
            // addContainer
            // 
            this.addContainer.Location = new System.Drawing.Point(174, 228);
            this.addContainer.Name = "addContainer";
            this.addContainer.Size = new System.Drawing.Size(121, 23);
            this.addContainer.TabIndex = 0;
            this.addContainer.Text = "Add containers";
            this.addContainer.UseVisualStyleBackColor = true;
            this.addContainer.Click += new System.EventHandler(this.AddContainer_Click);
            // 
            // valueSetter
            // 
            this.valueSetter.FormattingEnabled = true;
            this.valueSetter.Location = new System.Drawing.Point(174, 87);
            this.valueSetter.Name = "valueSetter";
            this.valueSetter.Size = new System.Drawing.Size(121, 21);
            this.valueSetter.TabIndex = 1;
            // 
            // cooledSetter
            // 
            this.cooledSetter.FormattingEnabled = true;
            this.cooledSetter.Location = new System.Drawing.Point(174, 137);
            this.cooledSetter.Name = "cooledSetter";
            this.cooledSetter.Size = new System.Drawing.Size(121, 21);
            this.cooledSetter.TabIndex = 2;
            // 
            // weightSetter
            // 
            this.weightSetter.Location = new System.Drawing.Point(174, 187);
            this.weightSetter.Name = "weightSetter";
            this.weightSetter.Size = new System.Drawing.Size(121, 20);
            this.weightSetter.TabIndex = 3;
            // 
            // containersToSortList
            // 
            this.containersToSortList.FormattingEnabled = true;
            this.containersToSortList.Location = new System.Drawing.Point(312, 87);
            this.containersToSortList.Name = "containersToSortList";
            this.containersToSortList.Size = new System.Drawing.Size(248, 108);
            this.containersToSortList.TabIndex = 4;
            // 
            // startSort
            // 
            this.startSort.Location = new System.Drawing.Point(174, 268);
            this.startSort.Name = "startSort";
            this.startSort.Size = new System.Drawing.Size(121, 23);
            this.startSort.TabIndex = 5;
            this.startSort.Text = "Begin sort";
            this.startSort.UseVisualStyleBackColor = true;
            this.startSort.Click += new System.EventHandler(this.StartSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Value";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Cooled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startSort);
            this.Controls.Add(this.containersToSortList);
            this.Controls.Add(this.weightSetter);
            this.Controls.Add(this.cooledSetter);
            this.Controls.Add(this.valueSetter);
            this.Controls.Add(this.addContainer);
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
    }
}

