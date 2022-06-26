int[] test = new int[] { 2, 6, 7, 1, 3, 23, 6, 7, 8, 4, 45, 30, 55, 100 };
long count = 0;

foreach (int j in test) {
    System.Console.WriteLine(j);
}

System.Console.WriteLine("This is the array unsortiert");
int[] sortedArr = BogoSort(test);
System.Console.WriteLine("This is the array now, sorted");
System.Console.WriteLine($"Es wurden {count} versuche Benötigt");
System.Console.WriteLine($"Dabei liegt die Fakultät von {test.Length} bei {recfact(1, test.Length)}");
foreach (int j in sortedArr) {
    System.Console.WriteLine(j);
}



int[] BogoSort(int[] toSort) {
    Random rnd = new Random();

    while (!isSorted(toSort)) {
        count++;
        int a = rnd.Next(toSort.Length);
        int b = rnd.Next(toSort.Length);

        int temp = toSort[a];
        toSort[a] = toSort[b];
        toSort[b] = temp;
    }

    return toSort;
}

bool isSorted(int[] arr) {
    for (int i = 0; i < arr.Length - 1; i++) {
        if (arr[i] > arr[i + 1]) return false;
    }
    return true;
}

long recfact(long start, long n) {
    long i;
    if (n <= 16) {
        long r = start;
        for (i = start + 1; i < start + n; i++) r *= i;
        return r;
    }
    i = n / 2;
    return recfact(start, i) * recfact(start + i, n - i);
}