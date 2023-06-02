def divisibleSumPairs(n, k, ar)
    count = 0
    
    for i in 0...n
    for j in (i + 1)...n
    if (ar[i] + ar[j]) % k == 0
    count += 1
    end
    end
    end
    
    return count
    end
    
    n, k = gets.strip.split(' ').map(&:to_i)
    ar = gets.strip.split(' ').map(&:to_i)
    
    result = divisibleSumPairs(n, k, ar)
    puts result