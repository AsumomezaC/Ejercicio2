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

      if(a != null){
        if(noAutosActual != limiteAutomoviles){
          Automovil? autoEncontrado = listaAutomovil.Find((b) => b.id == a.id);
          if(autoEncontrado == null){
            listaAutomovil.Add(a);
           noAutosActual++;
          }
        }
      }
    }

    public void MostrarAuto(string id){

      if(id != null){
        Automovil? autoEncontrado = listaAutomovil.Find((a)=> a.id==id);
        if(autoEncontrado != null){
          Console.WriteLine(autoEncontrado.ToString());
          return;
        }
      }

      // Si no se encontro el auto 
        Console.WriteLine("El automovil buscado no se encuentra en la concessionaria");
      }

      public void EliminarAuto(string id){

      if(id != "" && noAutosActual != 0){
        Automovil? autoEcontrado = listaAutomovil.Find((a)=> a.id == id);
        if(autoEcontrado != null){
          listaAutomovil.Remove(autoEcontrado);
          noAutosActual--;
        }
      }
    }

    public void MostrarAutos(){

      foreach(Automovil item in listaAutomovil){
          Console.WriteLine(item.ToString());
	    }     
    }
    public void VaciarConcesionaria(){
      listaAutomovil = new List<Automovil>();
      noAutosActual = 0;
    }
  }
}