namespace CadastroFotos.Models
{
    public class FotosViewModel : PadraoViewModel
    {
        public int Id { get; set; }
        public string Local {  get; set; }
        public DateTime DiaFoto { get; set; }
        //até tres fotos de viagem (ao menos uma obrigatoria)
        public DateTime DiaInserido { get; set; }
        public DateTime DiaEditado { get; set; }
    }
}
