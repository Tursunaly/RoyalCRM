
carrotFactory carrotFactory = new carrotFactory();

carrotFactory.makePlant();
carrotFactory.buildFactory("Морковь");



interface IPlant
{
    public void Grow();
}
interface IPlantFactory
{
    public IPlant makePlant();
}
class Factory
{
    public static Factory instance;
    public string name;
    public Factory(string name)
    {
        this.name = name;
    }

    public static Factory factory(string sing)
    {
        if(instance == null)
        {
            instance = new Factory(sing);
            return instance;
        }
        else{
            return instance;
        }
    }
}

//Фабрики
class carrotFactory : IPlantFactory
{
    public Factory carrot;

    public IPlant makePlant() {
        if (carrot != null) {
            System.Console.WriteLine($"{carrot.name} растёт...");

            return new carrot();
        }
        else {
            throw new Exception("Не создана фабркиа по проивзодству морковки!");
        }
    }

    public void buildFactory(string name) {
        carrot = Factory.factory(name);
    }

}
class potatoFactory : IPlantFactory
{
    public Factory potato;

    public IPlant makePlant() {
        if (potato != null) {
            System.Console.WriteLine($"{potato.name} растёт...");

            return new potato(); 
        }
        else {
            throw new Exception("Не создана фабркиа по проивзодству морковки!");
        }
    }

    public void buildFactory(string name) {
        potato = Factory.factory(name);
    }

}
class tomatoFactory :  IPlantFactory
{
    public Factory tomato;

    public IPlant makePlant() {
        if (tomato != null) {
            System.Console.WriteLine($"{tomato.name} растёт...");
            return new tomato();
        }
        else {
            throw new Exception("Не создана фабркиа по проивзодству морковки!");
        }
    }

    public void buildFactory(string name) {
        tomato = Factory.factory(name);
    }
   
}


class carrot : IPlant
{
    public void Grow() {
        System.Console.WriteLine("Растёт! ");
    }
}
class potato : IPlant
{
    public void Grow() {
        System.Console.WriteLine("Растёт!");
    }
}
class tomato : IPlant
{
    public void Grow() {
        System.Console.WriteLine("Растёт!");
    }
}
