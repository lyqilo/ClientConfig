//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
ItemConfig.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.Item
{ 

public sealed partial class ItemConfig :  Bright.Config.BeanBase 
{
    public ItemConfig(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["type"].IsNumber) { throw new SerializationException(); }  Type = _json["type"]; }
        { if(!_json["icon"].IsString) { throw new SerializationException(); }  Icon = _json["icon"]; }
        { if(!_json["describe"].IsString) { throw new SerializationException(); }  Describe = _json["describe"]; }
        PostInit();
    }

    public ItemConfig(int id, string name, int type, string icon, string describe ) 
    {
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.Icon = icon;
        this.Describe = describe;
        PostInit();
    }

    public static ItemConfig DeserializeItemConfig(JSONNode _json)
    {
        return new Item.ItemConfig(_json);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 名字(这里配置多语言id)
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 类型（1金币，2小喇叭，3实物，4vip等级，5专属客服，6头像，7头像框）
    /// </summary>
    public int Type { get; private set; }
    /// <summary>
    /// 资源名
    /// </summary>
    public string Icon { get; private set; }
    /// <summary>
    /// 描述(多语言id)
    /// </summary>
    public string Describe { get; private set; }

    public const int __ID__ = -336351760;
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
        + "Type:" + Type + ","
        + "Icon:" + Icon + ","
        + "Describe:" + Describe + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}