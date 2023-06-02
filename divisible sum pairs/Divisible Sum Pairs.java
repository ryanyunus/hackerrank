import java.util.Scanner;

public class Main {
    public static int divisibleSumPairs(int n, int k, int[] ar) {
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

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int k = scanner.nextInt();

        int[] ar = new int[n];
        for (int i = 0; i < n; i++) {
            ar[i] = scanner.nextInt();
        }

        int result = divisibleSumPairs(n, k, ar);
        System.out.println(result);

        scanner.close();
    }
}
