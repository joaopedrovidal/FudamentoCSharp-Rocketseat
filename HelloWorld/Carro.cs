namespace HelloWorld;

class Carro
{
    public required string modelo {  get; set; }
    public DateOnly lancadoEm {  get; set; }
    public Cor cor { get; set; }

    public void ExibeNomeDoModelo() => Console.WriteLine(modelo);

    public Carro(string modelo, DateOnly lancadoEm, Cor cor)
    {
        this.modelo = modelo;
        this.lancadoEm = lancadoEm;
        this.cor = cor;
    }

    public void Ligar()
    {
        Console.WriteLine("O carro ligou.");
    }
    public void Desligar()
    {
        Console.WriteLine("O carro desligou.");
    }
}
