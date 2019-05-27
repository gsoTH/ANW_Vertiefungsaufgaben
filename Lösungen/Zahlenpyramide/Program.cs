using System;

namespace Zahlenpyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructPyramid(16, 16);
            Console.ReadKey();
        }

        /// <summary>
        /// Diese Methode füllt zunächst alle Felder mit 0 und prüft
        /// anschließend, ob alle umliegenden Felder identische Werte haben.
        /// Die Suche nach identischen Felder muss mehrfach ausgeführt werden.
        /// </summary>
        static void ConstructPyramid(int n, int m)
        {
            // Ein neues mehrdimensionales Array erzeugen
            int[,] ma = new int[n, m];

            // Alle Felder initial mit 0 füllen
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ma[i, j] = 0;
                }
            }


            bool neuenWertGefunden = true;

            while (neuenWertGefunden)
            {
                neuenWertGefunden = false;

                // Erste/Letzte Zeile/Spalte immer 0
                // Werden nicht geprüft
                for (int i = 1; i < n - 1; i++)
                {
                    for (int j = 1; j < m - 1; j++)
                    {
                        int kleinsterWert = ma[i, j];
                        int a = kleinsterWert;

                        // KleinstenWert des Umfelds ermitteln
                        for (int k = i - 1; k <= i + 1; k++)
                        {
                            for (int l = j - 1; l <= j + 1; l++)
                            {
                                kleinsterWert = Math.Min(kleinsterWert, ma[k, l]);

                            }
                        }

                        // Den gefundenen Wert inkrementieren
                        if (a != kleinsterWert + 1)
                        {
                            ma[i, j] = kleinsterWert + 1;
                            neuenWertGefunden = true;
                        }
                    }
                }
            }

            // Alle Felder ausgeben
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(ma[i, j]);
                    }
                    Console.Write("\n");
                }
        }
    }
}
