function divisibleSumPairs(n, k, ar) {
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

// Read input from stdin
const readline = require('readline');
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

let inputLines = [];
rl.on('line', (line) => {
  inputLines.push(line);
});

rl.on('close', () => {
  const [n, k] = inputLines[0].split(' ').map(Number);
  const ar = inputLines[1].split(' ').map(Number);

  const result = divisibleSumPairs(n, k, ar);
  console.log(result);
});
