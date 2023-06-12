#include <iostream>
using namespace std;

int alternatingCharacters(string s) {
    int deletionCount = 0;
    char prevChar = s[0];

    // Memeriksa setiap karakter dalam string, dimulai dari indeks 1
    for (int i = 1; i < s.length(); i++) {
        // Jika karakter saat ini sama dengan karakter sebelumnya, tambahkan ke hitungan penghapusan
        if (s[i] == prevChar) {
            deletionCount++;
        } else {
            // Jika karakter saat ini berbeda, atur karakter saat ini sebagai karakter sebelumnya
            prevChar = s[i];
        }
    }

    return deletionCount;
}

int main() {
    int queries;
    cin >> queries;

    for (int i = 0; i < queries; i++) {
        string input;
        cin >> input;
        int result = alternatingCharacters(input);
        cout << result << endl;
    }

    return 0;
}
