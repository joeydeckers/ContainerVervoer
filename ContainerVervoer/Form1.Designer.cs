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
            this.containerGenerator = new System.Windows.Forms.Button();
            this.stackList = new System.Windows.Forms.ListBox();
            this.createRows = new System.Windows.Forms.Button();
            this.rowsList = new System.Windows.Forms.ListBox();
            this.setShip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addContainer
            // 
            this.addContainer.Location = new System.Drawing.Point(61, 310);
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
            this.valueSetter.Location = new System.Drawing.Point(61, 169);
            this.valueSetter.Name = "valueSetter";
            this.valueSetter.Size = new System.Drawing.Size(121, 21);
            this.valueSetter.TabIndex = 1;
            // 
            // cooledSetter
            // 
            this.cooledSetter.FormattingEnabled = true;
            this.cooledSetter.Location = new System.Drawing.Point(61, 219);
            this.cooledSetter.Name = "cooledSetter";
            this.cooledSetter.Size = new System.Drawing.Size(121, 21);
            this.cooledSetter.TabIndex = 2;
            // 
            // weightSetter
            // 
            this.weightSetter.Location = new System.Drawing.Point(61, 269);
            this.weightSetter.Name = "weightSetter";
            this.weightSetter.Size = new System.Drawing.Size(121, 20);
            this.weightSetter.TabIndex = 3;
            // 
            // containersToSortList
            // 
            this.containersToSortList.FormattingEnabled = true;
            this.containersToSortList.Location = new System.Drawing.Point(215, 67);
            this.containersToSortList.Name = "containersToSortList";
            this.containersToSortList.Size = new System.Drawing.Size(248, 108);
            this.containersToSortList.TabIndex = 4;
            // 
            // startSort
            // 
            this.startSort.Location = new System.Drawing.Point(61, 350);
            this.startSort.Name = "startSort";
            this.startSort.Size = new System.Drawing.Size(121, 23);
            this.startSort.TabIndex = 5;
            this.startSort.Text = "Create stacks";
            this.startSort.UseVisualStyleBackColor = true;
            this.startSort.Click += new System.EventHandler(this.StartSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Value";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Cooled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ship length (werkt nog niet)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ship width";
            // 
            // shipLengthSelector
            // 
            this.shipLengthSelector.Location = new System.Drawing.Point(494, 337);
            this.shipLengthSelector.Margin = new System.Windows.Forms.Padding(2);
            this.shipLengthSelector.Name = "shipLengthSelector";
            this.shipLengthSelector.Size = new System.Drawing.Size(122, 20);
            this.shipLengthSelector.TabIndex = 11;
            // 
            // shipWidthSelector
            // 
            this.shipWidthSelector.Location = new System.Drawing.Point(494, 390);
            this.shipWidthSelector.Margin = new System.Windows.Forms.Padding(2);
            this.shipWidthSelector.Name = "shipWidthSelector";
            this.shipWidthSelector.Size = new System.Drawing.Size(122, 20);
            this.shipWidthSelector.TabIndex = 12;
            // 
            // containerGenerator
            // 
            this.containerGenerator.Location = new System.Drawing.Point(231, 287);
            this.containerGenerator.Name = "containerGenerator";
            this.containerGenerator.Size = new System.Drawing.Size(232, 86);
            this.containerGenerator.TabIndex = 13;
            this.containerGenerator.Text = "Generate containers";
            this.containerGenerator.UseVisualStyleBackColor = true;
            this.containerGenerator.Click += new System.EventHandler(this.ContainerGenerator_Click);
            // 
            // stackList
            // 
            this.stackList.FormattingEnabled = true;
            this.stackList.Location = new System.Drawing.Point(494, 67);
            this.stackList.Name = "stackList";
            this.stackList.Size = new System.Drawing.Size(277, 108);
            this.stackList.TabIndex = 14;
            // 
            // createRows
            // 
            this.createRows.Location = new System.Drawing.Point(64, 396);
            this.createRows.Name = "createRows";
            this.createRows.Size = new System.Drawing.Size(118, 23);
            this.createRows.TabIndex = 15;
            this.createRows.Text = "Create rows";
            this.createRows.UseVisualStyleBackColor = true;
            this.createRows.Click += new System.EventHandler(this.CreateRows_Click);
            // 
            // rowsList
            // 
            this.rowsList.FormattingEnabled = true;
            this.rowsList.Location = new System.Drawing.Point(494, 194);
            this.rowsList.Name = "rowsList";
            this.rowsList.Size = new System.Drawing.Size(277, 108);
            this.rowsList.TabIndex = 16;
            // 
            // setShip
            // 
            this.setShip.Location = new System.Drawing.Point(494, 415);
            this.setShip.Name = "setShip";
            this.setShip.Size = new System.Drawing.Size(75, 23);
            this.setShip.TabIndex = 17;
            this.setShip.Text = "Set ship";
            this.setShip.UseVisualStyleBackColor = true;
            this.setShip.Click += new System.EventHandler(this.SetShip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setShip);
            this.Controls.Add(this.rowsList);
            this.Controls.Add(this.createRows);
            this.Controls.Add(this.stackList);
            this.Controls.Add(this.containerGenerator);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button containerGenerator;
        private System.Windows.Forms.ListBox stackList;
        private System.Windows.Forms.Button createRows;
        private System.Windows.Forms.ListBox rowsList;
        private System.Windows.Forms.Button setShip;
    }
}

