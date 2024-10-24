public abstract class Vehiculo
    {
        public string Marca {  get; set; }
     
        public string Modelo { get; set; }

        public virtual void Iniciar()
        {
            MessageBox.Show($"El vehiculo {Marca} {Modelo}, esta listo. ");
        }

        public abstract void Moverse();

        public abstract void Detener();     
        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}";
        }
    }
