
/*
Pola yang diberikan dalam masalah "Utopian Tree" di HackerRank adalah sebagai berikut:

Pada tahun genap (mulai dari tahun 0), pohon akan mengalami pertumbuhan dua kali lipat dari tinggi sebelumnya.
Pada tahun ganjil, pohon akan tumbuh sebanyak 1 meter.
Kita diminta untuk menghitung tinggi pohon pada tahun-tahun tertentu berdasarkan pola ini.

Untuk memecahkan masalah ini, Anda dapat menggunakan pendekatan berikut:

Buatlah sebuah variabel untuk menyimpan tinggi awal pohon (misalnya, tinggi_pohon = 1).
Loop melalui tahun-tahun yang diberikan.
Di dalam loop, gunakan sebuah pernyataan kondisional untuk memeriksa apakah tahun tersebut genap atau ganjil.
Jika tahun genap, tinggi pohon akan dua kali lipat (tinggi_pohon *= 2).
Jika tahun ganjil, tinggi pohon akan ditambah 1 (tinggi_pohon += 1).
Setelah melalui semua tahun, kembalikan tinggi pohon.
========== POLA INPUT DAN OUTPUT
Input:

Baris pertama berisi angka bulat T, yang merupakan jumlah kasus uji.
Kemudian, setiap baris berikutnya berisi angka bulat N, yang mewakili jumlah siklus yang akan dilalui oleh pohon.
Output:

Untuk setiap kasus uji, cetak tinggi pohon pada akhir siklus terakhir.
Pola Input dan Output:

Misalnya, jika kita memiliki T = 3, maka ada tiga kasus uji yang akan dijelaskan sebagai berikut:

Kasus Uji 1:
Input:


2
Output:

3
Penjelasan: Pada kasus uji ini, kita memiliki satu siklus, dan tinggi awal pohon adalah 1. Setelah satu siklus, tinggi pohon menjadi dua kali lipat (2) setelah musim semi dan kemudian tumbuh satu meter saat musim panas (3). Jadi, pada akhir siklus, tinggi pohon adalah 3.

Kasus Uji 2:
Input:

1
Output:

2
Penjelasan: Pada kasus uji ini, kita hanya memiliki satu siklus, dan tinggi awal pohon adalah 1. Setelah satu siklus, tinggi pohon menjadi dua kali lipat (2) setelah musim semi. Jadi, pada akhir siklus, tinggi pohon adalah 2.

Kasus Uji 3:
Input:

4
Output:

7
Penjelasan: Pada kasus uji ini, kita memiliki empat siklus, dan tinggi awal pohon adalah 1. Setelah siklus pertama, tinggi pohon menjadi dua kali lipat (2) setelah musim semi, kemudian tumbuh satu meter saat musim panas (3). Pada siklus kedua, tinggi pohon kembali menjadi dua kali lipat (6) setelah musim semi, kemudian tumbuh satu meter saat musim panas (7). Jadi, pada akhir siklus, tinggi pohon adalah 7.

Demikianlah pola input dan output yang ada dalam masalah "Utopian Tree". Setiap kasus uji mengikuti pola yang sama, di mana kita menghitung tinggi pohon pada akhir siklus berdasarkan jumlah siklus yang diberikan dan menggunakan tinggi awal pohon sebagai titik awal.
*/