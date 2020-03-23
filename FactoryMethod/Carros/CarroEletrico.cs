namespace FactoryMethod.Carros
{
    public class CarroEletrico : Carro
    {
        public int DuracaoDaBateria { get; set; }
        public int AmperagemDaBateria { get; set; }

        public CarroEletrico(string modelo, int amperagemDaBateria, int duracaoDaBateria,
            bool possuiSistemaAntiColisao) : base(modelo)
        {
            AmperagemDaBateria = amperagemDaBateria;
            DuracaoDaBateria = duracaoDaBateria;
            
            if(possuiSistemaAntiColisao)
                CriarSistemaAntiColisao();;
        }

        public void CriarSistemaAntiColisao()
        {
            //Cria a funcionalidade de sistema anti-colisao
        }

    }
}