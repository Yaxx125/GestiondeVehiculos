using GestiondeVehiculos;

public class Auto : Vehiculo, ITransporte
{
    public override void Moverse()
    {
        MessageBox.Show($"El auto {Marca} {Modelo}, manubreando.");
    }
    public override void Detener()
    {
        MessageBox.Show($"El auto {Marca} {Modelo} se detuvo.");
    }
    public override string ToString()
    {
        return $"{Marca}, {Modelo}";
    }
}

   
