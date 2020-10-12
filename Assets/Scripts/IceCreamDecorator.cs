public class IceCreamDecorator : iIceCream
{
    protected iIceCream m_DecoIceCream;

    public IceCreamDecorator(iIceCream iceCream)
    {
        m_DecoIceCream = iceCream;
    }

    public virtual int getScoops() { return m_DecoIceCream.getScoops(); }
    public virtual string getFlavor() { return m_DecoIceCream.getFlavor(); }
    public virtual string getTopping() { return m_DecoIceCream.getTopping(); }
    public virtual float getPrice() { return m_DecoIceCream.getPrice(); }
}

public class sOne : IceCreamDecorator
{
    int scoops = 1;

    public sOne(iIceCream iceCream) : base(iceCream) { }

    public override int getScoops()
    {
        return scoops;
    }
    public override float getPrice()
    {
        return base.getPrice() + (float)scoops;
    }
}

public class sTwo : IceCreamDecorator
{
    int scoops = 2;

    public sTwo(iIceCream iceCream) : base(iceCream) { }

    public override int getScoops()
    {
        return scoops;
    }
    public override float getPrice()
    {
        return base.getPrice() + (float)scoops;
    }
}

public class fVanilla : IceCreamDecorator
{
    string flavor = "Vanilla";
    float price = 5.0f;

    public fVanilla(iIceCream iceCream) : base(iceCream) { }

    public override string getFlavor()
    {
        return flavor;
    }
    public override float getPrice()
    {
        return base.getPrice() + price;
    }
}

public class fChocolate : IceCreamDecorator
{
    string flavor = "Chocolate";
    float price = 6.0f;

    public fChocolate(iIceCream iceCream) : base(iceCream) { }

    public override string getFlavor()
    {
        return flavor;
    }
    public override float getPrice()
    {
        return base.getPrice() + price;
    }
}
public class fStrawberry : IceCreamDecorator
{
    string flavor = "Strawberry";
    float price = 4.0f;

    public fStrawberry(iIceCream iceCream) : base(iceCream) { }

    public override string getFlavor()
    {
        return flavor;
    }
    public override float getPrice()
    {
        return base.getPrice() + price;
    }
}

public class tSprinkles : IceCreamDecorator
{
    string topping = "Sprinkles";
    float price = .25f;

    public tSprinkles(iIceCream iceCream) : base(iceCream) { }

    public override string getTopping()
    {
        return topping;
    }
    public override float getPrice()
    {
        return base.getPrice() + price;
    }
}
public class tChocDrizzle : IceCreamDecorator
{
    string topping = "Chocolate Drizzle";
    float price = .50f;

    public tChocDrizzle(iIceCream iceCream) : base(iceCream) { }

    public override string getTopping()
    {
        return topping;
    }
    public override float getPrice()
    {
        return base.getPrice() + price;
    }
}