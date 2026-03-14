using System.Text;

public class Human
{
    // Propiedades de la clase
    // prop + tab 
    // A partir de ciertas versiones los string se vuelven "nulleables", por lo que es necesario inicializar estos tipos con ""
    public string Name { get; set; } = ""; // Propiedad con sus métodos get y set
                                           // get es para "obtener" el valor de esa propiedad
                                           // y set para "setear/asignar" un valor a la propiedad.
    public int Height { get; set; } // EL ; después del bloque de métodos o de descriptores de acceso no es válido
    public int Weight { get; set; }
    public int Age { get; set; }

    // Métodos de la clase (estos pueden modificar las propiedades)
    // Un método no trabaja con get y set, sebe ser de un tipo y puede o no tener un retorno
    public void ComerMucho()
    {
        Weight += 1000; // gramos aprox. 2 libras
    }
    public void HacerEjercicio()
    {
        Weight -= 1800; // gramos aprox. 4 libras
    }
    public string VerGeneracion() //Todas las partes deben retornar un valor, ya sea la de una estructura de control y la parte general
    {
        if (Age > 50)
        {
            return "ya es mayor";
        } 
        return "\"se encuentra joven aún\""; // \" funciona como comillas dobles dentro del valor de un string normal " " o para el tipo $" "
                                            // Para el caso de @" " o @$" " simplemente duplicas las comillas ""texto"" --> output = "texto"
    }


}