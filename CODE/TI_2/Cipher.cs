using System.Collections;

namespace TI_2;

public class Cipher
{
    public static BitArray PlainText { get; set; }
    public static BitArray BitRegister { get; set; }
    public static BitArray BitKey { get; private set; }
    public static BitArray CipherBit { get; private set; }
    public static void ProduceBitKey(int length)
    {
        // x^23 + x^5 + 1
        BitKey = new(length);
        for (int i = 0; i < length; i++)
        {
            BitKey[i] = BitRegister[0];
            int len = BitRegister.Length;
            bool nextValue = BitRegister[len - 23] ^ BitRegister[len - 5];
            for (int index = 0; index < BitRegister.Length - 1; index++)
            {
                BitRegister[index] = BitRegister[index + 1];
            }
            BitRegister[BitRegister.Length - 1] = nextValue;
        }
    }
    public static void CipherProc() => CipherBit = BitKey.Xor(PlainText);
    
}