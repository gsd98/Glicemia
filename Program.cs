using static System.Console;
using static System.Convert;


WriteLine("Nome do Paciente:");
ReadLine();
WriteLine("Idade do Paciente:");
ReadLine();
WriteLine("Cidade e Estado aonde reside:");
ReadLine();
int n1;
WriteLine("Digite Sua Glicemia:");
n1 = ToInt32(ReadLine());
if (n1 >= 200)
{
    WriteLine("Sua Glicemia está Alta! Tome Insulina!");
}
else
{
    if (n1 < 80)
    {
        WriteLine("Sua Glicemia está Baixa! Coma açúcar para estabilizar!");
    }
    else
    WriteLine("Sua Glicemia está Normal! Continue se cuidando!");
}
ReadKey();



