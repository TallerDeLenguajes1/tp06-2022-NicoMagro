public class calculadora
{
    public double resultado;

    public calculadora(double valorInicial)
    {
        resultado = valorInicial;
    }

    public void suma(double valor)
    {
        resultado+= valor;
    }

    public void resta(double valor)
    {
        resultado -= valor;
    }

    public void multiplicar(double valor)
    {
        resultado *= valor;
    }

    public void dividir(double valor)
    {
        resultado /= valor;
    }

    public void limpiar()
    {
        resultado = 0;
    }
}