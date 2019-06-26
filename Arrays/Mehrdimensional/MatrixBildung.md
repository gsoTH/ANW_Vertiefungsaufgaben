# Matrixbildung
Implementieren Sie eine Methode ErzeugeMatrixProdukt, die zwei eindimensionale int-Arrays entgegennimmt. Innerhalb der Methode sollen alle Felder der int-Arrays miteinander multipliziert und die Ergebnisse in einem zweidimensionalen Array abgelegt werden. Das Ergebnis-Array soll zurückgegeben werden.

## Beispiel

Eingabe:

    int[] a = new int[]{2, 4};
    int[] b = new int[]{3, 5, 7};
    ErzeugeMatrixProdukt(a, b);

Ausgabe:

<table><tr><td>6</td><td>10</td><td>14</td></tr><tr><td>12</td><td>20</td><td>28</td></tr></table>




int[] g = new int[] { 2, 4 };
            int[] h = new int[] { 3, 5, 7 };
            int[,] ergebnis = ErzeugeMatrixProdukt(g, h);

            for (int i = 0; i < ergebnis.GetLength(0); i++)
            {
                for (int j = 0; j < ergebnis.GetLength(1); j++)
                {
                    Console.Write(ergebnis[i, j] + "\t");
                }
                Console.Write("\n");
            }



            static int[,] ErzeugeMatrixProdukt (int[] a, int[] b)
       {
           int[,] ergebnis = new int[a.Length, b.Length];

           for (int i = 0; i < a.Length; i++)
           {
               for (int j = 0; j < b.Length; j++)
               {
                   ergebnis[i, j] = a[i] * b[j];
               }
           }

           return ergebnis;
       }
