using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iIceCream
{
    int getScoops();
    string getFlavor();
    string getTopping();
    float getPrice();
}
public class DefaultIceCream : iIceCream 
{
    float m_DefaultPrice = 0.0f;
    int scoops = 0;
    string flavor = "nothing";
    string topping = "none";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_DefaultPrice; }
}

//Vanilla
public class OneScoopVanillaSprinkles : iIceCream
{
    float m_Price = 5.25f;
    int scoops = 1;
    string flavor = "Vanilla";
    string topping = "Sprinkles";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class TwoScoopsVanillaSprinkles : iIceCream
{
    float m_Price = 6.25f;
    int scoops = 2;
    string flavor = "Vanilla";
    string topping = "Sprinkles";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class OneScoopVanillaChocolateDrizzle : iIceCream
{
    float m_Price = 5.50f;
    int scoops = 1;
    string flavor = "Vanilla";
    string topping = "Chocolate Drizzle";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class TwoScoopsVanillaChocolateDrizzle : iIceCream
{
    float m_Price = 6.50f;
    int scoops = 2;
    string flavor = "Vanilla";
    string topping = "Chocolate Drizzle";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}

//Chocolate
public class OneScoopChocolateSprinkles : iIceCream
{
    float m_Price = 6.25f;
    int scoops = 1;
    string flavor = "Chocolate";
    string topping = "Sprinkles";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class TwoScoopsChocolateSprinkles : iIceCream
{
    float m_Price = 7.25f;
    int scoops = 2;
    string flavor = "Chocolate";
    string topping = "Sprinkles";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class OneScoopChocolateChocolateDrizzle : iIceCream
{
    float m_Price = 6.50f;
    int scoops = 1;
    string flavor = "Chocolate";
    string topping = "Chocolate Drizzle";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class TwoScoopsChocolateChocolateDrizzle : iIceCream
{
    float m_Price = 7.50f;
    int scoops = 2;
    string flavor = "Chocolate";
    string topping = "Chocolate Drizzle";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}

//Strawberry
public class OneScoopStrawberrySprinkles : iIceCream
{
    float m_Price = 4.25f;
    int scoops = 1;
    string flavor = "Strawberry";
    string topping = "Sprinkles";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class TwoScoopsStrawberrySprinkles : iIceCream
{
    float m_Price = 5.25f;
    int scoops = 2;
    string flavor = "Strawberry";
    string topping = "Sprinkles";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class OneScoopStrawberryChocolateDrizzle : iIceCream
{
    float m_Price = 4.50f;
    int scoops = 1;
    string flavor = "Strawberry";
    string topping = "Chocolate Drizzle";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}
public class TwoScoopsStrawberryChocolateDrizzle : iIceCream
{
    float m_Price = 5.50f;
    int scoops = 2;
    string flavor = "Strawberry";
    string topping = "Chocolate Drizzle";
    public int getScoops() { return scoops; }
    public string getFlavor() { return flavor; }
    public string getTopping() { return topping; }
    public float getPrice() { return m_Price; }
}

public abstract class AbstractIceCreamFactory
{
    public abstract iIceCream Create();
}

public class IceCreamFactory : AbstractIceCreamFactory
{
    private readonly iIceCreamFactory _factory;
    private readonly IceCreamSpecs _specs;

    public IceCreamFactory(IceCreamSpecs specs)
    {
        if (specs.flavor == "Vanilla")
            _factory = new VanillaFactory();
        else if (specs.flavor == "Chocolate")
            _factory = new ChocolateFactory();
        else
            _factory = new StrawberryFactory();

        _specs = specs;
    }

    public override iIceCream Create()
    {
        return _factory.Create(_specs);
    }
}