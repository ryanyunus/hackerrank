function divisibleSumPairs($n, $k, $ar) {
  $count = 0;

  for ($i = 0; $i < $n; $i++) {
    for ($j = $i + 1; $j < $n; $j++) {
      if (($ar[$i] + $ar[$j]) % $k === 0) {
        $count++;
      }
    }
  }

  return $count;
}

// Read input from stdin
$stdin = fopen('php://stdin', 'r');
$inputLines = [];

while (($line = fgets($stdin)) !== false) {
  $inputLines[] = trim($line);
}

fclose($stdin);

list($n, $k) = explode(' ', $inputLines[0]);
$ar = array_map('intval', explode(' ', $inputLines[1]));

$result = divisibleSumPairs($n, $k, $ar);
echo $result . "\n";
