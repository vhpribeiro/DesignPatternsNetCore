using System.Xml;
using Adapter.Adaptee;
using Adapter.Target;
using Newtonsoft.Json;

namespace Adapter.Adapter
{
    public class EmpregadoAdapter : GerenciadorDeEmpregados, IEmpregado
    {
        public override string ObterTodosEmpregados()
        {
            var retornoEmXml = base.ObterTodosEmpregados();
            var documento = new XmlDocument();
            documento.LoadXml(retornoEmXml);
            return JsonConvert.SerializeObject(documento, Newtonsoft.Json.Formatting.Indented);
        }
    }
}