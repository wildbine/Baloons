namespace Baloons;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearAll = new System.Windows.Forms.Button();
            this.diffSpeed = new System.Windows.Forms.RadioButton();
            this.constSpeed = new System.Windows.Forms.RadioButton();
            this.ballsCount = new System.Windows.Forms.Label();
            this.labelBallsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 560);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.clearAll);
            this.panel2.Controls.Add(this.diffSpeed);
            this.panel2.Controls.Add(this.constSpeed);
            this.panel2.Controls.Add(this.ballsCount);
            this.panel2.Controls.Add(this.labelBallsCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 39);
            this.panel2.TabIndex = 0;
            // 
            // clearAll
            // 
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.ForeColor = System.Drawing.Color.Black;
            this.clearAll.Location = new System.Drawing.Point(797, 3);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(94, 29);
            this.clearAll.TabIndex = 1;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // diffSpeed
            // 
            this.diffSpeed.AutoSize = true;
            this.diffSpeed.Location = new System.Drawing.Point(526, 5);
            this.diffSpeed.Name = "diffSpeed";
            this.diffSpeed.Size = new System.Drawing.Size(135, 24);
            this.diffSpeed.TabIndex = 5;
            this.diffSpeed.TabStop = true;
            this.diffSpeed.Text = "Different Speed";
            this.diffSpeed.UseVisualStyleBackColor = true;
            this.diffSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.diffSpeed_MouseClick);
            // 
            // constSpeed
            // 
            this.constSpeed.AutoSize = true;
            this.constSpeed.Checked = true;
            this.constSpeed.Location = new System.Drawing.Point(341, 5);
            this.constSpeed.Name = "constSpeed";
            this.constSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.constSpeed.Size = new System.Drawing.Size(134, 24);
            this.constSpeed.TabIndex = 0;
            this.constSpeed.TabStop = true;
            this.constSpeed.Text = "Constant Speed";
            this.constSpeed.UseMnemonic = false;
            this.constSpeed.UseVisualStyleBackColor = false;
            this.constSpeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.constSpeed_MouseClick);
            // 
            // ballsCount
            // 
            this.ballsCount.AutoSize = true;
            this.ballsCount.Location = new System.Drawing.Point(181, 7);
            this.ballsCount.Name = "ballsCount";
            this.ballsCount.Size = new System.Drawing.Size(17, 20);
            this.ballsCount.TabIndex = 4;
            this.ballsCount.Text = "0";
            // 
            // labelBallsCount
            // 
            this.labelBallsCount.AutoSize = true;
            this.labelBallsCount.Location = new System.Drawing.Point(204, 7);
            this.labelBallsCount.Name = "labelBallsCount";
            this.labelBallsCount.Size = new System.Drawing.Size(83, 20);
            this.labelBallsCount.TabIndex = 3;
            this.labelBallsCount.Text = "Balls Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 27);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(379, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label labelBallsCount;
    private Label label1;
    private NumericUpDown numericUpDown1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Label ballsCount;
    private RadioButton constSpeed;
    private RadioButton diffSpeed;
    private Button clearAll;
}
