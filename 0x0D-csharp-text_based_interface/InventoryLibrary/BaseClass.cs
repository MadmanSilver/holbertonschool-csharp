using System;

class BaseClass {
    string id;
    DateTime date_created;
    DateTime date_updated;

    public BaseClass() {
        this.id = System.Guid.NewGuid().ToString();
        this.date_created = this.date_updated = DateTime.Now;
    }
}
