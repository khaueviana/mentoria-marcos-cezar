# Encontro #3

- Refatoramos alguns códigos no exemplo de C# Win Forms + POO da apostila da Caelum.

- Remoção dos Usings não utilizados

- Remoção de referências desnecessárias ao "this"

- Remoção de código comentado desnecessário, caso precise recuperar algum código, só utilizar o controle de versão GIT.

- Foram explanados com maiores detalhes alguns conceitos de POO já desenvolvidos pelo Marcos no projeto.

**Overload (Sobrecarga)**

    public void Transferir()
    {
    var x = 10;
    }
    
    public void Transferir(int y)
    {
    var x = 10;
    }
    
    public int Transferir(string x)
    {
    var y = 0;
    
    return y;
    
    }
    
    private void test()
    {
    Transferir("x");
    
    Transferir();
    
    Transferir(1);
    
    }

**Override (Sobrescrita)**

    public virtual int Movimentar()
    {
    return 10;
    }
    
    public override int Movimentar()
    {
    return 20;
    }

**Herança**
**Polimorfismo**
**Classe Abstrata**
**Interface**

Recurso bacana do C# para dar uma olhada:
[Pattern Matching](http://netcoders.com.br/csharp-7-pattern-matching/)