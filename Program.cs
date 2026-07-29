using game;



Personagem jogador = new Personagem("Aragorn", "Humano", "Skin1", "Guerreiro", 20);

Personagem inimigo = new Personagem("Orc", "Orc", "Skin2", "Bárbaro", 15);

jogador.Andar();

// jogador.Forca = 80;
// inimigo.Vida = 0;

while (jogador.EstaVivo() && inimigo.EstaVivo())
{
    jogador.Atacar(inimigo);
    inimigo.Atacar(jogador);
}

Personagem outroInimigo = new Personagem("Goblin", "Goblin", "Skin3", "Ladrão", 10);

while (jogador.EstaVivo() && outroInimigo.EstaVivo())
{
    jogador.Atacar(outroInimigo);
    outroInimigo.Atacar(jogador);
}





