# Konfidenzintervall
Implementieren Sie eine Methode *ProofRandom*, die einen int Parameter *n* entgegennimmt. Innerhalb der Methode soll eine Liste vom Typ float mit *n* zufällig erzeugten Zahlen gefüllt werden. Es soll verhindert werden, dass die Liste doppelte Werte enthält. Die Anzahl an erzeugten (aber nicht gespeicherten) doppelten Werten soll zwischengespeichert werden.

Schließlich sollen die erzeugten Werte nach Größe geordnet sowie eine Statistik der Fehlversuche ausgegeben werden.

## Beispiel

Eingabe:

    ProofRandom(100000);

Ausgabe:

    (...)
    0,4690153
    0,6721465
    0,5044202
    Anzahl Einträge:        100000
    Anzahl Fehlversuche:    209
    Einträge / Fehlversuch  478,468899521531

## Erweiterung
Erweitern Sie die Methode so, dass die benötigte Zeit gemessen  und ausgegeben wird.

Eingabe:

    ProofRandom(100000);

Ausgabe:

    (...)
    0,1970776
    0,06566585
    0,3086332
    Anzahl Einträge:        100000
    Anzahl Fehlversuche:    200
    Einträge / Fehlversuch  500
    Benötigte Zeit in ms:   34791




## Verweise
[Random Class](https://docs.microsoft.com/de-de/dotnet/api/system.random?view=netframework-4.8)

[Vergangene Zeit messen](https://stackoverflow.com/questions/14019510/calculate-the-execution-time-of-a-method)

[Lösungsvorschlag](https://gist.github.com/gsoTH/79f39c3d56f7fca66c8b7e04c13957e8)
