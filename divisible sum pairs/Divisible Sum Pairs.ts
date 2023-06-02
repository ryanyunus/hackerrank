import * as readline from 'readline';

function divisibleSumPairs(n: number, k: number, ar: number[]): number {
  let count = 0;

  for (let i = 0; i < n; i++) {
    for (let j = i + 1; j < n; j++) {
      if ((ar[i] + ar[j]) % k === 0) {
        count++;
      }
    }
  }

  return count;
}

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

let inputLines: string[] = [];
rl.on('line', (line: string) => {
  inputLines.push(line);
});

rl.on('close', () => {
  const [n, k] = inputLines[0].split(' ').map(Number);
  const ar = inputLines[1].split(' ').map(Number);

  const result = divisibleSumPairs(n, k, ar);
  console.log(result);
});

/* 
Baris per baris, berikut adalah penjelasan kode di atas:

import * as readline from 'readline';: Ini adalah sintaks untuk mengimpor modul readline dari Node.js. Modul ini digunakan untuk membaca input dari pengguna melalui terminal.

function divisibleSumPairs(n: number, k: number, ar: number[]): number {: Ini adalah deklarasi fungsi divisibleSumPairs dengan tiga parameter: n (sebuah angka), k (sebuah angka), dan ar (sebuah array angka). Fungsi ini mengembalikan sebuah angka.

let count = 0;: Ini mendeklarasikan variabel count dan menginisialisasinya dengan nilai 0. Variabel ini akan digunakan untuk menghitung jumlah pasangan angka yang dapat dibagi habis oleh k.

for (let i = 0; i < n; i++) {: Ini adalah loop for yang akan berjalan dari i = 0 hingga i < n. Loop ini digunakan untuk memeriksa semua pasangan angka dalam array ar.

for (let j = i + 1; j < n; j++) {: Ini adalah loop for yang akan berjalan dari j = i + 1 hingga j < n. Loop ini digunakan untuk memeriksa semua pasangan angka setelah ar[i] dalam array ar.

if ((ar[i] + ar[j]) % k === 0) {: Ini adalah kondisi if yang memeriksa apakah jumlah dari ar[i] dan ar[j] dapat dibagi habis oleh k.

count++;: Jika pasangan angka tersebut dapat dibagi habis oleh k, maka count akan ditambah satu.

return count;: Fungsi divisibleSumPairs mengembalikan nilai dari variabel count, yaitu jumlah pasangan angka yang dapat dibagi habis oleh k.

const rl = readline.createInterface({ input: process.stdin, output: process.stdout });: Membuat objek rl menggunakan fungsi createInterface dari modul readline. Objek ini akan digunakan untuk membaca input dari pengguna melalui terminal.

let inputLines: string[] = [];: Mendeklarasikan variabel inputLines sebagai array kosong. Array ini akan digunakan untuk menyimpan baris-baris input dari pengguna.

rl.on('line', (line: string) => { inputLines.push(line); });: Menambahkan event listener ke objek rl yang akan memasukkan setiap baris input pengguna ke dalam array inputLines saat pengguna menekan tombol Enter.

rl.on('close', () => {: Menambahkan event listener ke objek rl yang akan dieksekusi ketika pengguna menutup input.

const [n, k] = inputLines[0].split(' ').map(Number);: Menguraikan baris pertama dari inputLines menjadi dua angka, n dan k, menggunakan fungsi split dengan pemisah spasi. Angka-angka tersebut kemudian diubah menjadi tipe data Number menggunakan fungsi map(Number).

const ar = inputLines[1].split(' ').map(Number);: Menguraikan baris kedua dari inputLines menjadi array ar menggunakan fungsi split dengan pemisah spasi. Angka-angka tersebut kemudian diubah menjadi tipe data Number menggunakan fungsi map(Number).

const result = divisibleSumPairs(n, k, ar);: Memanggil fungsi divisibleSumPairs dengan argumen n, k, dan ar, dan menyimpan hasilnya ke dalam variabel result.

console.log(result);: Mencetak hasil yang didapatkan ke dalam terminal.
*/