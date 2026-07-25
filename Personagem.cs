namespace game
{
    public class Personagem
    {
        public int Vida { get; set; }
        public string Nome { get; set; }
        public string Raça { get; set; }
        public string Skins { get; set; }
        public string Classe { get; set; }
        public int Forca { get; set; }
        
        public Personagem(string nome, string raça, string skins, string classe, int forca)
        {
            Nome = nome;
            Raça = raça;
            Skins = skins;
            Classe = classe;
            Vida = 100;
            Forca = forca;
        }

        public void Andar()
        {
            Console.WriteLine($"{Nome} está andando.");
        }

        public void TomarDano(int dano)
        {
            Vida -= dano;
            Console.WriteLine($"{Nome} tomou {dano} de dano. Vida atual: {Vida}");
            if (Vida <= 0)
            {
                Console.WriteLine($"{Nome} foi derrotado!");
                Vida = 0;
            }
        }

        public void SubirNivel()
        {
            Forca += 5;
            Vida += 20;
            Console.WriteLine($"{Nome} subiu de nível! Vida atual: {Vida}");
            Console.WriteLine($"{Nome} subiu de nível! Força atual: {Forca}");
        }

        public void Atacar(Personagem alvo)
        {
            Console.WriteLine($"{Nome} está atacando {alvo.Nome} com força {Forca}.");
            alvo.TomarDano(Forca);

            if (alvo.Vida == 0)
            {
                SubirNivel();
            }
        }
    }
}