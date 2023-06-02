using System;

// Menggunakan namespace System yang menyediakan kelas-kelas dan fungsi-fungsi dasar
// yang digunakan dalam pemrograman C#
class Program
{
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int count = 0;

        // Loop untuk setiap elemen pada array
        for (int i = 0; i < n; i++)
        {
            // Loop untuk mencari pasangan elemen
            for (int j = i + 1; j < n; j++)
            {
                // Mengecek apakah penjumlahan dua elemen dapat dibagi habis oleh k
                if ((ar[i] + ar[j]) % k == 0)
                {
                    count++; // Jika ya, tambahkan count
                }
            }
        }

        return count; // Mengembalikan jumlah pasangan yang memenuhi kondisi
    }

    static void Main()
    {
        int n, k;

        // Membaca input jumlah elemen dan bilangan pembagi dari pengguna
        string[] input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        k = int.Parse(input[1]);

        int[] ar = new int[n];

        // Membaca elemen-elemen array dari pengguna
        string[] arrayInput = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            ar[i] = int.Parse(arrayInput[i]);
        }

        // Memanggil fungsi divisibleSumPairs untuk menghitung jumlah pasangan yang memenuhi kondisi
        int result = divisibleSumPairs(n, k, ar);

        // Menampilkan hasil perhitungan ke layar
        Console.WriteLine(result);
    }
}

/*
mengimplementasikan sebuah fungsi untuk mencari jumlah pasangan angka dalam sebuah array yang dapat dibagi habis oleh suatu bilangan.

Berikut adalah penjelasan per baris kode tersebut:

using System;: Ini adalah pernyataan yang memberitahu compiler untuk menggunakan namespace System. Namespace System menyediakan berbagai kelas dan fungsi yang sering digunakan dalam pemrograman C#, termasuk kelas-kelas yang terkait dengan input/output.

class Program: Membuka definisi kelas Program.

static int divisibleSumPairs(int n, int k, int[] ar): Ini adalah definisi fungsi divisibleSumPairs. Fungsi ini mengambil tiga argumen: n (jumlah elemen dalam array), k (bilangan yang harus habis dibagi), dan ar (array integer). Fungsi ini menghitung dan mengembalikan jumlah pasangan elemen dalam array ar yang dapat dibagi habis oleh k.

int count = 0;: Mendeklarasikan dan menginisialisasi variabel count dengan nilai 0. Variabel ini digunakan untuk menghitung jumlah pasangan yang memenuhi kondisi.

for (int i = 0; i < n; i++): Memulai loop for untuk variabel i dari 0 hingga n-1. Loop ini digunakan untuk mengiterasi setiap elemen dalam array.

for (int j = i + 1; j < n; j++): Memulai loop for dalam loop for sebelumnya untuk variabel j dari i + 1 hingga n-1. Loop ini digunakan untuk mencari pasangan elemen yang belum dihitung dengan elemen ar[i].

if ((ar[i] + ar[j]) % k == 0): Memeriksa apakah penjumlahan elemen ar[i] dan ar[j] dapat dibagi habis oleh k. Jika ya, maka pasangan ini memenuhi kondisi dan count akan ditambah satu.

return count;: Mengembalikan nilai count setelah selesai menghitung jumlah pasangan.

static void Main(): Definisi fungsi Main. Ini adalah titik masuk untuk eksekusi program.

int n, k;: Mendeklarasikan variabel n dan k untuk menyimpan input.

string[] input = Console.ReadLine().Split();: Membaca input dari pengguna sebagai sebuah string dan membaginya menjadi array string menggunakan spasi sebagai pemisah. Kemudian, array string tersebut disimpan dalam variabel input.

n = int.Parse(input[0]);: Mengonversi elemen pertama dalam array input menjadi integer dan menyimpannya dalam variabel n.

k = int.Parse(input[1]);: Mengonversi elemen kedua dalam array input menjadi integer dan menyimpannya dalam variabel k.

int[] ar = new int[n];: Mendeklarasikan array ar dengan ukuran n untuk menyimpan elemen-elemen input.

string[] arrayInput = Console.ReadLine().Split();: Membaca input dari pengguna sebagai sebuah string dan membaginya menjadi array string menggunakan spasi sebagai pemisah. Kemudian, array string tersebut disimpan dalam variabel arrayInput.

for (int i = 0; i < n; i++): Memulai loop for untuk variabel i dari 0 hingga n-1. Loop ini digunakan untuk mengiterasi setiap elemen dalam array.

ar[i] = int.Parse(arrayInput[i]);: Mengonversi setiap elemen dalam array arrayInput menjadi integer dan menyimpannya dalam array ar pada indeks yang sesuai.

int result = divisibleSumPairs(n, k, ar);: Memanggil fungsi divisibleSumPairs dengan argumen yang sesuai dan menyimpan hasilnya dalam variabel result.

Console.WriteLine(result);: Menampilkan hasil perhitungan ke layar.

Kode di atas membaca dua baris input dari pengguna. Baris pertama berisi dua angka yang dipisahkan oleh spasi, yaitu n (jumlah elemen dalam array) dan k (bilangan yang harus habis dibagi). Baris kedua berisi n angka yang dipisahkan oleh spasi, yaitu elemen-elemen array ar. Setelah itu, program menghitung dan menampilkan jumlah pasangan elemen dalam array ar yang dapat dibagi habis oleh k.
*/