import 'dart:io';

int divisibleSumPairs(int n, int k, List<int> ar) {
  int count = 0;

  for (int i = 0; i < n; i++) {
    for (int j = i + 1; j < n; j++) {
      if ((ar[i] + ar[j]) % k == 0) {
        count++;
      }
    }
  }

  return count;
}

void main() {
  List<int> inputLine = stdin.readLineSync()!.split(' ').map(int.parse).toList();
  int n = inputLine[0];
  int k = inputLine[1];

  List<int> ar = stdin.readLineSync()!.split(' ').map(int.parse).toList();

  int result = divisibleSumPairs(n, k, ar);
  print(result);
}
