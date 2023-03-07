namespace Ejecicio2{

  class Concesionario{

    List<Automovil> listaAutomovil;
    int limiteAutomoviles;
    int noAutosActual;

    public Concesionario(int limiteAutomoviles){

      listaAutomovil = new List<Automovil>();
      this.limiteAutomoviles = limiteAutomoviles;
      noAutosActual = 0;
    }

    public void AgregarAuto(Automovil a){

      listaAutomovil.Add(a);
    }

    public void MostrarAuto(Automovil a){
      foreach(Automovil item in listaAutomovil){

		    if(item == a){
          Console.WriteLine(item);
          return; //evita imprimir el mensaje que no se encontro el auto
        }
	    }

      // Si no se encontro el auto 
      Console.WriteLine("El automovil buscado no se encuentra en la concessionaria");
    }

    public void EliminarAuto(Automovil a){

        foreach(Automovil item in listaAutomovil){

          if(item == a){
            listaAutomovil.Remove(item);
            return; //evita imprimir el mensaje que no se encontro el auto
          }
        }

        // Si no se encontro el auto 
      Console.WriteLine("El automovil no se encuentra en la concessionaria");
    }

    public void MostrarAutos(){

      foreach(Automovil item in listaAutomovil){
          Console.WriteLine(item);
	    }     
    }
    public void VaciarConcesionaria(){
      listaAutomovil = new List<Automovil>();
    }
  }
}