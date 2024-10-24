using GestiondeVehiculos;

public class Camión : Vehiculo, ITransporte
{
    public int CapacidadCarga { get; set; }

    public override void Moverse()
    {
        MessageBox.Show($"El camión cuenta con {CapacidadCarga} kilogramos, esta listo para arranacar.");
    }

    public override void Detener()
    {
        MessageBox.Show($"El camión {Marca} {Modelo} se detuvo");
    }

    public override string ToString()
    {
        return $"{Marca}, {Modelo}, con capacidad de carga de {CapacidadCarga} Kg";
    }
}

