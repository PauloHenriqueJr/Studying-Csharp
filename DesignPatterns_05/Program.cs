namespace DesignPatterns_05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating a new NotaFiscal object without using the Builder Pattern

            // IList<ItemDaNota> itens = new List<ItemDaNota>();
            // itens.Add(new ItemDaNota("item 1", 100.0));
            // itens.Add(new ItemDaNota("item 2", 200.0));
            // itens.Add(new ItemDaNota("item 3", 300.0));

            // double valorBruto = 0;
            // double impostos = 0;

            // foreach (var item in itens)
            // {
            //     valorBruto += item.Valor;
            //     impostos += item.Valor * 0.05;
            // }

            // NotaFiscal nf = new NotaFiscal("Caelum", "11.111.111/0001-11", DateTime.Now, valorBruto, impostos, itens, "obs");

            // Console.WriteLine("Nota Fiscal criada sem o Builder Pattern");
            // Console.WriteLine("Razão Social: " + nf.RazaoSocial);
            // Console.WriteLine("CNPJ: " + nf.Cnpj);
            // Console.WriteLine("Data de Emissão: " + nf.DataDeEmissao);
            // Console.WriteLine("Valor Bruto: " + nf.ValorBruto);
            // Console.WriteLine("Impostos: " + nf.Impostos);


            // Creating a new NotaFiscal object using the Builder Pattern

            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("12.345.678/0001-12")
                .ComItem(new ItemDaNota("item 1", 100.0))
                .ComItem(new ItemDaNota("item 2", 200.0))
                .ComItem(new ItemDaNota("item 3", 300.0))
                .ComObservacoes("entregar nf pessoalmente");
            builder.NaDataAtual();
            NotaFiscal nf = builder.Constroi();
            Console.WriteLine("Nota Fiscal criada com o Builder Pattern");
            Console.WriteLine("Razão Social: " + nf.RazaoSocial);
            Console.WriteLine("CNPJ: " + nf.Cnpj);
            Console.WriteLine("Data de Emissão: " + nf.DataDeEmissao);
            Console.WriteLine("Valor Bruto: " + nf.ValorBruto);
            Console.WriteLine("Impostos: " + nf.Impostos);
        }
    }
}