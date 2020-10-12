using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    iIceCream currentIceCream;

    public int numScoops;
    public string flavor;
    public string topping;
    public float price;


    public Dropdown FlavorDrpDwn;
    public Dropdown ScoopDrpDwn;
    public Dropdown ToppingDrpDwn;

    public Text iceCreamMade; 
    
    public void ButtonPress()
    {
        if(FlavorDrpDwn.value == 0)
        {
            currentIceCream = new fVanilla(currentIceCream);
            flavor = currentIceCream.getFlavor();
        }
        else if(FlavorDrpDwn.value == 1)
        {
            currentIceCream = new fChocolate(currentIceCream);
            flavor = currentIceCream.getFlavor();
        }
        else
        {
            currentIceCream = new fStrawberry(currentIceCream);
            flavor = currentIceCream.getFlavor();
        }

        if (ScoopDrpDwn.value == 0)
        {
            currentIceCream = new sOne(currentIceCream);
            numScoops = currentIceCream.getScoops();
        }
        else
        {
            currentIceCream = new sTwo(currentIceCream);
            numScoops = currentIceCream.getScoops();
        }

        if (ToppingDrpDwn.value == 0)
        {
            currentIceCream = new tSprinkles(currentIceCream);
            topping = currentIceCream.getTopping();
        }
        else
        {
            currentIceCream = new tChocDrizzle(currentIceCream);
            topping = currentIceCream.getTopping();
        }

        IceCreamSpecs specs = new IceCreamSpecs();
        specs.flavor = currentIceCream.getFlavor();
        specs.scoops = currentIceCream.getScoops();
        specs.topping = currentIceCream.getTopping();

        iIceCream iceCream = GetIceCream(specs);
        iceCreamMade.text = iceCream.ToString() + " Cost: $" + iceCream.getPrice().ToString("F2");
    }

    public static iIceCream GetIceCream(IceCreamSpecs specs)
    {
        IceCreamFactory factory = new IceCreamFactory(specs);
        return factory.Create();
    }
}

