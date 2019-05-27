# Lottoschein
 Entwickeln Sie eine Methode *VerliereGeld*, die ein int Array entgegennimmt. Das Array soll genau 6 Felder besitzen, denn es enthält die in einem Lottoschein angekreuzten Felder.

 Innerhalb der Methode soll ein mehrdimensionales int Array mit 7x7 Feldern angelegt werden. Jedes Feld soll initial mit seiner korrespondierenden Nummer auf einem Lottoschein gefüllt werden.

Das erzeugte Array soll auf der Konsole ausgegeben werden. An den im übergebenen Array enthaltenen Stellen soll ein x statt einer Zahl ausgegeben werden.

## Beispiel
```int[] auswahl = new int[] { 3, 10, 17, 24, 31, 38 };
VerliereGeld(auswahl);```

<table><tr><td>1</td><td>2</td><td>X</td><td>4</td><td>5</td><td>6</td><td>7</td></tr><tr><td>8</td><td>9</td><td>X</td><td>11</td><td>12</td><td>13</td><td>14</td></tr><tr><td>15</td><td>16</td><td>X</td><td>18</td><td>19</td><td>20</td><td>21</td></tr><tr><td>22</td><td>23</td><td>X</td><td>25</td><td>26</td><td>27</td><td>28</td></tr><tr><td>29</td><td>30</td><td>X</td><td>32</td><td>33</td><td>34</td><td>35</td></tr><tr><td>36</td><td>37</td><td>X</td><td>39</td><td>40</td><td>41</td><td>42</td></tr><tr><td>43</td><td>44</td><td>45</td><td>46</td><td>47</td><td>48</td><td>49</td></tr></table>

[Lösungsvorschlag](https://gist.github.com/gsoTH/58ccbbfa569b71484a0267ac81629bd9)
