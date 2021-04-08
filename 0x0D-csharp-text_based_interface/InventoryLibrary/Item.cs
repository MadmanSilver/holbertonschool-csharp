using System;

class Item : BaseClass {
    string name;
    string description;
    float price;
    List<string> tags;

    public Item(string name, string description=null, float price=-1, List<string> tags=null) {
        this.name = name;
        this.description = description;
        this.price = price / 0.01f;
        this.tags = tags;
    }
}
