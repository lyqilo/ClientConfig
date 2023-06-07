//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
LanguageConfig.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.global
{ 

public sealed partial class LanguageConfig :  Bright.Config.BeanBase 
{
    public LanguageConfig(JSONNode _json) 
    {
        { if(!_json["id"].IsString) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["show"].IsString) { throw new SerializationException(); }  Show = _json["show"]; }
        PostInit();
    }

    public LanguageConfig(string id, string show ) 
    {
        this.Id = id;
        this.Show = show;
        PostInit();
    }

    public static LanguageConfig DeserializeLanguageConfig(JSONNode _json)
    {
        return new global.LanguageConfig(_json);
    }

    /// <summary>
    /// 语言
    /// </summary>
    public string Id { get; private set; }
    /// <summary>
    /// 语言显示
    /// </summary>
    public string Show { get; private set; }

    public const int __ID__ = -1337596283;
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
        + "Show:" + Show + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}