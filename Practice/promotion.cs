﻿namespace Practice;

public  class Promotion
{
    
    private string name;
    private int price;
    public Promotion(string name,int price)
    {
        this.name = name;
        this.price = price;
    }
    

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Price
    {
        get { return price; }
        set { price = value; }
    }
}