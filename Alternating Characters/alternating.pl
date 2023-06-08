use strict;
use warnings;

sub alternatingCharacters {
    my ($s) = @_;
    my $deletionCount = 0;
    my $prevChar = substr($s, 0, 1);

    # Memeriksa setiap karakter dalam string, dimulai dari indeks 1
    for my $i (1 .. length($s) - 1) {
        # Jika karakter saat ini sama dengan karakter sebelumnya, tambahkan ke hitungan penghapusan
        if (substr($s, $i, 1) eq $prevChar) {
            $deletionCount++;
        } else {
            # Jika karakter saat ini berbeda, atur karakter saat ini sebagai karakter sebelumnya
            $prevChar = substr($s, $i, 1);
        }
    }

    return $deletionCount;
}

# Membaca jumlah pertanyaan
my $queries = <STDIN>;
chomp($queries);

# Memproses setiap pertanyaan
for (my $i = 0; $i < $queries; $i++) {
    my $input = <STDIN>;
    chomp($input);
    my $result = alternatingCharacters($input);
    print("$result\n");
}
