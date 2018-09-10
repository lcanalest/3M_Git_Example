namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var persona = new Person
      {
        Nombre = "Pepe",
        Apellido = "Roni"
      };

      System.Console.WriteLine("Hola mi nombre es {0} y mi apellido {1}", persona.Nombre, persona.Apellido);
    }
  }
}
