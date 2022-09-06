# Algoritmos-e-Linguaguem-de-Programas

double salario, porcentagem, novo_salario;
      Console.WriteLine ("Digite o salario: ");
      salario = double.Parse (Console.ReadLine ());
     
      Console.WriteLine ("Digite o percentual: ");
      porcentagem = double.Parse (Console.ReadLine ());
     
      novo_salario = salario * porcentagem/100 + salario;
     
      Console.WriteLine ("Novo salario " + novo_salario );
