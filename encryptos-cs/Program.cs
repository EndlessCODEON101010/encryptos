using System.Collections;
using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace encryptos_cs;

class Program
{
    static void Main(string[] args)
    {

        Demo();

    }

    static void Demo() {
        int key   = 0b1001; // 9
        int stuff = 0b1010; // 10
        //            0011 -> 3 = xorCipher
        //        xor 1001
        //        --------
        //            1010 -> 10 = stuff
        int xorCipher = stuff ^ key;

        Console.WriteLine(xorCipher);       // 3
        Console.WriteLine(xorCipher ^ key); // 10

        // ----------
        // az xor operáció működik-e byte array-en

        //BitArray[] text =  Encoding.UTF8.GetBytes("I love milk!");
        //BitArray[] textKey = Encoding.UTF8.GetBytes("I HATE MILK!");


    }
}