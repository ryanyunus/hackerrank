package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func alternatingCharacters(s string) int {
	deletionCount := 0
	prevChar := s[0]

	// Memeriksa setiap karakter dalam string, dimulai dari indeks 1
	for i := 1; i < len(s); i++ {
		// Jika karakter saat ini sama dengan karakter sebelumnya, tambahkan ke hitungan penghapusan
		if s[i] == prevChar {
			deletionCount++
		} else {
			// Jika karakter saat ini berbeda, atur karakter saat ini sebagai karakter sebelumnya
			prevChar = s[i]
		}
	}

	return deletionCount
}

func main() {
	scanner := bufio.NewScanner(os.Stdin)

	// Membaca jumlah pertanyaan
	scanner.Scan()
	queries, _ := strconv.Atoi(scanner.Text())

	// Memproses setiap pertanyaan
	for i := 0; i < queries; i++ {
		scanner.Scan()
		input := scanner.Text()
		result := alternatingCharacters(input)
		fmt.Println(result)
	}
}
