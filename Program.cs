using System;

class Program
{
    // Definiert eine 3D-Punkt-Klasse mit X, Y und Z als Koordinaten
    public class Point3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        // Konstruktor für die Point3D-Klasse
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    // Enum zur Auswahl der Distanzmethode
    public enum DistanceMethod
    {
        Euclidean,
        Manhattan
    }

    static void Main()
    {
        Point3D? point1 = GetPointFromUser("Geben Sie den ersten Punkt an (x y z): ");
        if (point1 == null) return;
        Point3D? point2 = GetPointFromUser("Geben Sie den zweiten Punkt an (x y z): ");
        if (point2 == null) return;

        DistanceMethod? choice = GetDistanceMethod();
        if (!choice.HasValue) return;

        // Auswahl der Distanzmethode basierend auf der Benutzereingabe
        switch (choice.Value)
        {
            case DistanceMethod.Euclidean:
                // Berechnung der Euklidischen Distanz zwischen zwei Punkten
                double euclideanDistance = Math.Sqrt(Math.Pow(point1.Value.X - point2.Value.X, 2) + Math.Pow(point1.Value.Y - point2.Value.Y, 2) + Math.Pow(point1.Value.Z - point2.Value.Z, 2));
                Console.WriteLine($"Die Euklidische Distanz zwischen den angegebenen Punkten beträgt: {euclideanDistance:F2}");
                break;
            case DistanceMethod.Manhattan:
                // Berechnung der Manhattan Distanz zwischen zwei Punkten
                double manhattanDistance = Math.Abs(point1.Value.X - point2.Value.X) + Math.Abs(point1.Value.Y - point2.Value.Y) + Math.Abs(point1.Value.Z - point2.Value.Z);
                Console.WriteLine($"Die Manhattan Distanz zwischen den angegebenen Punkten beträgt: {manhattanDistance:F2}");
                break;
        }
    }

    static Point3D? GetPointFromUser(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            var input = Console.ReadLine() ?? string.Empty;

            if (ValidateInput(input, out var result))
            {
                return result;
            }

            Console.WriteLine($"Fehlerhafte Eingabe! Bitte geben Sie 3 Zahlen, die jeweils mit einem Leerzeichen getrennt sind, an!{Environment.NewLine}");
        }
    }

    // Methode zur Überprüfung, ob die Benutzereingabe in einen Punkt umgewandelt werden kann
    static bool ValidateInput(string input, out Point3D result)
    {
        var parts = input.Split(' ');

        if (parts.Length != 3 ||
            !double.TryParse(parts[0], out var x) ||
            !double.TryParse(parts[1], out var y) ||
            !double.TryParse(parts[2], out var z))
        {
            result = default;
            return false;
        }

        result = new Point3D(x, y, z);
        return true;
    }

    static DistanceMethod? GetDistanceMethod()
    {
        do
        {
            // Eingabeaufforderung für den Benutzer zur Auswahl der Distanzmethode
            Console.WriteLine($"Wählen Sie eine Methode aus: {Environment.NewLine}1 - Euclidean Distanz{Environment.NewLine}2 - Manhattan Distanz");
            var input = Console.ReadLine() ?? string.Empty;

            switch (input)
            {
                case "1":
                    return DistanceMethod.Euclidean;
                case "2":
                    return DistanceMethod.Manhattan;
                default:
                    Console.WriteLine($"Fehlerhafte Eingabe! Bitte geben Sie \"1\" für Euclidean oder \"2\" für Manhattan ein!{Environment.NewLine}");
                    break;
            }
        } while (true);
    }
}
