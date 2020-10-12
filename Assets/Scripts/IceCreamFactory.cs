using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iIceCreamFactory
{
    iIceCream Create(IceCreamSpecs specs);
}

public class VanillaFactory : iIceCreamFactory
{
    public iIceCream Create(IceCreamSpecs specs)
    {
        if(specs.scoops == 1)
        {
            if (specs.topping == "Sprinkles")
                return new OneScoopVanillaSprinkles();
            else
                return new OneScoopVanillaChocolateDrizzle();
        }
        else
        {
            if (specs.topping == "Sprinkles")
                return new TwoScoopsVanillaSprinkles();
            else
                return new TwoScoopsVanillaChocolateDrizzle();
        }
    }
}

public class ChocolateFactory : iIceCreamFactory //shout out to my boy Charlie
{
    public iIceCream Create(IceCreamSpecs specs)
    {
        if (specs.scoops == 1)
        {
            if (specs.topping == "Sprinkles")
                return new OneScoopChocolateSprinkles();
            else
                return new OneScoopChocolateChocolateDrizzle();
        }
        else
        {
            if (specs.topping == "Sprinkles")
                return new TwoScoopsChocolateSprinkles();
            else
                return new TwoScoopsChocolateChocolateDrizzle();
        }
    }
}

public class StrawberryFactory : iIceCreamFactory //shout out to my boy Charlie
{
    public iIceCream Create(IceCreamSpecs specs)
    {
        if (specs.scoops == 1)
        {
            if (specs.topping == "Sprinkles")
                return new OneScoopStrawberrySprinkles();
            else
                return new OneScoopStrawberryChocolateDrizzle();
        }
        else
        {
            if (specs.topping == "Sprinkles")
                return new TwoScoopsStrawberrySprinkles();
            else
                return new TwoScoopsStrawberryChocolateDrizzle();
        }
    }
}
