public class VehiculoElectrico : Vehiculo, IVehiculoElectrico, ITransporte
{
    public int Bateria { get; set; }

    public override void Moverse()
    {
        MessageBox.Show($"El vehiculo electrico {Marca}, {Modelo} cuenta con un porcentaje  {Bateria} ");
    }
    public override void Detener()
    {
        MessageBox.Show($"El vehiculo electrico {Marca}, {Modelo} se detuvo");
    }

    public override string ToString()
    {
        return $" {Marca} , {Modelo}, con {Bateria}% de bateria  ";
    }
}
