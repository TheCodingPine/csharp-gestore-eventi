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

Evento Evento = new Evento(nome, data, capienzaMassima);










