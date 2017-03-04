namespace Presentation
{
    class Screen2 : IScreen
    {
        public string Text { get; } =
@"Napisać program który na wejściu będzie przyjmował 3 liczby:
x, y oraz n oraz dowolny tekst o długości równej x+y. 
Użytkownik powinien wpisać równej długości tekst, 
aby mu to ułatwić będzie wyświetlana maska xxxxxx nad tekstem 
dzięki czemu będzie widać ile znaków pozostało. 
Nie robimy walidacji wprowadzonych danych! 
Następnie będzie wykonywał następujący algorytm:
Wykonaj n razy:
Podziel tekst na 2 części od długościach x i y
Zamień te teksty miejscami i złącz otrzymując nowy napis
Na końcu wypisz otrzymany tekst na konsolę.

Przykład:
Input
-----
4
5
3
AlaMaKota
-----

Output
-----
MaKotaAla

Przebieg wygląda tak:
AlaM, aKota => aKotaAlaM
aKot, aAlaM => aAlaMaKot
aAla, MaKot => MaKotaAla
-----

Ćwiczenie: odpal program z nieprawidłowymi parametrami
(np. x jako ciag znaków, albo za krótki tekst) i zobacz jaki jest efekt.
";
        public DisplayMethod Method { get; } = DisplayMethod.CharByChar;
    }
}
