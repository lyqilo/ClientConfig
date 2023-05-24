//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.launch
{
public sealed partial class LaunchConfig :  Bright.Config.BeanBase 
{
    public LaunchConfig(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);DNS = new System.Collections.Generic.List<string>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { string _e0;  _e0 = _buf.ReadString(); DNS.Add(_e0);}}
        CdnDirectoryName = _buf.ReadString();
        Auth = _buf.ReadString();
        LaunchPackageName = _buf.ReadString();
        LobbyPackageName = _buf.ReadString();
        GamePackageName = _buf.ReadString();
        ScriptResName = _buf.ReadString();
        LaunchResName = _buf.ReadString();
        VideoName = _buf.ReadString();
        Language = _buf.ReadString();
        PostInit();
    }

    public static LaunchConfig DeserializeLaunchConfig(ByteBuf _buf)
    {
        return new launch.LaunchConfig(_buf);
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
    /// 更新文件夹
    /// </summary>
    public string CdnDirectoryName { get; private set; }
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
        + "CdnDirectoryName:" + CdnDirectoryName + ","
        + "Auth:" + Auth + ","
        + "LaunchPackageName:" + LaunchPackageName + ","
        + "LobbyPackageName:" + LobbyPackageName + ","
        + "GamePackageName:" + GamePackageName + ","
        + "ScriptResName:" + ScriptResName + ","
        + "LaunchResName:" + LaunchResName + ","
        + "VideoName:" + VideoName + ","
        + "Language:" + Language + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}