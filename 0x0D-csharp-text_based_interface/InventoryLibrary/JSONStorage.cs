using System;
using System.Text.Json;

class JSONStorage {
    Dictionary<string, BaseClass> objects;

    Dictionary<string, BaseClass> All() {
        return objects;
    }

    void New(BaseClass obj) {
        objects[$"{obj.GetType().name}.{obj.id}"] = obj;
    }

    void Save() {
        File.WriteAllText("storage/inventory_manager.json", JsonSerializer.Serialize(objects));
    }

    void Load() {
        objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(File.ReadAllText("storage/inventory_manager.json"));
    }
}