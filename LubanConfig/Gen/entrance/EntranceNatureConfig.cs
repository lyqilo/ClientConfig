//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
EntranceNatureConfig.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.entrance
{ 

public sealed partial class EntranceNatureConfig :  Bright.Config.BeanBase 
{
    public EntranceNatureConfig(JSONNode _json) 
    {
        { if(!_json["ID"].IsNumber) { throw new SerializationException(); }  ID = _json["ID"]; }
        { if(!_json["sort"].IsNumber) { throw new SerializationException(); }  Sort = _json["sort"]; }
        { if(!_json["entranceName"].IsString) { throw new SerializationException(); }  EntranceName = _json["entranceName"]; }
        { var __json0 = _json["area"]; if(!__json0.IsArray) { throw new SerializationException(); } Area = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  Area.Add(__v0); }   }
        PostInit();
    }

    public EntranceNatureConfig(int ID, int sort, string entranceName, System.Collections.Generic.List<int> area ) 
    {
        this.ID = ID;
        this.Sort = sort;
        this.EntranceName = entranceName;
        this.Area = area;
        PostInit();
    }

    public static EntranceNatureConfig DeserializeEntranceNatureConfig(JSONNode _json)
    {
        return new entrance.EntranceNatureConfig(_json);
    }

    /// <summary>
    /// ID
    /// </summary>
    public int ID { get; private set; }
    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; private set; }
    /// <summary>
    /// 入口名
    /// </summary>
    public string EntranceName { get; private set; }
    /// <summary>
    /// 区域，多区域用“，”分隔
    /// </summary>
    public System.Collections.Generic.List<int> Area { get; private set; }

    public const int __ID__ = 468436215;
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
        + "ID:" + ID + ","
        + "Sort:" + Sort + ","
        + "EntranceName:" + EntranceName + ","
        + "Area:" + Bright.Common.StringUtil.CollectionToString(Area) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
