using System;
using System.Xml.Serialization;

namespace Adapter.Adaptee
{
    [Serializable]
    public class Empregado
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Nome { get; set; }

        private Empregado(){}
        
        public Empregado(int id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
}