namespace Astronomical_Processing_V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonBinarySearch = new System.Windows.Forms.Button();
            this.buttonSequentialSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonMidExtreme = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.inputBinarySearch = new System.Windows.Forms.TextBox();
            this.inputSequentialSearch = new System.Windows.Forms.TextBox();
            this.inputEdit = new System.Windows.Forms.TextBox();
            this.resultMidExtreme = new System.Windows.Forms.TextBox();
            this.resultMode = new System.Windows.Forms.TextBox();
            this.resultAverage = new System.Windows.Forms.TextBox();
            this.resultRange = new System.Windows.Forms.TextBox();
            this.textToolTips = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 20;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 13);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(102, 484);
            this.listBoxDisplay.TabIndex = 0;
            this.listBoxDisplay.Click += new System.EventHandler(this.listBoxDisplay_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonQuit.Location = new System.Drawing.Point(120, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(77, 45);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonGetData
            // 
            this.buttonGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonGetData.Location = new System.Drawing.Point(203, 12);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(77, 45);
            this.buttonGetData.TabIndex = 3;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSort.Location = new System.Drawing.Point(286, 12);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(77, 45);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort Data";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonBinarySearch
            // 
            this.buttonBinarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBinarySearch.Location = new System.Drawing.Point(120, 63);
            this.buttonBinarySearch.Name = "buttonBinarySearch";
            this.buttonBinarySearch.Size = new System.Drawing.Size(94, 45);
            this.buttonBinarySearch.TabIndex = 5;
            this.buttonBinarySearch.Text = "Binary Search";
            this.buttonBinarySearch.UseVisualStyleBackColor = true;
            this.buttonBinarySearch.Click += new System.EventHandler(this.buttonBinarySearch_Click);
            // 
            // buttonSequentialSearch
            // 
            this.buttonSequentialSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSequentialSearch.Location = new System.Drawing.Point(120, 114);
            this.buttonSequentialSearch.Name = "buttonSequentialSearch";
            this.buttonSequentialSearch.Size = new System.Drawing.Size(94, 45);
            this.buttonSequentialSearch.TabIndex = 6;
            this.buttonSequentialSearch.Text = "Sequential Search";
            this.buttonSequentialSearch.UseVisualStyleBackColor = true;
            this.buttonSequentialSearch.Click += new System.EventHandler(this.buttonSequentialSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEdit.Location = new System.Drawing.Point(120, 165);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(94, 45);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit Data";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonMidExtreme
            // 
            this.buttonMidExtreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMidExtreme.Location = new System.Drawing.Point(120, 216);
            this.buttonMidExtreme.Name = "buttonMidExtreme";
            this.buttonMidExtreme.Size = new System.Drawing.Size(94, 45);
            this.buttonMidExtreme.TabIndex = 8;
            this.buttonMidExtreme.Text = "Mid-Extreme";
            this.buttonMidExtreme.UseVisualStyleBackColor = true;
            this.buttonMidExtreme.Click += new System.EventHandler(this.buttonMidExtreme_Click);
            // 
            // buttonMode
            // 
            this.buttonMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMode.Location = new System.Drawing.Point(120, 267);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(94, 45);
            this.buttonMode.TabIndex = 9;
            this.buttonMode.Text = "Mode";
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAverage.Location = new System.Drawing.Point(120, 318);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(94, 45);
            this.buttonAverage.TabIndex = 10;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRange.Location = new System.Drawing.Point(120, 369);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(94, 45);
            this.buttonRange.TabIndex = 11;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(120, 420);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(243, 77);
            this.messageBox.TabIndex = 12;
            // 
            // inputBinarySearch
            // 
            this.inputBinarySearch.Location = new System.Drawing.Point(220, 74);
            this.inputBinarySearch.Name = "inputBinarySearch";
            this.inputBinarySearch.Size = new System.Drawing.Size(143, 23);
            this.inputBinarySearch.TabIndex = 13;
            // 
            // inputSequentialSearch
            // 
            this.inputSequentialSearch.Location = new System.Drawing.Point(220, 125);
            this.inputSequentialSearch.Name = "inputSequentialSearch";
            this.inputSequentialSearch.Size = new System.Drawing.Size(143, 23);
            this.inputSequentialSearch.TabIndex = 14;
            // 
            // inputEdit
            // 
            this.inputEdit.Location = new System.Drawing.Point(220, 176);
            this.inputEdit.Name = "inputEdit";
            this.inputEdit.Size = new System.Drawing.Size(143, 23);
            this.inputEdit.TabIndex = 15;
            // 
            // resultMidExtreme
            // 
            this.resultMidExtreme.Location = new System.Drawing.Point(220, 216);
            this.resultMidExtreme.Multiline = true;
            this.resultMidExtreme.Name = "resultMidExtreme";
            this.resultMidExtreme.ReadOnly = true;
            this.resultMidExtreme.Size = new System.Drawing.Size(143, 45);
            this.resultMidExtreme.TabIndex = 16;
            // 
            // resultMode
            // 
            this.resultMode.Location = new System.Drawing.Point(220, 267);
            this.resultMode.Multiline = true;
            this.resultMode.Name = "resultMode";
            this.resultMode.ReadOnly = true;
            this.resultMode.Size = new System.Drawing.Size(143, 45);
            this.resultMode.TabIndex = 17;
            // 
            // resultAverage
            // 
            this.resultAverage.Location = new System.Drawing.Point(220, 318);
            this.resultAverage.Multiline = true;
            this.resultAverage.Name = "resultAverage";
            this.resultAverage.ReadOnly = true;
            this.resultAverage.Size = new System.Drawing.Size(143, 45);
            this.resultAverage.TabIndex = 18;
            // 
            // resultRange
            // 
            this.resultRange.Location = new System.Drawing.Point(220, 369);
            this.resultRange.Multiline = true;
            this.resultRange.Name = "resultRange";
            this.resultRange.ReadOnly = true;
            this.resultRange.Size = new System.Drawing.Size(143, 45);
            this.resultRange.TabIndex = 19;
            // 
            // textToolTips
            // 
            this.textToolTips.Location = new System.Drawing.Point(369, 33);
            this.textToolTips.Multiline = true;
            this.textToolTips.Name = "textToolTips";
            this.textToolTips.ReadOnly = true;
            this.textToolTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToolTips.Size = new System.Drawing.Size(240, 464);
            this.textToolTips.TabIndex = 20;
            this.textToolTips.Text = resources.GetString("textToolTips.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "TOOL TIPS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToolTips);
            this.Controls.Add(this.resultRange);
            this.Controls.Add(this.resultAverage);
            this.Controls.Add(this.resultMode);
            this.Controls.Add(this.resultMidExtreme);
            this.Controls.Add(this.inputEdit);
            this.Controls.Add(this.inputSequentialSearch);
            this.Controls.Add(this.inputBinarySearch);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.buttonMidExtreme);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSequentialSearch);
            this.Controls.Add(this.buttonBinarySearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.listBoxDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonBinarySearch;
        private System.Windows.Forms.Button buttonSequentialSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonMidExtreme;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox inputBinarySearch;
        private System.Windows.Forms.TextBox inputSequentialSearch;
        private System.Windows.Forms.TextBox inputEdit;
        private System.Windows.Forms.TextBox resultMidExtreme;
        private System.Windows.Forms.TextBox resultMode;
        private System.Windows.Forms.TextBox resultAverage;
        private System.Windows.Forms.TextBox resultRange;
        private System.Windows.Forms.TextBox textToolTips;
        private System.Windows.Forms.Label label1;
    }
}

