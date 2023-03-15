using CV6;

double area = 0; //inicializace proměnných
double surface = 0;
double volume = 0;

GrObject[] test = new GrObject[]
{
new Circle(5), //vytvoření instancí tříd s parametry
new Rectangle(5, 3),
new Ellipse(5, 8),
new Triangle(8, 13),
new Block(4, 5, 6),
new Cylinder(5, 20),
new Sphere(15),
new Pyramid(15, 25, 13)
};

foreach (GrObject obj in test) //cyklus který projde každž objekt z pole objketů test, podmínka zjistí, zda je objekt 2D nebo 3D a potom spočítá obsah potažmo objem
{
    obj.Draw(); //zavolání metody Kresli
    if (obj is Object2D)
    {
        area += ((Object2D)obj).CalculateSurface();
    }
    else if (obj is Object3D) 
    {
        surface += ((Object3D)obj).CalculateSurface();
        volume += ((Object3D)obj).CalculateVolume();
    }
}

Console.WriteLine($""); //výpis požadovaných údajů
Console.WriteLine($"Area of all 2D objects: {area}");
Console.WriteLine($"Surface of all 3D objects: {surface}");
Console.WriteLine($"Volume of all 3D objects: {volume}");