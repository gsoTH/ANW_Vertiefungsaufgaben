Im Auftrag eines Hostels entwickeln wir eine Software zur Verwaltung der Gäste in unseren Räumen. Eine Methode *NamenEinlesen* soll eine Anzahl von Strings (in diesem Beispiel 5 Strings) von der Konsole einlesen, in einem Array ablegen und zurückgeben.

## Lösungsunterschlag (c)FIA83 2019

    static string ListeEinlesen()
    {
      string[] Eingabe = {Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),Console.ReadLine()};

      int i = 1;
      foreach(string Wort in Eingabe){
        Console.WriteLine(Eingabe[i]);
        i++;
      }
      return null;
    }

## Detaildiskussion


### Methodenkopf

      static string ListeEinlesen()

#### Modifizierer
Das Schlüsselwort *static* bedeutet an dieser Stelle, dass die Methode Objektübergreifend implementiert ist. Das bedeutet, dass alle Objekte einer Klasse auf dieselbe Instanz (die gleiche != die dieselbe) der Methode zugreifen. Für uns heißt das, wir können ListeEinlesen() aufrufen, ohne auf ein bestimmtes Objekt nach dem Muster Objekt.Methode() zuzugreifen - wie z.B. bei der Methode Console.WriteLine().

#### Returntyp
Die Aufgabenstellung besagt, dass ein String-Array zurückgegeben werden soll. Im Beispiel wird aber nur ein String zurückgegeben.

    static string[] ListeEinlesen()

#### Bezeichnung
Die Aufgabenstellung besagt, dass die Methode *NamenEinlesen* und nicht *ListeEinlesen* heißen soll.

    static string[] NamenEinlesen()

#### Parameter
Die Methode sollte einen Parameter zur Verfügung stellen, über den sich steuern lässt wie viele Namen von der Konsole eingelesen werden. Auf diese Weise können wir die Methode für mehrere Zimmer nutzen (Wiederverwendbarkeit!) und nicht nur für Zimmer mit 5 Betten. Da es sich um eine Variable mit begrenzter Sichtarkeit (nicht public) handelt, wird sie kleingeschrieben.

    static string[] NamenEinlesen(int anzahlNamen)

 Man könnte argumentieren, dass der Nutzer die Anzahl der Nutzer durch eine Konsoleneingabe steuert (z.B. "Geben Sie einen Namen ein und drücken Sie Escape um die Eingabe zu beenden"). So ein Vorgehen kann in bestimmten Fällen nützlich sein, hier aber nicht. Wenn wir eine Buchung vornehmen wollen wir im Vorfeld wissen wie viele Gäste sich anmelden um zu verhindern, dass wir zu wenige Betten zur Verfügung haben. Außerdem schreibt die Aufgabenstellung explizit ein Array vor. Um die Länge des Arrays variabel zu gestalten sind entweder umfangreiche Hilfsmethoden notwendig oder wir müssen auf Listen ausweichen, die wir anschließend in ein Array umwandeln (Umständlich, Verschwendung).

 ### Methodenrumpf
     string[] Eingabe = {Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),Console.ReadLine()};

Hier wird erfolgreich ein Array mit 5 Einträgen erzeugt. Aber auf die schlechtmöglichste Weise.
1. Die Bezeichnung *Eingabe* ist unglücklich gewählt.

  - Das Array enthält mehrere Eingaben statt nur einer Eingabe, daher sollte es mindestens *Eingaben* heißen.
  - Niemand würde sagen "Ich gebe die Eingaben ein und das Array enthält die Eingaben". Viel natürlicher ist "Ich gebe Namen ein und das Array enthält die Namen". Wenn wir das Array in *Namen* umbenennen wird beim Lesen des Codes sofort und an jeder Stelle sofort klar, was im Array enthalten ist.


        string[] Namen = ...

2. Beim Lesen des Codes wird nicht sofort klar wie viele Felder das Array hat. Wir müssen umständlich nachzählen und könnten dabei Fehler machen.

        string[] Namen = new string[anzahlNamen];

2. Offensichtlich wollen wir dieselbe Funktionalität (*Console.ReadLine()*) wiederholt (für jedes Feld in Eingabe) ausführen. Immer wenn wir etwas wiederholen wollen setzen wir Schleifen ein (bzw. Rekursive-Methoden, aber das ist ineffizient). Da wir etwas in das Array eingeben, sollten wir keine foreach-Schleife nutzen, sondern eine zählergesteuerte Schleife einsetzen (for!).

  Im obigen Beispiel sehen wir das schlimmste aus beiden Welten. Weil man mit der foreach-Schleife keine Eingaben in Datenstrukturen vornehmen kann wurde ein manueller Zähler gebaut. Und dieser wird sogar den Wert 5 einnehmen und den Index des Arrays verlassen!

  Diese Schleife wird von 0 bis anzahlNamen-1 laufen. Da der Index eines Arrays bei 0 beginnt hat das letzte Feld in unserem Beispiel den Index 4.

        for(int i = 0; int i < anzahlNamen; i++)
        {
          Console.ReadLine()
        }

3. Wenn im Methodenkopf irgendetwas anderes als *void* steht, weiß der Compiler, dass wir Daten zurückgeben wollen. Dazu nutzen wir *return*. Die Variable hinter *return* soll identisch zum Typ im Methodenkopf sein. (Void ist möglich, aber ein schlechter Stil.)

        return Namen;


        Sobald wir auf ein return stoßen wird der angegebene Wert zurückgegeben und die aktuelle Methode wird sofort verlassen.
