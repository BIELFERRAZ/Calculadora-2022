public class Operação
{

    public static double Soma(double parcela1, double parcela2)
    {
        double total = parcela1 + parcela2;
        return total;
    }





    public static double Multiplicacao(double fator1, double fator2)
    {
        double Produto = fator1 * fator2;
        return Produto;
    }
 public static double Divisao(double dividendo, double divisor)
    {
       if (divisor ==0)
       {
           throw new Exception ("Não é possivel dividir por Zero.");
       }
       
        double quociente = dividendo / divisor;
        return quociente;
    }
 public static double Subtracao(double menos1, double menos2)
    {
        double Sub = menos1 - menos2;
        return Sub;
    }
}

        
