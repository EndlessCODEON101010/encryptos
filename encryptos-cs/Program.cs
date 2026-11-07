using System.Collections;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;

namespace encryptos_cs;

class Program
{
    static void Main(string[] args)
    {
        // C#-os bit szintű műveletekkel való ismerkedés:

        // char example = 'b';
        // var bitrified = Convert.ToByte(example);

        // Console.WriteLine(bitrified);
        // Console.WriteLine(bitrified.GetType());
        // Console.WriteLine(bitrified.ToString().GetType());
        // Console.WriteLine(bitrified.ToString());
        // Console.WriteLine(bitrified.GetHashCode());

        // // microsoft.learn code snippet

        // uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
        // uint b = ~a;
        // Console.WriteLine(Convert.ToString(b, toBase: 2));
        // // Output:
        // // 11110000111100001111000011110011

        // uint c = 0b_0011;
        // Console.WriteLine($"value of variable c is {c}");

        // bitwise operators: & = and; | = or; ^ = XOR; << = LEFT shift; >> = RIGHT shift;

        // uint key = 478;
        // uint data = 89;
        // uint cipher = key ^ data;
        // Console.WriteLine(cipher);
        // Console.WriteLine(cipher ^ key); // theoretically it should give back the value of 89 as we declared it in data

        // // converting strings into integers
        // string originalText = "Can't believe this crappy doohickey works. Like converting a string into an array of bits, then taking that array of bits, chunking them up into byte sizes, and then converting them into string to display them, and then take them to either an ai (like a loser would) or to an online converter machine and get back the same sentence which I wrote here! Crazy!";
        // char letter = 'a';
        // Console.WriteLine(Convert.ToString(letter, toBase: 2));
        // Console.WriteLine(Convert.ToString(Convert.ToByte(letter), toBase: 2) + '\n');

        // BitArray originalTextBitArray = StringToBitArray(originalText);
        // char[] textByte = new char[8];
        // int index = 0;

        // foreach (bool bit in originalTextBitArray) {
        //     int bitInByte = index % 8;

        //     // LSB (bit 0) goes to index 7 so the byte prints MSB-first (left to right)
        //     textByte[7 - bitInByte] = bit ? '1' : '0';

        //     // Print the completed 8-bit group
        //     if (bitInByte == 7) {
        //         Console.Write(new string(textByte) + " ");
        //     }

        //     index++;
        // }
        // Console.WriteLine();

        Console.WriteLine('a' + 'b');


    }

    // static BitArray StringToBitArray(string input) {
    //     byte[] inputByteArray = new byte[input.Length];
    //     BitArray inputBitArray;

    //     uint stringIndex = 0;
    //     foreach (char letter in input) {
    //         inputByteArray[stringIndex] = Convert.ToByte(letter);
    //         stringIndex ++;
    //     }
    //     inputBitArray = new BitArray(inputByteArray);

    //     return inputBitArray;
    // }
}