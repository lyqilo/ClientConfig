//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
TBPreLaunch.cs
Create By Ben
*/

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.launch
{ 

public sealed partial class TBPreLaunch
{
    private readonly Dictionary<int, launch.LaunchPreConfig> _dataMap;
    private readonly List<launch.LaunchPreConfig> _dataList;
    
    public TBPreLaunch(JSONNode _json)
    {
        _dataMap = new Dictionary<int, launch.LaunchPreConfig>();
        _dataList = new List<launch.LaunchPreConfig>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = launch.LaunchPreConfig.DeserializeLaunchPreConfig(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
        PostInit();
    }

    public Dictionary<int, launch.LaunchPreConfig> DataMap => _dataMap;
    public List<launch.LaunchPreConfig> DataList => _dataList;

    public launch.LaunchPreConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public launch.LaunchPreConfig Get(int key) => _dataMap[key];
    public launch.LaunchPreConfig this[int key] => _dataMap[key];

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