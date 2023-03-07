namespace Ejecicio2
{
  
  class Automovil{

    string id;
    string marca;
    string modelo;
    int km;
    double precio;

    public override string ToString(){
      return $"ID: {id}, Marca: {marca}, Modelo {modelo}, KM: {km}, Precio: {precio}";
    }  
  }
}