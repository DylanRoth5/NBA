namespace NBA.Forms;

partial class Classic
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
        btSoloClose = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        numericUpDown1 = new NumericUpDown();
        numericUpDown2 = new NumericUpDown();
        numericUpDown3 = new NumericUpDown();
        numericUpDown4 = new NumericUpDown();
        numericUpDown5 = new NumericUpDown();
        button1 = new Button();
        ePanel = new Panel();
        pPanel = new Panel();
        shipPanel = new Panel();
        button7 = new Button();
        label6 = new Label();
        button6 = new Button();
        button5 = new Button();
        button4 = new Button();
        button3 = new Button();
        button2 = new Button();
        label7 = new Label();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
        shipPanel.SuspendLayout();
        SuspendLayout();
        // 
        // btSoloClose
        // 
        btSoloClose.Location = new Point(12, 11);
        btSoloClose.Margin = new Padding(3, 2, 3, 2);
        btSoloClose.Name = "btSoloClose";
        btSoloClose.Size = new Size(82, 22);
        btSoloClose.TabIndex = 0;
        btSoloClose.Text = "CERRAR";
        btSoloClose.UseVisualStyleBackColor = true;
        btSoloClose.Click += btSoloClose_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(13, 47);
        label1.Name = "label1";
        label1.Size = new Size(54, 15);
        label1.TabIndex = 1;
        label1.Text = "Map Size";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 76);
        label2.Name = "label2";
        label2.Size = new Size(62, 15);
        label2.TabIndex = 2;
        label2.Text = "Small Ship";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 104);
        label3.Name = "label3";
        label3.Size = new Size(73, 15);
        label3.TabIndex = 3;
        label3.Text = "Normal Ship";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 133);
        label4.Name = "label4";
        label4.Size = new Size(50, 15);
        label4.TabIndex = 4;
        label4.Text = "Big Ship";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(13, 162);
        label5.Name = "label5";
        label5.Size = new Size(67, 15);
        label5.TabIndex = 5;
        label5.Text = "Bigger Ship";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(96, 45);
        numericUpDown1.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(40, 23);
        numericUpDown1.TabIndex = 6;
        numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new Point(96, 74);
        numericUpDown2.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(40, 23);
        numericUpDown2.TabIndex = 7;
        numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown3
        // 
        numericUpDown3.Location = new Point(96, 102);
        numericUpDown3.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new Size(40, 23);
        numericUpDown3.TabIndex = 8;
        numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown4
        // 
        numericUpDown4.Location = new Point(96, 131);
        numericUpDown4.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown4.Name = "numericUpDown4";
        numericUpDown4.Size = new Size(40, 23);
        numericUpDown4.TabIndex = 9;
        numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown5
        // 
        numericUpDown5.Location = new Point(96, 160);
        numericUpDown5.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown5.Name = "numericUpDown5";
        numericUpDown5.Size = new Size(40, 23);
        numericUpDown5.TabIndex = 10;
        numericUpDown5.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // button1
        // 
        button1.Location = new Point(12, 189);
        button1.Name = "button1";
        button1.Size = new Size(124, 30);
        button1.TabIndex = 11;
        button1.Text = "Start";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // ePanel
        // 
        ePanel.BackColor = Color.LightSteelBlue;
        ePanel.Location = new Point(142, 11);
        ePanel.Name = "ePanel";
        ePanel.Size = new Size(515, 518);
        ePanel.TabIndex = 12;
        ePanel.Visible = false;
        ePanel.Paint += gmPanel_Paint;
        // 
        // pPanel
        // 
        pPanel.BackColor = Color.LightSteelBlue;
        pPanel.Location = new Point(663, 11);
        pPanel.Name = "pPanel";
        pPanel.Size = new Size(509, 518);
        pPanel.TabIndex = 13;
        pPanel.Visible = false;
        // 
        // shipPanel
        // 
        shipPanel.BackColor = SystemColors.ActiveCaption;
        shipPanel.Controls.Add(button7);
        shipPanel.Controls.Add(label6);
        shipPanel.Controls.Add(button6);
        shipPanel.Controls.Add(button5);
        shipPanel.Controls.Add(button4);
        shipPanel.Controls.Add(button3);
        shipPanel.Controls.Add(button2);
        shipPanel.Location = new Point(13, 229);
        shipPanel.Name = "shipPanel";
        shipPanel.Size = new Size(117, 216);
        shipPanel.TabIndex = 15;
        shipPanel.Visible = false;
        // 
        // button7
        // 
        button7.Enabled = false;
        button7.Location = new Point(14, 181);
        button7.Name = "button7";
        button7.Size = new Size(85, 24);
        button7.TabIndex = 6;
        button7.Text = "Ready";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(14, 7);
        label6.Name = "label6";
        label6.Size = new Size(74, 21);
        label6.TabIndex = 5;
        label6.Text = "Set Ships";
        // 
        // button6
        // 
        button6.Location = new Point(14, 31);
        button6.Name = "button6";
        button6.Size = new Size(85, 24);
        button6.TabIndex = 4;
        button6.Text = "Horizontal";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button5
        // 
        button5.Location = new Point(14, 151);
        button5.Name = "button5";
        button5.Size = new Size(85, 24);
        button5.TabIndex = 3;
        button5.Text = "BiggerShip";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button4
        // 
        button4.Location = new Point(14, 121);
        button4.Name = "button4";
        button4.Size = new Size(85, 24);
        button4.TabIndex = 2;
        button4.Text = "BigShip";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button3
        // 
        button3.Location = new Point(14, 91);
        button3.Name = "button3";
        button3.Size = new Size(85, 24);
        button3.TabIndex = 1;
        button3.Text = "NormalShip";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.Location = new Point(14, 61);
        button2.Name = "button2";
        button2.Size = new Size(85, 24);
        button2.TabIndex = 0;
        button2.Text = "SmallShip";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("OCR A Extended", 60F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(500, 208);
        label7.Name = "label7";
        label7.Size = new Size(323, 83);
        label7.TabIndex = 16;
        label7.Text = "label7";
        label7.Visible = false;
        // 
        // Classic
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1175, 540);
        Controls.Add(label7);
        Controls.Add(shipPanel);
        Controls.Add(pPanel);
        Controls.Add(ePanel);
        Controls.Add(button1);
        Controls.Add(numericUpDown5);
        Controls.Add(numericUpDown4);
        Controls.Add(numericUpDown3);
        Controls.Add(numericUpDown2);
        Controls.Add(numericUpDown1);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btSoloClose);
        Margin = new Padding(3, 2, 3, 2);
        Name = "Classic";
        Text = "Classic";
        FormClosing += gSolo_FormClosing;
        FormClosed += gSolo_FormClosed;
        Load += gSolo_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
        shipPanel.ResumeLayout(false);
        shipPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btSoloClose;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown3;
    private NumericUpDown numericUpDown4;
    private NumericUpDown numericUpDown5;
    private Button button1;
    private Panel ePanel;
    private Panel pPanel;
    private Panel shipPanel;
    private Button button6;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button2;
    private Label label6;
    private Button button7;
    private Label label7;
}