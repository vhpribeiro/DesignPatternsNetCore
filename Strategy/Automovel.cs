namespace Strategy
{
    public abstract class Automovel
    {
        public int ProximaManutencao;
        public int KmAtual;
        public abstract void FazerManutencao();
    }
}