//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
LaunchConfig.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.launch
{ 

public sealed partial class LaunchConfig :  Bright.Config.BeanBase 
{
    public LaunchConfig(JSONNode _json) 
    {
        { if(!_json["ID"].IsNumber) { throw new SerializationException(); }  ID = _json["ID"]; }
        { var __json0 = _json["DNS"]; if(!__json0.IsArray) { throw new SerializationException(); } DNS = new System.Collections.Generic.List<string>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { string __v0;  { if(!__e0.IsString) { throw new SerializationException(); }  __v0 = __e0; }  DNS.Add(__v0); }   }
        { if(!_json["Auth"].IsString) { throw new SerializationException(); }  Auth = _json["Auth"]; }
        { if(!_json["LaunchPackageName"].IsString) { throw new SerializationException(); }  LaunchPackageName = _json["LaunchPackageName"]; }
        { if(!_json["LobbyPackageName"].IsString) { throw new SerializationException(); }  LobbyPackageName = _json["LobbyPackageName"]; }
        { if(!_json["GamePackageName"].IsString) { throw new SerializationException(); }  GamePackageName = _json["GamePackageName"]; }
        { if(!_json["ScriptResName"].IsString) { throw new SerializationException(); }  ScriptResName = _json["ScriptResName"]; }
        { if(!_json["LaunchResName"].IsString) { throw new SerializationException(); }  LaunchResName = _json["LaunchResName"]; }
        { if(!_json["VideoName"].IsString) { throw new SerializationException(); }  VideoName = _json["VideoName"]; }
        { if(!_json["Language"].IsString) { throw new SerializationException(); }  Language = _json["Language"]; }
        { if(!_json["platformId"].IsNumber) { throw new SerializationException(); }  PlatformId = _json["platformId"]; }
        PostInit();
    }

    public LaunchConfig(int ID, System.Collections.Generic.List<string> DNS, string Auth, string LaunchPackageName, string LobbyPackageName, string GamePackageName, string ScriptResName, string LaunchResName, string VideoName, string Language, int platformId ) 
    {
        this.ID = ID;
        this.DNS = DNS;
        this.Auth = Auth;
        this.LaunchPackageName = LaunchPackageName;
        this.LobbyPackageName = LobbyPackageName;
        this.GamePackageName = GamePackageName;
        this.ScriptResName = ScriptResName;
        this.LaunchResName = LaunchResName;
        this.VideoName = VideoName;
        this.Language = Language;
        this.PlatformId = platformId;
        PostInit();
    }

    public static LaunchConfig DeserializeLaunchConfig(JSONNode _json)
    {
        return new launch.LaunchConfig(_json);
    }

    /// <summary>
    /// ID
    /// </summary>
    public int ID { get; private set; }
    /// <summary>
    /// 域名
    /// </summary>
    public System.Collections.Generic.List<string> DNS { get; private set; }
    /// <summary>
    /// 授权码
    /// </summary>
    public string Auth { get; private set; }
    /// <summary>
    /// 大厅更新包
    /// </summary>
    public string LaunchPackageName { get; private set; }
    /// <summary>
    /// 大厅更新包
    /// </summary>
    public string LobbyPackageName { get; private set; }
    /// <summary>
    /// 游戏更新包
    /// </summary>
    public string GamePackageName { get; private set; }
    /// <summary>
    /// 脚本资源名
    /// </summary>
    public string ScriptResName { get; private set; }
    /// <summary>
    /// 启动资源更新包
    /// </summary>
    public string LaunchResName { get; private set; }
    /// <summary>
    /// 启动视频
    /// </summary>
    public string VideoName { get; private set; }
    /// <summary>
    /// 默认语言
    /// </summary>
    public string Language { get; private set; }
    /// <summary>
    /// 包Id
    /// </summary>
    public int PlatformId { get; private set; }

    public const int __ID__ = -1751845040;
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
        + "DNS:" + Bright.Common.StringUtil.CollectionToString(DNS) + ","
        + "Auth:" + Auth + ","
        + "LaunchPackageName:" + LaunchPackageName + ","
        + "LobbyPackageName:" + LobbyPackageName + ","
        + "GamePackageName:" + GamePackageName + ","
        + "ScriptResName:" + ScriptResName + ","
        + "LaunchResName:" + LaunchResName + ","
        + "VideoName:" + VideoName + ","
        + "Language:" + Language + ","
        + "PlatformId:" + PlatformId + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
