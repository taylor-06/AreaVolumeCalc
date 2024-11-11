﻿namespace AreaVolumeCalc
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
            shape2DSelector = new ComboBox();
            shape2D = new Label();
            shape3D = new Label();
            shape3DSelector = new ComboBox();
            areaResult = new Label();
            volumeResult = new Label();
            areaWidthText = new TextBox();
            areaHeightText = new TextBox();
            volumeWidthText = new TextBox();
            volumeHeightText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radiusDepthText = new TextBox();
            btn_CalcArea = new Button();
            btn_CalcVolume = new Button();
            SuspendLayout();
            // 
            // shape2DSelector
            // 
            shape2DSelector.FormattingEnabled = true;
            shape2DSelector.Items.AddRange(new object[] { "Rectangle", "Ellipse", "Triangle" });
            shape2DSelector.Location = new Point(69, 73);
            shape2DSelector.Name = "shape2DSelector";
            shape2DSelector.Size = new Size(121, 23);
            shape2DSelector.TabIndex = 3;
            shape2DSelector.Text = "Rectangle";
            // 
            // shape2D
            // 
            shape2D.AutoSize = true;
            shape2D.Location = new Point(69, 43);
            shape2D.Name = "shape2D";
            shape2D.Size = new Size(61, 15);
            shape2D.TabIndex = 4;
            shape2D.Text = "2D Shapes";
            // 
            // shape3D
            // 
            shape3D.AutoSize = true;
            shape3D.Location = new Point(336, 43);
            shape3D.Name = "shape3D";
            shape3D.Size = new Size(61, 15);
            shape3D.TabIndex = 5;
            shape3D.Text = "3D Shapes";
            // 
            // shape3DSelector
            // 
            shape3DSelector.FormattingEnabled = true;
            shape3DSelector.Items.AddRange(new object[] { "Cube", "Sphere", "Cylinder" });
            shape3DSelector.Location = new Point(336, 73);
            shape3DSelector.Name = "shape3DSelector";
            shape3DSelector.Size = new Size(121, 23);
            shape3DSelector.TabIndex = 6;
            shape3DSelector.Text = "Cube";
            // 
            // areaResult
            // 
            areaResult.AutoSize = true;
            areaResult.Location = new Point(89, 336);
            areaResult.Name = "areaResult";
            areaResult.Size = new Size(51, 15);
            areaResult.TabIndex = 7;
            areaResult.Text = "Area = 0";
            // 
            // volumeResult
            // 
            volumeResult.AutoSize = true;
            volumeResult.Location = new Point(350, 336);
            volumeResult.Name = "volumeResult";
            volumeResult.Size = new Size(67, 15);
            volumeResult.TabIndex = 8;
            volumeResult.Text = "Volume = 0";
            // 
            // areaWidthText
            // 
            areaWidthText.Location = new Point(69, 148);
            areaWidthText.Name = "areaWidthText";
            areaWidthText.Size = new Size(100, 23);
            areaWidthText.TabIndex = 9;
            areaWidthText.Text = "1";
            // 
            // areaHeightText
            // 
            areaHeightText.Location = new Point(69, 211);
            areaHeightText.Name = "areaHeightText";
            areaHeightText.Size = new Size(100, 23);
            areaHeightText.TabIndex = 10;
            areaHeightText.Text = "1";
            // 
            // volumeWidthText
            // 
            volumeWidthText.Location = new Point(336, 148);
            volumeWidthText.Name = "volumeWidthText";
            volumeWidthText.Size = new Size(100, 23);
            volumeWidthText.TabIndex = 11;
            // 
            // volumeHeightText
            // 
            volumeHeightText.Location = new Point(336, 211);
            volumeHeightText.Name = "volumeHeightText";
            volumeHeightText.Size = new Size(100, 23);
            volumeHeightText.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 130);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 193);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "Height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 130);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 193);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 16;
            label5.Text = "Height";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 130);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 17;
            label6.Text = "Radius / Depth";
            // 
            // radiusDepthText
            // 
            radiusDepthText.Location = new Point(479, 148);
            radiusDepthText.Name = "radiusDepthText";
            radiusDepthText.Size = new Size(100, 23);
            radiusDepthText.TabIndex = 18;
            // 
            // btn_CalcArea
            // 
            btn_CalcArea.Location = new Point(69, 274);
            btn_CalcArea.Name = "btn_CalcArea";
            btn_CalcArea.Size = new Size(100, 38);
            btn_CalcArea.TabIndex = 19;
            btn_CalcArea.Text = "Calculate Area";
            btn_CalcArea.UseVisualStyleBackColor = true;
            btn_CalcArea.Click += btn_CalcArea_Click;
            // 
            // btn_CalcVolume
            // 
            btn_CalcVolume.Location = new Point(336, 274);
            btn_CalcVolume.Name = "btn_CalcVolume";
            btn_CalcVolume.Size = new Size(100, 38);
            btn_CalcVolume.TabIndex = 20;
            btn_CalcVolume.Text = "Calculate Volume";
            btn_CalcVolume.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_CalcVolume);
            Controls.Add(btn_CalcArea);
            Controls.Add(radiusDepthText);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(volumeHeightText);
            Controls.Add(volumeWidthText);
            Controls.Add(areaHeightText);
            Controls.Add(areaWidthText);
            Controls.Add(volumeResult);
            Controls.Add(areaResult);
            Controls.Add(shape3DSelector);
            Controls.Add(shape3D);
            Controls.Add(shape2D);
            Controls.Add(shape2DSelector);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox shape2DSelector;
        private Label shape2D;
        private Label shape3D;
        private ComboBox shape3DSelector;
        private Label areaResult;
        private Label volumeResult;
        private TextBox areaWidthText;
        private TextBox areaHeightText;
        private TextBox volumeWidthText;
        private TextBox volumeHeightText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox radiusDepthText;
        private Button btn_CalcArea;
        private Button btn_CalcVolume;
    }
}