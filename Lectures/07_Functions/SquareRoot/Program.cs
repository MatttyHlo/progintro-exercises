double SquareRoot(double target){
    int precision = 15;
    double n = target;
    double jump = 2;

    while((target - n*n)*Math.Pow(10,precision) > 1 || (target - n*n)*Math.Pow(10,precision)< -1){
        if(n*n > target) n = n - target/jump;
        else n = n + target/jump;
        jump *=2;
        Console.WriteLine($"{target} , {n}, {n*n} , {target - n*n}");
    }
    return n;
}

int target = 727;

Console.WriteLine($"My value: {SquareRoot(target)}");
Console.WriteLine($"targeted value: {Math.Sqrt(target)}");
