namespace Ejercicio2{

  class Menu{

    Concesionaria concesionaria = new Concesionaria(10);
    public bool ShowMenu(){
      Console.Clear();
      Console.WriteLine("Selecciona una opcion:");
      Console.WriteLine("1.- Agregar Automóvil");
      Console.WriteLine("2.- Eliminar Automóvil");
      Console.WriteLine("3.- Buscar Automóvil");
      Console.WriteLine("4.- Listar todos");
      Console.WriteLine("5.- Salir");
      Console.Write("Opción: ");

      switch(Console.ReadLine()){
        case "1":
          AgregarAutomovil();
          Console.ReadLine();
          return true;
        case "2":
          Console.WriteLine("Seleccionaste 2");
          Console.ReadLine();
          return true;
        case "3":
          Console.WriteLine("Seleccionaste 3");
          Console.ReadLine();
          return true;
        case "4":
          Console.WriteLine("Seleccionaste 4");
          Console.ReadLine();
          return true;
        case "5":
          return false;
        default:
          return true;
      }
    }

    public void AgregarAutomovil(){

      Console.Clear();
      Console.WriteLine("Creando nuevo automóvil...");

      Console.Write("ID: ");
      string? id = Console.ReadLine();

      Console.Write("Marca: ");
      string? marca = Console.ReadLine();

      Console.Write("Modelo: ");
      string? modelo = Console.ReadLine();

      Console.Write("KM: ");
      string? km = Console.ReadLine();

      Console.Write("Precio: ");
      string? precio = Console.ReadLine();

      Automovil nuevo = new Automovil(id, marca, modelo, int.Parse(km), double.Parse(precio));
      concesionaria.AgregarAuto(nuevo);
      Console.WriteLine("Automovil agregado correctamente.");
    }
  }
}