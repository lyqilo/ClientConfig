//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
/*
{name}.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.item
{ 

public sealed partial class Item :  Bright.Config.BeanBase 
{
    public Item(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        PostInit();
    }

    public Item(int id, string name ) 
    {
        this.Id = id;
        this.Name = name;
        PostInit();
    }

    public static Item DeserializeItem(JSONNode _json)
    {
        return new item.Item(_json);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }

    public const int __ID__ = 2107285806;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
