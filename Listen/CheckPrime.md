# Finde alle Primzahlen
Implementieren Sie eine Methode FindPrime, die ein Argument vom Typ long entgegennimmt. Dieses Argument soll upperBound gennant werden und stellt - wie der Name schon sagt - die Obergrenze der zu prüfenden Zahlen dar. Innerhalb der Methode sollen alle Primzahlen zwischen 0 und upperBound gefunden und in einer Liste abgelegt werden. Die Liste soll schließlich zurückgegeben werden.

## Beispiel

Eingabe:

    List<long> primzahlen = FindPrime(8);

    foreach(long i in primzahlen)
    {
      Console.WriteLine(i);
    }

Ausgabe:

    1
    2
    3
    5
    7

## Erweiterungen
1. Implementieren Sie eine Methode PrintPrimeStatistic, die ein Argument vom Typ long entgegennimmt. Innerhalb der Methode soll die Methode FindPrime mit dem übergebenen Argument aufgerufen werden. Die Methode soll eine Statistik entsprechend dem Beispiel ausgeben. Sie sind herzlich eingeladen, weitere Statistiken zu erfinden.

  Eingabe

        PrintPrimeStatistic(8);
Ausgabe

        Primzahlensuche
        Ziel:                 7
        Gefundene Primzahlen: 5
        Benötigte Zeit:       00:00:01

____
2. Implementieren Sie eine weitere Methode mit identischer Bezeichnung, die zwei long-Argumente entgegennimmt. Der neue Parameter trägt den Namen lowerBound und stellt die Untergrenze der zu prüfenden Zahlen dar. Die Methode soll entsprechend alle Primzahlen zwischen lower- und upperBound finden und als Liste zurückgeben.

  Eingabe

        List<long> primzahlen = FindPrime(5, 8);
Ausgabe

        5
        7
____
3. [Fortgeschritten]
Erweitern Sie die Methode FindPrime(long) so, dass die zu erledigenden Rechnungen auf verschiedene Threads aufgeteilt werden. D.h. dass Innerhalb der Methode FindPrime(long) die Methode FindPrime(long, long) mehrfach als eigener Thread aufgerufen wird und die Ergebnisse schließlich zu einer großen Liste zusammengefasst werden.

  [Anhand dieser Codeschnipsel sollten Sie Threads erfolgreich einsetzen können.](http://www.albahari.com/threading/)
