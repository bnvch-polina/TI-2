using System.Collections;
using System.Text;

namespace TI_2;

public partial class Form1 : Form
{
    private const int maxPower = 23;
    private bool wasFileOpen = false;
    public Form1()
    {
        InitializeComponent();
    }
    string BitArrayToStr(BitArray array)
    {
        StringBuilder temp = new();
        if (array.Length <= 240)
        {
            foreach (bool bit in array)
            {
                temp.Append(bit ? 1 : 0);
            }       
        }
        else
        {
            temp.Append("Первые 15 байт: ");
            for (int i = 0; i < 120; i++)
                temp.Append(array[i] ? 1 : 0);
            temp.Append($"{Environment.NewLine}Последние 15 байт: ");
            for (int i = 120; i > 0; i--)
            {
                temp.Append(array[array.Length - i] ? 1 : 0);
            }
        }

        return temp.ToString();
    }
    
    private void openMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog OpenFileDialog = new OpenFileDialog();
        if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var bytes = File.ReadAllBytes(OpenFileDialog.FileName);
            for (int i = 0; i < bytes.Length; i++)
            {
                BitArray help = new BitArray(new[] {bytes[i]});
                foreach (bool bit in help)
                {
                    stringBuilder.Append(bit ? 1 : 0);
                }
            }
        
            Cipher.PlainText = new BitArray(stringBuilder.Length);
            for (int i = 0; i < Cipher.PlainText.Length; i++)
            {
                Cipher.PlainText[i] = stringBuilder[i] == '1';
            }
            paintext.Text = BitArrayToStr(Cipher.PlainText);
            wasFileOpen = true;
        }
    }
    
    
    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        List<bool> bits = new List<bool>();
        foreach (char c in keyText.Text)
        {
            if (c == '0')
            {
                bits.Add(false);
            }
            else if (c == '1')
            {
                bits.Add(true);
            }
        }
        if (e.KeyChar == '0')
        {
            bits.Add(false);
        }
        else if (e.KeyChar == '1')
        {
            bits.Add(true);
        }
        Cipher.BitRegister = new BitArray(bits.ToArray());
        if (Cipher.BitRegister.Length != 0 && chooseActionBox.SelectedIndex != -1) // шифр и дешифр 
        {
            cipherButton.Enabled = true;
        }
        else
        {
            cipherButton.Enabled = false;
        }
        countLabel.Text = Cipher.BitRegister.Length.ToString();
    }

    void cipherButton_Click(object sender, EventArgs e)
    {
        List<bool> bits = new List<bool>();
        foreach (char c in keyText.Text)
        {
            if (c == '0')
            {
                bits.Add(false);
            }
            else if (c == '1')
            {
                bits.Add(true);
            }
        }
        Cipher.BitRegister = new BitArray(bits.ToArray());
        countLabel.Text = Cipher.BitRegister.Length.ToString();
        if (Cipher.BitRegister.Length > maxPower)
        {
            BitArray trimmedRegister = new BitArray(23);
            for (int i = 0; i < 23; i++)
            {
                trimmedRegister[i] = Cipher.BitRegister[i];
            }
            Cipher.BitRegister = trimmedRegister;
        }
        else if (Cipher.BitRegister.Length < maxPower)
        {
            BitArray resizedRegister = new BitArray(23);
            for (int i = 0; i < 23; i++)
            {
                resizedRegister[i] = false;
            }
            for (int i = 0; i < Cipher.BitRegister.Length; i++)
            {
                resizedRegister[i] = Cipher.BitRegister[i];
            }
            Cipher.BitRegister = resizedRegister;
        }
        if (wasFileOpen)
        {
            Cipher.ProduceBitKey(Cipher.PlainText.Length);
            generatedTextBox.Text = BitArrayToStr(Cipher.BitKey);
            Cipher.CipherProc();
            resultTextBox.Text = BitArrayToStr(Cipher.CipherBit);
        }
        else
        {
            MessageBox.Show("Выберите файл с вашим исходным текстом для шифрования/дешифрования!", "Внимание");
        }
    }

    private void saveMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog SaveFileDialog = new OpenFileDialog();
        if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            using FileStream fileStream = new FileStream(SaveFileDialog.FileName, FileMode.Create);
            byte[] result = new byte[Cipher.CipherBit.Count / 8];
            Cipher.CipherBit.CopyTo(result, 0);
            fileStream.Write(result, 0, result.Length);
        }
    }

    private void chooseActionBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Cipher.BitRegister != null && chooseActionBox.SelectedIndex != -1)
        {
            cipherButton.Enabled = true;
        }
        else
        {
            cipherButton.Enabled = false;
        }

        if (chooseActionBox.SelectedItem == "Шифрование")
        {
            plainTextlabel.Text = "Исходный текст";
            cipherButton.Text = "Шифровать";
            resultLabel.Text = "Шифротекст";
        }
        else
        {
            plainTextlabel.Text = "Шифротекст";
            cipherButton.Text = "Дешифрировать";
            resultLabel.Text = "Исходный текст";
        }
            
    }
}