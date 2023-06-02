<?php

function divisibleSumPairs($n, $k, $ar)
{
    $count = 0;
    for ($i = 0; $i < $n; $i++) {
        for ($j = $i + 1; $j < $n; $j++) {
            if (($ar[$i] + $ar[$j]) % $k == 0) {
                $count++;
            }
        }
    }
    return $count;
}

$input = explode(" ", readline());
$n = intval($input[0]);
$k = intval($input[1]);
$ar = array_map('intval', explode(" ", readline()));
$result = divisibleSumPairs($n, $k, $ar);
echo $result;

?>