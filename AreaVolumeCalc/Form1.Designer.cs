namespace AreaVolumeCalc
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
            this.shape2DSelector = new System.Windows.Forms.ComboBox();
            this.shape2D = new System.Windows.Forms.Label();
            this.shape3D = new System.Windows.Forms.Label();
            this.shape3DSelector = new System.Windows.Forms.ComboBox();
            this.areaResult = new System.Windows.Forms.Label();
            this.volumeResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CalcArea = new System.Windows.Forms.Button();
            this.btn_CalcVolume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.NumericUpDown();
            this.radiusText = new System.Windows.Forms.NumericUpDown();
            this.depthText = new System.Windows.Forms.NumericUpDown();
            this.heightText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightText)).BeginInit();
            this.SuspendLayout();
            // 
            // shape2DSelector
            // 
            this.shape2DSelector.FormattingEnabled = true;
            this.shape2DSelector.Items.AddRange(new object[] {
            "Rectangle",
            "Ellipse",
            "Triangle"});
            this.shape2DSelector.Location = new System.Drawing.Point(69, 73);
            this.shape2DSelector.Name = "shape2DSelector";
            this.shape2DSelector.Size = new System.Drawing.Size(121, 23);
            this.shape2DSelector.TabIndex = 3;
            this.shape2DSelector.Text = "Rectangle";
            // 
            // shape2D
            // 
            this.shape2D.AutoSize = true;
            this.shape2D.Location = new System.Drawing.Point(69, 43);
            this.shape2D.Name = "shape2D";
            this.shape2D.Size = new System.Drawing.Size(61, 15);
            this.shape2D.TabIndex = 4;
            this.shape2D.Text = "2D Shapes";
            // 
            // shape3D
            // 
            this.shape3D.AutoSize = true;
            this.shape3D.Location = new System.Drawing.Point(264, 43);
            this.shape3D.Name = "shape3D";
            this.shape3D.Size = new System.Drawing.Size(61, 15);
            this.shape3D.TabIndex = 5;
            this.shape3D.Text = "3D Shapes";
            // 
            // shape3DSelector
            // 
            this.shape3DSelector.FormattingEnabled = true;
            this.shape3DSelector.Items.AddRange(new object[] {
            "Cube",
            "Sphere",
            "Cylinder"});
            this.shape3DSelector.Location = new System.Drawing.Point(264, 73);
            this.shape3DSelector.Name = "shape3DSelector";
            this.shape3DSelector.Size = new System.Drawing.Size(121, 23);
            this.shape3DSelector.TabIndex = 6;
            this.shape3DSelector.Text = "Cube";
            // 
            // areaResult
            // 
            this.areaResult.AutoSize = true;
            this.areaResult.Location = new System.Drawing.Point(89, 355);
            this.areaResult.Name = "areaResult";
            this.areaResult.Size = new System.Drawing.Size(51, 15);
            this.areaResult.TabIndex = 7;
            this.areaResult.Text = "Area = 0";
            // 
            // volumeResult
            // 
            this.volumeResult.AutoSize = true;
            this.volumeResult.Location = new System.Drawing.Point(278, 355);
            this.volumeResult.Name = "volumeResult";
            this.volumeResult.Size = new System.Drawing.Size(67, 15);
            this.volumeResult.TabIndex = 8;
            this.volumeResult.Text = "Volume = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Depth";
            // 
            // btn_CalcArea
            // 
            this.btn_CalcArea.Location = new System.Drawing.Point(69, 293);
            this.btn_CalcArea.Name = "btn_CalcArea";
            this.btn_CalcArea.Size = new System.Drawing.Size(100, 38);
            this.btn_CalcArea.TabIndex = 19;
            this.btn_CalcArea.Text = "Calculate Area";
            this.btn_CalcArea.UseVisualStyleBackColor = true;
            this.btn_CalcArea.Click += new System.EventHandler(this.btn_CalcArea_Click);
            // 
            // btn_CalcVolume
            // 
            this.btn_CalcVolume.Location = new System.Drawing.Point(264, 293);
            this.btn_CalcVolume.Name = "btn_CalcVolume";
            this.btn_CalcVolume.Size = new System.Drawing.Size(100, 38);
            this.btn_CalcVolume.TabIndex = 20;
            this.btn_CalcVolume.Text = "Calculate Volume";
            this.btn_CalcVolume.UseVisualStyleBackColor = true;
            this.btn_CalcVolume.Click += new System.EventHandler(this.btn_CalcVolume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Radius";
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(69, 149);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(120, 23);
            this.widthText.TabIndex = 23;
            // 
            // radiusText
            // 
            this.radiusText.Location = new System.Drawing.Point(264, 149);
            this.radiusText.Name = "radiusText";
            this.radiusText.Size = new System.Drawing.Size(120, 23);
            this.radiusText.TabIndex = 24;
            // 
            // depthText
            // 
            this.depthText.Location = new System.Drawing.Point(264, 214);
            this.depthText.Name = "depthText";
            this.depthText.Size = new System.Drawing.Size(120, 23);
            this.depthText.TabIndex = 25;
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(69, 214);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(120, 23);
            this.heightText.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 435);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.depthText);
            this.Controls.Add(this.radiusText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CalcVolume);
            this.Controls.Add(this.btn_CalcArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volumeResult);
            this.Controls.Add(this.areaResult);
            this.Controls.Add(this.shape3DSelector);
            this.Controls.Add(this.shape3D);
            this.Controls.Add(this.shape2D);
            this.Controls.Add(this.shape2DSelector);
            this.MaximumSize = new System.Drawing.Size(454, 474);
            this.MinimumSize = new System.Drawing.Size(454, 474);
            this.Name = "Form1";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.widthText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox shape2DSelector;
        private Label shape2D;
        private Label shape3D;
        private ComboBox shape3DSelector;
        private Label areaResult;
        private Label volumeResult;
        private Label label2;
        private Label label3;
        private Label label6;
        private Button btn_CalcArea;
        private Button btn_CalcVolume;
        private Label label1;
        private NumericUpDown widthText;
        private NumericUpDown radiusText;
        private NumericUpDown depthText;
        private NumericUpDown heightText;
    }
}