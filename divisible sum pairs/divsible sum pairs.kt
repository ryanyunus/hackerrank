import java.util.Scanner

fun divisibleSumPairs(n: Int, k: Int, ar: IntArray): Int {
    var count = 0

    for (i in 0 until n) {
        for (j in i + 1 until n) {
            if ((ar[i] + ar[j]) % k == 0) {
                count++
            }
        }
    }

    return count
}

fun main() {
    val scanner = Scanner(System.`in`)
    val n = scanner.nextInt()
    val k = scanner.nextInt()
    val ar = IntArray(n)

    for (i in 0 until n) {
        ar[i] = scanner.nextInt()
    }

    val result = divisibleSumPairs(n, k, ar)
    println(result)
}
