//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
TBGoldProp.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;


namespace cfg.Prop
{ 

public sealed partial class TBGoldProp
{
    private readonly Dictionary<int, Prop.GoldPropConfig> _dataMap;
    private readonly List<Prop.GoldPropConfig> _dataList;
    
    public TBGoldProp(JSONNode _json)
    {
        _dataMap = new Dictionary<int, Prop.GoldPropConfig>();
        _dataList = new List<Prop.GoldPropConfig>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = Prop.GoldPropConfig.DeserializeGoldPropConfig(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, Prop.GoldPropConfig> DataMap => _dataMap;
    public List<Prop.GoldPropConfig> DataList => _dataList;

    public Prop.GoldPropConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Prop.GoldPropConfig Get(int key) => _dataMap[key];
    public Prop.GoldPropConfig this[int key] => _dataMap[key];

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