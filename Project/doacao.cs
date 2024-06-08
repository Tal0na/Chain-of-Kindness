class Doacao {
  //variables
  private float dinheiro, dinheiroTotal;
  private int intInput;

  //constructor
  public Doacao(float dinheiro, int intInput)
  {
      this.dinheiro = DN;
      this.intInput = II;
      this.dinheiroTotal = DT;
  }

  //getset
  public float DN
  {
      get { return dinheiro; }
      set { dinheiro = value; }
  }
  public int II 
  { 
      get { return intInput; }
      set {  intInput = value; }
  }
  public float DT
  {
      get { return dinheiroTotal; }
      set { dinheiroTotal = value; }
  }

  //methods
  public void doarDinheiro(float DN)
  {
      Console.WriteLine("Qual a quantia de dinheiro que você deseja doar?")
          II = Convert.ToInt32(Console.ReadLine());
      if (II > 0) {
          DN = II;
          Console.WriteLine("Você doou ${0} reais. Muito Obrigado!", DN);
      }else
     Console.WriteLine("Opção inválida. Tente novamente");
  }
}