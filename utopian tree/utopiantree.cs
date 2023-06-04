using System;

class Result {
    public static int utopianTree(int n) {
        int height = 1;
        
        for (int i = 1; i <= n; i++) {
            if (i % 2 == 0) {
                height += 1;
            } else {
                height *= 2;
            }
        }
        
        return height;
    }
    
    static void Main() {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++) {
            int n = int.Parse(Console.ReadLine());
            int result = utopianTree(n);
            Console.WriteLine(result);
        }
    }
}
