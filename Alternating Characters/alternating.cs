/*Dalam tantangan "Alternating Characters" di HackerRank, Anda diberikan sebuah string yang terdiri dari karakter-karakter 'A' dan 'B'. Tujuan Anda adalah menentukan jumlah minimum karakter yang perlu dihapus agar sisa karakter membentuk pola yang bergantian antara 'A' dan 'B'.

Berikut adalah alur penyelesaian masalah ini:

Membaca input: Anda harus membaca input dari pengguna atau masukan yang diberikan oleh HackerRank. Input yang diberikan adalah sebuah string s yang berisi karakter-karakter 'A' dan 'B'.

Menghitung jumlah karakter yang perlu dihapus: Selanjutnya, Anda perlu menghitung jumlah karakter yang perlu dihapus agar sisa karakter membentuk pola yang bergantian. Dalam hal ini, karakter-karakter yang perlu diproses adalah karakter-karakter yang bersebelahan dengan jenis yang sama. Misalnya, jika ada dua karakter 'A' bersebelahan dalam string, maka satu karakter 'A' perlu dihapus agar sisa karakter membentuk pola bergantian.

Anda dapat menggunakan perulangan atau metode pemrosesan string lainnya untuk memeriksa setiap karakter dalam string dan menghitung jumlah karakter yang perlu dihapus. Dalam hal ini, Anda dapat membandingkan setiap karakter dengan karakter sebelumnya untuk memeriksa apakah mereka bersebelahan dengan jenis yang sama.

Menampilkan output: Setelah Anda menghitung jumlah karakter yang perlu dihapus, Anda perlu mencetak angka tersebut sebagai output. Output harus sesuai dengan format yang diminta dalam tantangan.

Sebagai contoh, jika input string adalah "AAABBB", maka Anda perlu menghapus 4 karakter (2 'A' dan 2 'B') agar sisa karakter membentuk pola bergantian 'ABAB'. Jadi, output yang diharapkan adalah 4.

Itulah alur penyelesaian untuk tantangan "Alternating Characters" di HackerRank. Implementasi spesifik dari algoritma ini akan bergantung pada bahasa pemrograman yang digunakan.
*/
using System;

public class Program
{
    public static int alternatingCharacters(string s)
    {
        int deletionCount = 0;
        char prevChar = s[0];

        // Memeriksa setiap karakter dalam string, dimulai dari indeks 1
        for (int i = 1; i < s.Length; i++)
        {
            // Jika karakter saat ini sama dengan karakter sebelumnya, tambahkan ke hitungan penghapusan
            if (s[i] == prevChar)
            {
                deletionCount++;
            }
            else
            {
                // Jika karakter saat ini berbeda, atur karakter saat ini sebagai karakter sebelumnya
                prevChar = s[i];
            }
        }

        return deletionCount;
    }

    public static void Main(string[] args)
    {
        int queries = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < queries; i++)
        {
            string input = Console.ReadLine();
            int result = alternatingCharacters(input);
            Console.WriteLine(result);
        }
    }
}
