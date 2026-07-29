namespace game
{
    public class Personagem
    {
        
        public int Vida { get; private set; }
        public string Nome { get; set; }
        public string Raça { get; set; }
        public string Skins { get; set; }
        public string Classe { get; set; }
        public int Forca { get; private set; }

        public Personagem(string nome, string raca, string skins, string classe,
                         int forca) 
        {
            Nome = nome;
            Classe = classe;
            Raça = raca;
            Skins = skins;
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
            if (EstaMorto())
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
        public bool EstaVivo()
        {
            return Vida > 0;
        }
        public bool EstaMorto()
        {
            return Vida <= 0;
        }

        public void Atacar(Personagem alvo)
        {
            if (EstaMorto())
            {
                return;
            }

            Console.WriteLine($"{Nome} está atacando {alvo.Nome} com força {Forca}.");
            alvo.TomarDano(Forca);

            if (alvo.EstaMorto())
            {
                SubirNivel();
            }
        }
    }
}