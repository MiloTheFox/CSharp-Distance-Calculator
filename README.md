# 3D-Punkt-Distanzrechner

Dieses Programm ist ein einfacher 3D-Punkt-Distanzrechner, der die Euklidische und Manhattan Distanz zwischen drei im Raum definierten Punkten berechnet.

## Ausführung des Programms

Um das Programm auszuführen, befolgen Sie diese Schritte:

1a. **Kompilierung**: Kompilieren Sie das Programm mit einem C#-Compiler, zum Beispiel mit dem Befehl:
   ```bash
   csc Program.cs
   ```
   Dadurch wird eine ausführbare Datei mit dem Namen `Program.exe` erstellt.

2a. **Ausführung**: Führen Sie die erstellte ausführbare Datei folgendermaßen aus:
   ```bash
   ./Program.exe
   ```
<br>
Alternativ können Sie auch folgendes in die Konsole eingeben:
<br><br>

1b. **Kompilierung:** Für die Kompilierung können Sie den folgenden Befehl eingeben
   ```bash
   dotnet build
   ```

2b. **Ausführung:** Anschließend wird das Programm mit dem Befehl:
  ```bash
  dotnet run
  ```
  ausgeführt.

3. **Eingabe der Punkte**: Das Programm wird Sie auffordern, die Koordinaten der beiden Punkte einzugeben. Geben Sie die Koordinaten im Format `x y z` ein, wobei `x`, `y` und `z` numerische Werte sind.

4. **Auswahl der Distanzmethode**: Wähle die gewünschte Distanzmethode aus, indem Sie die entsprechende Zahl eingeben:
   - `1` für die Euklidische Distanz
   - `2` für die Manhattan Distanz

5. **Ergebnis anzeigen**: Das Programm berechnet die ausgewählte Distanz und zeigt das Ergebnis an.

## Beispiel

Hier ist ein Beispiel für die Eingabe und Ausgabe des Programms:

```
Geben Sie den ersten Punkt an (x y z): 1 2 3
Geben Sie den zweiten Punkt an (x y z): 4 5 6
Wählen Sie eine Methode aus:
1 - Euklidische Distanz
2 - Manhattan Distanz
1
Die Euklidische Distanz zwischen den angegebenen Punkten beträgt: 5.20
```

Bitte beachten Sie, dass dieses Beispiel nur eine Demonstration ist, und Sie Ihre eigenen Punktkoordinaten eingeben sollen.

Wenn Sie weitere Informationen bezüglich dem Unterschied zwischen der Euklidischen Distanz Methode und der Manhattan Distanz Methode lesen möchten, zögern Sie nicht, das [Wiki für Euklidische Distanz](https://github.com/LunaTheFox20/CSharp-Distance-Calculator/wiki/Euklidische-Distanz) oder das [Wiki für die Manhattan Distanz](https://github.com/LunaTheFox20/CSharp-Distance-Calculator/wiki/Manhattan-Distanz) aufzurufen.

Viel Spaß beim Verwenden des 3D-Punkt-Distanzrechners!
