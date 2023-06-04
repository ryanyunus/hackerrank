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
/*
using System; adalah pernyataan menggunakan (using statement) yang mengimpor namespace System yang berisi kelas-kelas dasar dan tipe-tipe yang umum digunakan dalam C#.

public class Program adalah deklarasi kelas dengan nama "Program". Ini adalah kelas utama yang akan menjadi titik masuk program.

public static int alternatingCharacters(string s) adalah deklarasi fungsi alternatingCharacters yang mengambil string s sebagai parameter dan mengembalikan tipe data integer.

int deletionCount = 0; adalah deklarasi dan inisialisasi variabel lokal deletionCount dengan nilai awal 0. Variabel ini akan digunakan untuk menghitung jumlah karakter yang perlu dihapus.

char prevChar = s[0]; adalah deklarasi dan inisialisasi variabel lokal prevChar dengan karakter pertama dari string s. Variabel ini akan digunakan untuk melacak karakter sebelumnya saat memeriksa apakah karakter saat ini bersebelahan dengan jenis yang sama.

for (int i = 1; i < s.Length; i++) adalah perulangan yang akan memeriksa setiap karakter dalam string s, dimulai dari indeks 1. Ini karena karakter pertama telah diambil sebelumnya untuk diinisialisasi variabel prevChar.

14-17. Dalam perulangan, kita memeriksa apakah karakter saat ini sama dengan karakter sebelumnya (s[i] == prevChar). Jika benar, artinya karakter saat ini bersebelahan dengan jenis yang sama, dan kita menambahkan 1 ke deletionCount untuk menghitung jumlah karakter yang perlu dihapus. Jika tidak, artinya karakter saat ini berbeda, kita mengubah prevChar menjadi karakter saat ini.

return deletionCount; mengembalikan jumlah karakter yang perlu dihapus sebagai hasil dari fungsi alternatingCharacters.
23-29. Main adalah metode utama yang akan dieksekusi saat program dijalankan. Di dalamnya, kita membaca jumlah pertanyaan dari input menggunakan Console.ReadLine() dan menyimpannya dalam variabel queries. Kemudian, kita menggunakan perulangan untuk membaca setiap string input, memprosesnya menggunakan fungsi alternatingCharacters, dan mencetak hasilnya menggunakan Console.WriteLine.

Sekarang, dengan menggunakan kode tersebut, Anda dapat menghitung jumlah karakter yang perlu dihapus agar sisa karakter membentuk pola bergantian dan mencetak hasilnya.

=====
Dalam masalah "Alternating Characters", pola input dan output dapat dijelaskan sebagai berikut:

Pola Input:

Baris pertama berisi sebuah bilangan bulat, yaitu jumlah pertanyaan (queries).
Setiap baris berikutnya berisi sebuah string (s), yang merupakan string input yang akan diperiksa.
Pola Output:

Untuk setiap string input (s), program akan mencetak satu baris dengan sebuah bilangan bulat, yaitu jumlah karakter yang perlu dihapus agar sisa karakter membentuk pola bergantian yang diinginkan.
5
AAAA
BBBBB
ABABABAB
BABABA
AAABBB
3
4
0
0
4
Dalam contoh di atas, terdapat 5 string input yang diperiksa.

Pada string pertama ("AAAA"), ada 3 karakter yang perlu dihapus agar sisa karakter membentuk pola bergantian ("ABAB").
Pada string kedua ("BBBBB"), ada 4 karakter yang perlu dihapus agar sisa karakter membentuk pola bergantian ("ABABA").
Pada string ketiga ("ABABABAB"), tidak ada karakter yang perlu dihapus karena karakter tersebut sudah membentuk pola bergantian.
Pada string keempat ("BABABA"), tidak ada karakter yang perlu dihapus karena karakter tersebut sudah membentuk pola bergantian.
Pada string kelima ("AAABBB"), ada 4 karakter yang perlu dihapus agar sisa karakter membentuk pola bergantian ("ABAB").
Jadi, pola input adalah jumlah pertanyaan dan string input yang akan diperiksa, sedangkan pola output adalah jumlah karakter yang perlu dihapus untuk membentuk pola bergantian pada setiap string input.
*/