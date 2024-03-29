//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
TBEntranceNature.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;


namespace cfg.entrance
{ 

public sealed partial class TBEntranceNature
{
    private readonly Dictionary<int, entrance.EntranceNatureConfig> _dataMap;
    private readonly List<entrance.EntranceNatureConfig> _dataList;
    
    public TBEntranceNature(JSONNode _json)
    {
        _dataMap = new Dictionary<int, entrance.EntranceNatureConfig>();
        _dataList = new List<entrance.EntranceNatureConfig>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = entrance.EntranceNatureConfig.DeserializeEntranceNatureConfig(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
        PostInit();
    }

    public Dictionary<int, entrance.EntranceNatureConfig> DataMap => _dataMap;
    public List<entrance.EntranceNatureConfig> DataList => _dataList;

    public entrance.EntranceNatureConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public entrance.EntranceNatureConfig Get(int key) => _dataMap[key];
    public entrance.EntranceNatureConfig this[int key] => _dataMap[key];

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