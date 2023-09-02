//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
TBEntrance.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;


namespace cfg.entrance
{ 

public sealed partial class TBEntrance
{
    private readonly Dictionary<int, entrance.EntranceConfig> _dataMap;
    private readonly List<entrance.EntranceConfig> _dataList;
    
    public TBEntrance(JSONNode _json)
    {
        _dataMap = new Dictionary<int, entrance.EntranceConfig>();
        _dataList = new List<entrance.EntranceConfig>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = entrance.EntranceConfig.DeserializeEntranceConfig(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
        PostInit();
    }

    public Dictionary<int, entrance.EntranceConfig> DataMap => _dataMap;
    public List<entrance.EntranceConfig> DataList => _dataList;

    public entrance.EntranceConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public entrance.EntranceConfig Get(int key) => _dataMap[key];
    public entrance.EntranceConfig this[int key] => _dataMap[key];

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