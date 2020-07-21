using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Adapter.Adaptee
{
    public class GerenciadorDeEmpregados
    {
        public  List<Empregado> Empregados;

        public GerenciadorDeEmpregados()
        {
            Empregados = new List<Empregado>();
            Empregados.Add(new Empregado(1, "Vitor"));
            Empregados.Add(new Empregado(2, "João"));
            Empregados.Add(new Empregado(3, "Maria"));
        }

        public virtual string ObterTodosEmpregados()
        {
            var nomesVazios = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(Empregados.GetType());
            var configuracoes = new XmlWriterSettings();
            configuracoes.Indent = true;
            configuracoes.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, configuracoes))
            {
                serializer.Serialize(writer, Empregados, nomesVazios);
                return stream.ToString();
            }
        }
    }
}