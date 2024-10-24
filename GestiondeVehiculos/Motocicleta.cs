using GestiondeVehiculos;

public sealed class Motocicleta : Vehiculo, ITransporte
{

    public override void Moverse()
    {
        MessageBox.Show($"La motocicleta {Marca} {Modelo} esta en marcha (brummmm, brummmm).");
    }
    public override void Detener()
    {
        MessageBox.Show($"la motocicleta {Marca} {Modelo} se detuvo.");
    }

    public override string ToString()
    {
        return $"{Marca}, {Modelo}";
    }
}
