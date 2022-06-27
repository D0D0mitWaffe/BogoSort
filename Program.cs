int[] test = new int[] { 2, 1, 7, 1, 3 };
long count = 0;

foreach (int j in test) {
    System.Console.WriteLine(j);
}

System.Console.WriteLine("This is the array unsortiert");
System.Console.WriteLine(DateTime.Now.ToString());
DateTime start = new DateTime();
start = DateTime.Now;
int[] sortedArr = BogoSort(test);
DateTime end = new DateTime();
end = DateTime.Now;
TimeSpan t = end - start;
System.Console.WriteLine("This is the array now, sorted");
System.Console.WriteLine($"Es wurden {count} versuche Benötigt");
System.Console.WriteLine($"Dabei liegt die Fakultät von {test.Length} bei {recfact(1, test.Length)}");
System.Console.WriteLine($"Dabei hat das sortieren {t.ToString("mm\\:ss")}");
foreach (int j in sortedArr) {
    System.Console.WriteLine(j);
}



int[] BogoSort(int[] toSort) {
    Random rnd = new Random();

    while (!isSorted(toSort)) {
        count++;
        if (count % 100000 == 0) {
            System.Console.WriteLine($"Es wurden {count} versuche Benötigt");
        }
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