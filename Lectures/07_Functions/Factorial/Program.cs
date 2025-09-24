int Factorial(int a){
    if(a == 1) return 1;
    else return Factorial(a-1) * a;
}

Console.WriteLine(Factorial(6));
