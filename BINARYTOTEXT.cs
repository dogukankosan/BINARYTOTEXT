using System;
using System.Collections.Generic;
using System.Text;
go:
char choose = default;
Console.WriteLine("****** BİNARY DÖNÜŞÜM PROGRAMI ******");
Console.WriteLine("");
Console.WriteLine("1-)  METİNİ BİNARY SİSTEME ÇEVİR");
Console.WriteLine("2-)  BİNARY SİSTEMİ METİNE ÇEVİR");
Console.WriteLine("3-)  ÇIKIŞ YAP");
Console.Write("SEÇİM YAP= ");
try
{
    choose = char.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("HATALI SEÇİLEN DEĞER LÜTFEN TEKRAR SEÇİNİZ !!");
    Jump();
    goto go;
}
switch (choose)
{
    case '1':
        Console.Write("METNİ GİRİNİZ= ");
        foreach (char c in Console.ReadLine())
            Console.WriteLine(Convert.ToString(c, 2).PadLeft(8, '0'));
        Jump();
        goto go;
    case '2':
        Console.Write("BİNARY DEĞERİNİ GİRİNİZ= ");
        byte[] data = GetBytesFromBinaryString(Console.ReadLine());
        string text = Encoding.ASCII.GetString(data);
        Console.WriteLine(text);
        Jump();
        goto go;
    case '3':
        Console.WriteLine("ÇIKIŞ YAPILIYOR HOŞÇAKALIN !!");
        Console.ReadKey();
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("GİRİLEN DEĞER SEÇİMLER ARASINDA YOK TEKRARDAN GİRİNİZ !!");
        Jump();
        goto go;
}
void Jump()
{
    Console.ReadKey();
    Console.Clear();
}
Byte[] GetBytesFromBinaryString(String binary)
{
    List<byte> list = new();
    try
    {
        for (int i = 0; i < binary.Length; i += 8)
        {
            string t = binary.Substring(i, 8);
            list.Add(Convert.ToByte(t, 2));
        }
    }
    catch (Exception)
    {
        Console.WriteLine("GİRİLEN DEĞER 8 BİT 2 İKİLİK SİSTEME UYGUN DEĞİL");
    }
    return list.ToArray();
}