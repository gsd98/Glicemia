using static System.Console;

/*
 * Listas que estão sendo utilizadas:
 * Paciente que vai armazenar o nome do paciente. Variável do Tipo string;
 * Refeição é pra colocar o nome da refeição o periodo do dia em que foi feita a medição da glicemia.
 * Variável refeição também do tipo string;
 * Glicemia é o valor em mg/dL. Variável do Tipo int.
*/
List<string> paciente = new List<string>();
List<string> refeicao = new List<string>();
List<int> glicemia =  new List<int>();
/*
 * Abaixo vai mostrar a data e hora no momento em que o programa foi aberto. 
*/
var dia2 = DateTime.Now;
WriteLine($"Dia de hoje: {dia2}");
/* Abaixo vai perguntar o nome do Paciente. No momento só consigo registrar 1 paciente por vez, mas
a idéia é registrar no futuro mais de um paciente (talvez tenha alguma forma, mas talvez ainda não
aprendi ainda como fazer já que estou aprendendo ainda).
*/
for (int i = 0; i < 1; i++)
{
    WriteLine("Nome do Paciente:");
    paciente.Add(ReadLine());
}
/* Abaixo vai perguntar quantas vezes o paciente fez a medição de glicemia. Isso é importante saber,
pois isso depende do paciente, alguns vão medir mais vezes outros vão medir menos vezes ao dia.
*/ 
int numgli;
WriteLine("Quantas vezes a glicemia foi medida no dia?");
numgli = Convert.ToInt32(ReadLine());
Clear();
/* Abaixo temos o laço "for" que vai se repetir dependendo de quantas vezes o paciente mediu
a glicemia. O valor foi colocado acima na variável "numgli" vai influenciar na quantidade de refei-
ções e glicemias que o programa vai pedir. No caso vai perguntar a refeição e o valor da glicemia.
*/
for (int i = 0; i < Convert.ToInt32(numgli); i++)
{
    WriteLine($"Digite o {i + 1}º período do dia (Exemplo Almoço):");
    refeicao.Add(ReadLine());
    WriteLine($"Digite Sua {i + 1}ª Glicemia:");
    glicemia.Add(Convert.ToInt32(ReadLine()));
    Clear();
}
// Abaixo temos a variável int valores serve pra definir a posição inicial da lista.
int valores = 0;
/* Abaixo mostra o nome do paciente digitado no inicio do programa, e a refeição com os valores
glicemicos. */ 
WriteLine($"Paciente: {paciente[valores]}");
WriteLine("Suas glicemias no dia foram:");
foreach (int gli2 in glicemia)
{
    WriteLine($"{refeicao[valores]} - {gli2} mg/dL");
    valores++;
}
/* Aqui para saber a média saber o total das glicemias foi necessário criar essa variável de soma e
média. */
int soma = 0;
int media = 0;
foreach (int gli in glicemia)
{
    soma += gli;
}
/* Abaixo é a soma das glicemias do dia dividido pela quantidade de glicemia. Na sequência vai mos-
 trar a media de glicemia naquele dia */
media = soma/numgli;
// Aqui vem as condicionais para saber se a média do dia está alta, normal ou baixa.
WriteLine($"A média de glicemia do dia foi: {media} mg/dL");
if (media >= 180)
{
    WriteLine("A média do dia está alta!");
    
}
else if (media < 80)
{
    WriteLine("A média do dia está baixa!");
}
else
{
    WriteLine("A média do dia está normal!");
}
ReadKey();