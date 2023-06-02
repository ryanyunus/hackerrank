use std::io::{self, BufRead};

fn divisible_sum_pairs(n: usize, k: i32, ar: &[i32]) -> i32 {
    let mut count = 0;

    for i in 0..n {
        for j in (i + 1)..n {
            if (ar[i] + ar[j]) % k == 0 {
                count += 1;
            }
        }
    }

    count
}

fn main() {
    let stdin = io::stdin();
    let mut input = stdin.lock().lines();

    let nk: Vec<i32> = input
        .next()
        .unwrap()
        .unwrap()
        .split_whitespace()
        .map(|x| x.parse().unwrap())
        .collect();

    let n = nk[0] as usize;
    let k = nk[1];

    let ar: Vec<i32> = input
        .next()
        .unwrap()
        .unwrap()
        .split_whitespace()
        .map(|x| x.parse().unwrap())
        .collect();

    let result = divisible_sum_pairs(n, k, &ar);
    println!("{}", result);
}
