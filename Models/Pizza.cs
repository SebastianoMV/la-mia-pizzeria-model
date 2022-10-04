namespace la_mia_pizzeria_model.Models
{
    public class Pizza
    {
        public Pizza(string nome, string descrizione, string image, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Image = image;
            Prezzo = prezzo;

        }

        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Image { get; set; }
        public double Prezzo { get; set; }
    }
}
