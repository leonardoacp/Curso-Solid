using System;
using System.Collections.Generic;

namespace Solid.OpenClosedPrinciple
{
    public class Arquivo
    {

    }

    public class GerarTxt : Arquivo
    {

        public void GerarArquivoTxt() { }
    }

    public class GerarPdf : Arquivo
    {
        public void GerarArquivoPdf() { }
    }


    public class Gerador
    {
        public void GerarArquivo(List<Arquivo> arquivo)
        {
            foreach (var item in arquivo)
            {
                if (item is GerarPdf)
                    ((GerarPdf)item).GerarArquivoPdf();
                else if (item is GerarTxt)
                    ((GerarTxt)item).GerarArquivoTxt();
            }

        }

    }
}


