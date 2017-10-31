namespace Solid.LiskovSubstitutionPrinciple
{
    public class File
    {
        
    } 

    public class ArquivoWord : File
    {
        public void GerarDocX()
        {
            // codigo para geracao do arquivo
        }
    }

    public class ArquivoPdf : File
    {
        public void GerarPdf()
        {
            // codigo para geracao do arquivo
        }
    }
}
