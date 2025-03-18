namespace TI_2;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        label1 = new System.Windows.Forms.Label();
        keyText = new System.Windows.Forms.TextBox();
        chooseActionBox = new System.Windows.Forms.ComboBox();
        plainTextlabel = new System.Windows.Forms.Label();
        paintext = new System.Windows.Forms.TextBox();
        generatedTextBox = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        resultLabel = new System.Windows.Forms.Label();
        resultTextBox = new System.Windows.Forms.TextBox();
        cipherButton = new System.Windows.Forms.Button();
        countLabel = new System.Windows.Forms.Label();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(787, 33);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileMenuItem
        // 
        fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openMenuItem, saveMenuItem });
        fileMenuItem.Name = "fileMenuItem";
        fileMenuItem.Size = new System.Drawing.Size(69, 29);
        fileMenuItem.Text = "Файл";
        // 
        // openMenuItem
        // 
        openMenuItem.Name = "openMenuItem";
        openMenuItem.Size = new System.Drawing.Size(200, 34);
        openMenuItem.Text = "Открыть";
        openMenuItem.Click += openMenuItem_Click;
        // 
        // saveMenuItem
        // 
        saveMenuItem.Name = "saveMenuItem";
        saveMenuItem.Size = new System.Drawing.Size(200, 34);
        saveMenuItem.Text = "Сохранить";
        saveMenuItem.Click += saveMenuItem_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(16, 36);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(389, 36);
        label1.TabIndex = 1;
        label1.Text = "Начальное состояние региста (n состояний):\r\n";
        // 
        // keyText
        // 
        keyText.Location = new System.Drawing.Point(16, 75);
        keyText.Name = "keyText";
        keyText.Size = new System.Drawing.Size(759, 31);
        keyText.TabIndex = 2;
        keyText.KeyPress += textBox1_KeyPress;
        // 
        // chooseActionBox
        // 
        chooseActionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        chooseActionBox.FormattingEnabled = true;
        chooseActionBox.Items.AddRange(new object[] { "Шифрование", "Дешифрирование" });
        chooseActionBox.Location = new System.Drawing.Point(16, 112);
        chooseActionBox.Name = "chooseActionBox";
        chooseActionBox.Size = new System.Drawing.Size(759, 33);
        chooseActionBox.TabIndex = 3;
        chooseActionBox.SelectedIndexChanged += chooseActionBox_SelectedIndexChanged;
        // 
        // plainTextlabel
        // 
        plainTextlabel.Location = new System.Drawing.Point(16, 148);
        plainTextlabel.Name = "plainTextlabel";
        plainTextlabel.Size = new System.Drawing.Size(759, 36);
        plainTextlabel.TabIndex = 4;
        plainTextlabel.Text = "Исходный текст / шифротекст";
        // 
        // paintext
        // 
        paintext.Location = new System.Drawing.Point(16, 178);
        paintext.Multiline = true;
        paintext.Name = "paintext";
        paintext.ReadOnly = true;
        paintext.Size = new System.Drawing.Size(759, 161);
        paintext.TabIndex = 5;
        // 
        // generatedTextBox
        // 
        generatedTextBox.Location = new System.Drawing.Point(16, 390);
        generatedTextBox.Multiline = true;
        generatedTextBox.Name = "generatedTextBox";
        generatedTextBox.ReadOnly = true;
        generatedTextBox.Size = new System.Drawing.Size(377, 279);
        generatedTextBox.TabIndex = 6;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(16, 356);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(215, 31);
        label3.TabIndex = 8;
        label3.Text = "Cгенерированный ключ";
        // 
        // resultLabel
        // 
        resultLabel.Location = new System.Drawing.Point(525, 357);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new System.Drawing.Size(262, 30);
        resultLabel.TabIndex = 9;
        resultLabel.Text = "Шифротекст / исходный текст";
        // 
        // resultTextBox
        // 
        resultTextBox.Location = new System.Drawing.Point(399, 390);
        resultTextBox.Multiline = true;
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ReadOnly = true;
        resultTextBox.Size = new System.Drawing.Size(376, 279);
        resultTextBox.TabIndex = 10;
        // 
        // cipherButton
        // 
        cipherButton.Enabled = false;
        cipherButton.Location = new System.Drawing.Point(250, 345);
        cipherButton.Name = "cipherButton";
        cipherButton.Size = new System.Drawing.Size(269, 42);
        cipherButton.TabIndex = 11;
        cipherButton.Text = "Шифровать/дешифрировать";
        cipherButton.UseVisualStyleBackColor = true;
        cipherButton.Click += cipherButton_Click;
        // 
        // countLabel
        // 
        countLabel.Location = new System.Drawing.Point(690, 36);
        countLabel.Name = "countLabel";
        countLabel.Size = new System.Drawing.Size(85, 28);
        countLabel.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(787, 684);
        Controls.Add(countLabel);
        Controls.Add(cipherButton);
        Controls.Add(resultTextBox);
        Controls.Add(resultLabel);
        Controls.Add(label3);
        Controls.Add(generatedTextBox);
        Controls.Add(paintext);
        Controls.Add(plainTextlabel);
        Controls.Add(chooseActionBox);
        Controls.Add(keyText);
        Controls.Add(label1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "TI_LAB_2";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label countLabel;

    private System.Windows.Forms.Button cipherButton;

    private System.Windows.Forms.TextBox resultTextBox;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label resultLabel;

    private System.Windows.Forms.TextBox generatedTextBox;

    private System.Windows.Forms.Label plainTextlabel;
    private System.Windows.Forms.TextBox paintext;

    private System.Windows.Forms.ComboBox chooseActionBox;

    private System.Windows.Forms.TextBox keyText;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private ToolStripMenuItem fileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
    

    #endregion
}