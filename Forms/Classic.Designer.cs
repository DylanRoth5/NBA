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
        ConfigPanel = new Panel();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
        shipPanel.SuspendLayout();
        ConfigPanel.SuspendLayout();
        SuspendLayout();
        // 
        // btSoloClose
        // 
        btSoloClose.BackColor = Color.FromArgb(200, 0, 0, 0);
        btSoloClose.FlatStyle = FlatStyle.Flat;
        btSoloClose.ForeColor = Color.CornflowerBlue;
        btSoloClose.Location = new Point(12, 11);
        btSoloClose.Margin = new Padding(3, 2, 3, 2);
        btSoloClose.Name = "btSoloClose";
        btSoloClose.Size = new Size(82, 22);
        btSoloClose.TabIndex = 0;
        btSoloClose.Text = "CERRAR";
        btSoloClose.UseVisualStyleBackColor = false;
        btSoloClose.Click += btSoloClose_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.CornflowerBlue;
        label1.Location = new Point(3, 16);
        label1.Name = "label1";
        label1.Size = new Size(54, 15);
        label1.TabIndex = 1;
        label1.Text = "Map Size";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.CornflowerBlue;
        label2.Location = new Point(3, 45);
        label2.Name = "label2";
        label2.Size = new Size(62, 15);
        label2.TabIndex = 2;
        label2.Text = "Small Ship";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.CornflowerBlue;
        label3.Location = new Point(3, 76);
        label3.Name = "label3";
        label3.Size = new Size(73, 15);
        label3.TabIndex = 3;
        label3.Text = "Normal Ship";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.CornflowerBlue;
        label4.Location = new Point(3, 105);
        label4.Name = "label4";
        label4.Size = new Size(50, 15);
        label4.TabIndex = 4;
        label4.Text = "Big Ship";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = Color.CornflowerBlue;
        label5.Location = new Point(3, 134);
        label5.Name = "label5";
        label5.Size = new Size(67, 15);
        label5.TabIndex = 5;
        label5.Text = "Bigger Ship";
        // 
        // numericUpDown1
        // 
        numericUpDown1.BackColor = Color.Black;
        numericUpDown1.BorderStyle = BorderStyle.None;
        numericUpDown1.ForeColor = Color.CornflowerBlue;
        numericUpDown1.Location = new Point(74, 14);
        numericUpDown1.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(40, 19);
        numericUpDown1.TabIndex = 6;
        numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // numericUpDown2
        // 
        numericUpDown2.BackColor = Color.Black;
        numericUpDown2.BorderStyle = BorderStyle.None;
        numericUpDown2.ForeColor = Color.CornflowerBlue;
        numericUpDown2.Location = new Point(74, 43);
        numericUpDown2.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(40, 19);
        numericUpDown2.TabIndex = 7;
        numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown3
        // 
        numericUpDown3.BackColor = Color.Black;
        numericUpDown3.BorderStyle = BorderStyle.None;
        numericUpDown3.ForeColor = Color.CornflowerBlue;
        numericUpDown3.Location = new Point(74, 74);
        numericUpDown3.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new Size(40, 19);
        numericUpDown3.TabIndex = 8;
        numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown4
        // 
        numericUpDown4.BackColor = Color.Black;
        numericUpDown4.BorderStyle = BorderStyle.None;
        numericUpDown4.ForeColor = Color.CornflowerBlue;
        numericUpDown4.Location = new Point(74, 103);
        numericUpDown4.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown4.Name = "numericUpDown4";
        numericUpDown4.Size = new Size(40, 19);
        numericUpDown4.TabIndex = 9;
        numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numericUpDown5
        // 
        numericUpDown5.BackColor = Color.Black;
        numericUpDown5.BorderStyle = BorderStyle.None;
        numericUpDown5.ForeColor = Color.CornflowerBlue;
        numericUpDown5.Location = new Point(74, 132);
        numericUpDown5.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        numericUpDown5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown5.Name = "numericUpDown5";
        numericUpDown5.Size = new Size(40, 19);
        numericUpDown5.TabIndex = 10;
        numericUpDown5.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // button1
        // 
        button1.FlatStyle = FlatStyle.Flat;
        button1.ForeColor = Color.CornflowerBlue;
        button1.Location = new Point(9, 161);
        button1.Name = "button1";
        button1.Size = new Size(105, 30);
        button1.TabIndex = 11;
        button1.Text = "Start";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // ePanel
        // 
        ePanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        ePanel.Location = new Point(142, 11);
        ePanel.Name = "ePanel";
        ePanel.Size = new Size(515, 518);
        ePanel.TabIndex = 12;
        ePanel.Visible = false;
        ePanel.Paint += gmPanel_Paint;
        // 
        // pPanel
        // 
        pPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        pPanel.Location = new Point(663, 11);
        pPanel.Name = "pPanel";
        pPanel.Size = new Size(509, 518);
        pPanel.TabIndex = 13;
        pPanel.Visible = false;
        // 
        // shipPanel
        // 
        shipPanel.BackColor = Color.FromArgb(200, 0, 0, 0);
        shipPanel.Controls.Add(button7);
        shipPanel.Controls.Add(label6);
        shipPanel.Controls.Add(button6);
        shipPanel.Controls.Add(button5);
        shipPanel.Controls.Add(button4);
        shipPanel.Controls.Add(button3);
        shipPanel.Controls.Add(button2);
        shipPanel.Location = new Point(12, 246);
        shipPanel.Name = "shipPanel";
        shipPanel.Size = new Size(124, 257);
        shipPanel.TabIndex = 15;
        shipPanel.Visible = false;
        // 
        // button7
        // 
        button7.Enabled = false;
        button7.FlatStyle = FlatStyle.Flat;
        button7.ForeColor = Color.CornflowerBlue;
        button7.Location = new Point(9, 216);
        button7.Name = "button7";
        button7.Size = new Size(105, 29);
        button7.TabIndex = 6;
        button7.Text = "Ready";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label6.ForeColor = Color.CornflowerBlue;
        label6.Location = new Point(14, 7);
        label6.Name = "label6";
        label6.Size = new Size(74, 21);
        label6.TabIndex = 5;
        label6.Text = "Set Ships";
        // 
        // button6
        // 
        button6.FlatStyle = FlatStyle.Flat;
        button6.ForeColor = Color.CornflowerBlue;
        button6.Location = new Point(9, 31);
        button6.Name = "button6";
        button6.Size = new Size(105, 31);
        button6.TabIndex = 4;
        button6.Text = "Horizontal";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button5
        // 
        button5.FlatStyle = FlatStyle.Flat;
        button5.ForeColor = Color.CornflowerBlue;
        button5.Location = new Point(9, 179);
        button5.Name = "button5";
        button5.Size = new Size(105, 31);
        button5.TabIndex = 3;
        button5.Text = "BiggerShip";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button4
        // 
        button4.FlatStyle = FlatStyle.Flat;
        button4.ForeColor = Color.CornflowerBlue;
        button4.Location = new Point(9, 142);
        button4.Name = "button4";
        button4.Size = new Size(105, 31);
        button4.TabIndex = 2;
        button4.Text = "BigShip";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button3
        // 
        button3.FlatStyle = FlatStyle.Flat;
        button3.ForeColor = Color.CornflowerBlue;
        button3.Location = new Point(9, 105);
        button3.Name = "button3";
        button3.Size = new Size(105, 31);
        button3.TabIndex = 1;
        button3.Text = "NormalShip";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.FlatStyle = FlatStyle.Flat;
        button2.ForeColor = Color.CornflowerBlue;
        button2.Location = new Point(9, 68);
        button2.Name = "button2";
        button2.Size = new Size(105, 31);
        button2.TabIndex = 0;
        button2.Text = "SmallShip";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.BackColor = Color.FromArgb(150, 0, 0, 0);
        label7.Font = new Font("OCR A Extended", 100F, FontStyle.Regular, GraphicsUnit.Point);
        label7.ForeColor = Color.CornflowerBlue;
        label7.Location = new Point(350, 200);
        label7.Name = "label7";
        label7.Size = new Size(545, 139);
        label7.TabIndex = 16;
        label7.Text = "label7";
        label7.Visible = false;
        // 
        // ConfigPanel
        // 
        ConfigPanel.BackColor = Color.FromArgb(200, 0, 0, 0);
        ConfigPanel.Controls.Add(button1);
        ConfigPanel.Controls.Add(label5);
        ConfigPanel.Controls.Add(numericUpDown5);
        ConfigPanel.Controls.Add(label4);
        ConfigPanel.Controls.Add(numericUpDown4);
        ConfigPanel.Controls.Add(label1);
        ConfigPanel.Controls.Add(numericUpDown1);
        ConfigPanel.Controls.Add(numericUpDown2);
        ConfigPanel.Controls.Add(label2);
        ConfigPanel.Controls.Add(numericUpDown3);
        ConfigPanel.Controls.Add(label3);
        ConfigPanel.Location = new Point(12, 38);
        ConfigPanel.Name = "ConfigPanel";
        ConfigPanel.Size = new Size(124, 202);
        ConfigPanel.TabIndex = 17;
        // 
        // Classic
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.Fondo2;
        ClientSize = new Size(1175, 540);
        Controls.Add(ConfigPanel);
        Controls.Add(label7);
        Controls.Add(shipPanel);
        Controls.Add(pPanel);
        Controls.Add(ePanel);
        Controls.Add(btSoloClose);
        Margin = new Padding(3, 2, 3, 2);
        MaximumSize = new Size(1191, 579);
        MinimumSize = new Size(1191, 579);
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
        ConfigPanel.ResumeLayout(false);
        ConfigPanel.PerformLayout();
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
    private Panel ConfigPanel;
}