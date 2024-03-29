//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
TBAvatar.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;


namespace cfg.Player
{ 

public sealed partial class TBAvatar
{
    private readonly Dictionary<int, Player.AvatarConfig> _dataMap;
    private readonly List<Player.AvatarConfig> _dataList;
    
    public TBAvatar(JSONNode _json)
    {
        _dataMap = new Dictionary<int, Player.AvatarConfig>();
        _dataList = new List<Player.AvatarConfig>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = Player.AvatarConfig.DeserializeAvatarConfig(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, Player.AvatarConfig> DataMap => _dataMap;
    public List<Player.AvatarConfig> DataList => _dataList;

    public Player.AvatarConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Player.AvatarConfig Get(int key) => _dataMap[key];
    public Player.AvatarConfig this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}