Console.WriteLine("ingrese un mes en su forma numerica");
var FechaNum= int.Parse (Console.ReadLine());

if (FechaNum >= 1 && FechaNum <= 12)
{
    string FechaL = convertirfecha(FechaNum);
    Console.WriteLine($"{FechaL} equivale a {FechaNum} ");
    
}

string convertirfecha(int fechaNum)
{
    string mes = "";
    switch (FechaNum)
    {
        case 1:
            mes = "Enero";
            break;

        case 2:
            mes = "Febrero";
            break;

        case 3:
            mes = "Marzo";
            break;

        case 4:
            mes = "Abril";
            break;

        case 5:
            mes = "Mayo";
            break;

        case 6:
            mes = "Junio";
            break;

        case 7:
            mes = "Julio";
            break;

        case 8:
            mes = "Agosto";
            break;

        case 9:
            mes = "Septiembre";
            break;

        case 10:
            mes = "Octubre";
            break;

        case 11:
            mes = "Noviembre";
            break;

        case 12:
            mes = "Diciembre";
            break;
    }
    return mes;
}
Console.WriteLine("nano gey");