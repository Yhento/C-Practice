public static int Factorial(int number) {
    int result;
    for (int i = 1; i <= number; i++) {
        result = result * i;
    }
    return result;
}

Console.WriteLine(Factorial(5));