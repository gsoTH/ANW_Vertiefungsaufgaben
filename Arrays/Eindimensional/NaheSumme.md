# Finde die (nächst)mögliche Summe

Implementieren Sie eine Methode *FindeSumme*, die zwei int Arrays sowie einen int Wert entgegennimmt. Die Methode soll eine Summe aus jeweils einem Element beider Arrays bilden, die genau (oder möglichst nahe an) dem übergebenen Wert entspricht und zurückgeben. Sollten zwei Ergebnisse mit identischer Abweichung vorliegen, reicht es, wenn eines der Ergebisse zurückgegeben wird.

## Beispiel
Eingabe:

    int[] a = new int[] {-1, 3, 8, 2, 9, 5};
    int[] b = new int[] {4, 1, 2, 10, 5, 20};
    int ziel = 24;

    Console.WriteLine(FindeSumme(a, b, ziel));

Ausgabe:

    23

## Verweise
[Absolute Werte ermitteln mit ´Math.Abs()´](https://docs.microsoft.com/de-de/dotnet/api/system.math.abs?view=netframework-4.8)

[Quelle: CS Dojo](https://youtu.be/GBuHSRDGZBY)

[Lösungsvorschlag](https://gist.github.com/gsoTH/745563dc6fc7dfa919e4404381c9494d)
