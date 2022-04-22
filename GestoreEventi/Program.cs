using GestoreEventi;

/* voglio provare a mantenere un while=true che richieda gli inserimenti
 * 
  bool provaInserimentoNome = false;
while (provaInserimentoNome == false)
{
    try
    {
        //codice che genera eccezioni
    }
    catch
    {

    }
    finally
    {
        provaInserimentoNome = true;
    }
}
*/

Console.WriteLine("Creazione nuovo evento");
Console.Write("Inserire nome evento: ");
string nome = Console.ReadLine();
Console.Write("Inserire data evento: ");
DateTime data = DateTime.Parse(Console.ReadLine());
Console.Write("QUal'è il numero dei posti disponibili? ");
uint capienzaMassima = uint.Parse(Console.ReadLine());

Evento Evento1 = new Evento (nome, data, capienzaMassima);

Console.Write("Quanti posti vuoi prenotare? ");
uint numeroPrenotazioni = uint.Parse(Console.ReadLine());
Evento1.Prenota(numeroPrenotazioni);
Console.WriteLine("Di " + capienzaMassima + "posti ne hai stati prenotati " + numeroPrenotazioni);

Console.Write("Quanti posti prenotati vuoi disdire? ");
uint numeroDisdette = uint.Parse(Console.ReadLine());
Evento1.Prenota(numeroPrenotazioni);
Console.WriteLine("Di " + capienzaMassima + "posti ne hai disdetti " + numeroDisdette + "e restano prenotati " + numeroPrenotazioni);





