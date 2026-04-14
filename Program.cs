namespace EserciziLista2
{
    internal class Program
    {
        static List<int> PicchiDifrequenza(List<int> liste)
        {

        }
        static List<int> Inversione(List<int> liste, int num)
        {
           
            for (int i = 0; i < num; i++)
            {
                int j = 0;
                j = liste[liste.Count - 1];             
                
                liste.RemoveAt(liste.Count - 1);
                liste.Insert(0, j);
                
               
                    
            }
            return liste;
        }
        static List<int> IndiceEsplosivo(List<int> lista)
        {
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] == i)
                {
                    lista.RemoveAt(i);
                }
                
            }
            
            return lista;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Progetto Liste2 13/04/2026");
            List<int> lista1 = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };
            List<int> lista2 = IndiceEsplosivo (lista1);
            foreach (int i in lista2)
            {
                Console.WriteLine(i);
            }
            List<int> listaEs2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("inserisci il numero di spostamenti");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> lista3 = Inversione(listaEs2, n);
            foreach(int j in lista3)
            {
                Console.Write(j);
            }


        }
    }
}
