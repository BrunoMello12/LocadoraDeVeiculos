using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    public partial class TelaGerarPdfForm : Form
    {

        private Aluguel aluguelSelecionado;

        public TelaGerarPdfForm(Aluguel aluguelSelecionado)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            this.aluguelSelecionado = aluguelSelecionado;
        }

        private string DefinirNomeArquivo()
        {
            if (rdbLocacao.Checked)
                return $"{aluguelSelecionado.Cliente} - Locação de veículo";

            else return $"{aluguelSelecionado.Cliente} - Devolução de veículo";
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Escolha um diretório para guardar seu PDF");
                DialogResult = DialogResult.None;
                return false;
            }

            if (!rdbLocacao.Checked && !rdbDevolucao.Checked)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Escolha qual opção de PDF à ser gerado");
                DialogResult = DialogResult.None;
                return false;
            }

            return true;
        }

        private void EscreverPdf()
        {
            string nomePdf = DefinirNomeArquivo();

            string caminho = Path.Combine(txtDiretorio.Text, nomePdf + ".pdf");

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 30, 30, 30, 30);
            FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write, FileShare.None);

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            //-------------------------------------------------------------------------------------------------------------------------------------------
            doc.Open();

            BaseColor corPadrao = BaseColor.BLACK;
            BaseColor corValorTotal = new BaseColor(25, 93, 30);

            iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, corPadrao);
            iTextSharp.text.Font fonteSubTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, corPadrao);
            iTextSharp.text.Font fonteInfo = FontFactory.GetFont(FontFactory.HELVETICA, 13, corPadrao);
            iTextSharp.text.Font fonteInfoNegrito = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13, corPadrao);
            LineSeparator lineSeparator = new LineSeparator();

            // Título

            Paragraph titulo = new Paragraph(string.Format($"ALUGUEL DE {aluguelSelecionado.Automovel.ToString().ToUpper()}"), fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" "));

            Paragraph locacao = new Paragraph(string.Format($"INFORMAÇÕES DA LOCAÇÃO"), fonteSubTitulo);
            doc.Add(locacao);

            doc.Add(new Paragraph(" "));

            doc.Add(lineSeparator);

            doc.Add(new Paragraph(" "));

            // Cliente

            Paragraph cliente = new Paragraph(string.Format($"Cliente: {aluguelSelecionado.Cliente}"), fonteInfo);
            doc.Add(cliente);

            // Funcionário

            Paragraph funcionario = new Paragraph(string.Format($"Funcionário: {aluguelSelecionado.Funcionario}"), fonteInfo);
            doc.Add(funcionario);

            // Condutor

            Paragraph condutor = new Paragraph(string.Format($"Condutor: {aluguelSelecionado.Condutor}"), fonteInfo);
            doc.Add(condutor);

            doc.Add(new Paragraph(" "));

            // Datas

            Paragraph dataLocação = new Paragraph(string.Format($"Data de locação: {aluguelSelecionado.DataLocacao}"), fonteInfo);
            doc.Add(dataLocação);

            Paragraph dataDevolução = new Paragraph(string.Format($"Devolução Prevista: {aluguelSelecionado.DevolucaoPrevista}"), fonteInfo);
            doc.Add(dataDevolução);

            doc.Add(new Paragraph(" "));

            // Automóvel

            Paragraph automovel = new Paragraph(string.Format($"Automóvel: {aluguelSelecionado.Automovel}, {aluguelSelecionado.GrupoAutomoveis}"), fonteInfo);
            doc.Add(automovel);

            Paragraph automovelKm = new Paragraph(string.Format($"Km do automóvel: {aluguelSelecionado.KmAutomovel}"), fonteInfo);
            doc.Add(automovelKm);

            doc.Add(new Paragraph(" "));

            // Plano de cobrança 

            Paragraph plano = new Paragraph(string.Format($"Plano de Cobrança: {aluguelSelecionado.Cobranca}"), fonteInfo);
            doc.Add(plano);

            // Cupom

            Paragraph cupom = new Paragraph(string.Format($"Cupom: {aluguelSelecionado.Cupom}"), fonteInfo);
            doc.Add(cupom);

            doc.Add(new Paragraph(" "));

            //Taxas selecionadas

            Paragraph taxasSelecionadas = new Paragraph(string.Format($"Taxas Selecionadas:"), fonteInfo);
            doc.Add(taxasSelecionadas);

            //aluguelSelecionado.taxasSelecionadas.ForEach(t =>
            //{
            //    Paragraph taxa = new Paragraph(string.Format($"-> {t}"), fonteInfo);
            //    doc.Add(taxa);
            //});

            doc.Add(new Paragraph(" "));

            // Valor total

            Paragraph valorPrevisto = new Paragraph(string.Format($"Valor total previsto: R$ {aluguelSelecionado.ValorTotalPrevisto}"), fonteInfoNegrito);
            doc.Add(valorPrevisto);

            doc.Add(new Paragraph(" "));

            if (rdbDevolucao.Checked)
            {
                Paragraph devolucao = new Paragraph(string.Format($"INFORMAÇÕES DA DEVOLUÇÃO"), fonteSubTitulo);
                doc.Add(devolucao);

                doc.Add(new Paragraph(" "));

                doc.Add(lineSeparator);

                doc.Add(new Paragraph(" "));

                //Paragraph kmPercorrido = new Paragraph(string.Format($"Km percorrido: {aluguelSelecionado.kmPercorrido}"), fonteInfo);
                //doc.Add(kmPercorrido);

                //Paragraph nivelTanque = new Paragraph(string.Format($"Nível do tanque: {aluguelSelecionado.nivelTanque}"), fonteInfo);
                //doc.Add(nivelTanque);

                doc.Add(new Paragraph(" "));

                Paragraph taxasAdcionais = new Paragraph(string.Format($"Taxas Adicionais:"), fonteInfo);
                doc.Add(taxasAdcionais);

                //aluguelSelecionado.taxasAdicionais.ForEach(t =>
                //{
                //    Paragraph taxa = new Paragraph(string.Format($"-> {t}"), fonteInfo);
                //    doc.Add(taxa);
                //});

                doc.Add(new Paragraph(" "));

                //Paragraph valorTotal = new Paragraph(string.Format($"Valor total: R$ {aluguelSelecionado.ValorTotal}"), fonteInfoNegrito);
                //doc.Add(valorTotal);
            }

            doc.Close();
            //-------------------------------------------------------------------------------------------------------------------------------------------
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = fbd.SelectedPath;
            }

            DialogResult = DialogResult.None;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                EscreverPdf();
                MessageBox.Show($"PDF gerado com sucesso! Confira no caminho: \n{txtDiretorio.Text}");
            }
        }
    }
}
