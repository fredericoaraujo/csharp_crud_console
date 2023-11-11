namespace Entity;
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateOnly DataNascimento { get; set; }
    public DateTime CadastradoEm { get; set; }
    public DateTime AlteradoEm { get; set; }
    public decimal Desconto { get; set; }

    public override string ToString()
    {
        return @$"
            ID................: {Id}
            Nome..............: {Nome}
            Data de Nascimento: {DataNascimento}
            Desconto..........: {Desconto}%
            Cadastrado Em.....: {CadastradoEm}
            Alterado Em.......: {AlteradoEm}

        ";
    }

}
