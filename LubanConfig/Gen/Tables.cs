//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
Tables.cs
Create By Ben
*/

using Bright.Serialization;
using SimpleJSON;

namespace cfg
{ 
   
public sealed partial class Tables
{
    public localization.TBLocalization TBLocalization {get; }
    public game.TBGame TBGame {get; }
    public global.TBLanguage TBLanguage {get; }
    public entrance.TBEntrance TBEntrance {get; }
    public entrance.TBEntranceNature TBEntranceNature {get; }

    public Tables(System.Func<string, JSONNode> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TBLocalization = new localization.TBLocalization(loader("localization_tblocalization")); 
        tables.Add("localization.TBLocalization", TBLocalization);
        TBGame = new game.TBGame(loader("game_tbgame")); 
        tables.Add("game.TBGame", TBGame);
        TBLanguage = new global.TBLanguage(loader("global_tblanguage")); 
        tables.Add("global.TBLanguage", TBLanguage);
        TBEntrance = new entrance.TBEntrance(loader("entrance_tbentrance")); 
        tables.Add("entrance.TBEntrance", TBEntrance);
        TBEntranceNature = new entrance.TBEntranceNature(loader("entrance_tbentrancenature")); 
        tables.Add("entrance.TBEntranceNature", TBEntranceNature);
        PostInit();

        TBLocalization.Resolve(tables); 
        TBGame.Resolve(tables); 
        TBLanguage.Resolve(tables); 
        TBEntrance.Resolve(tables); 
        TBEntranceNature.Resolve(tables); 
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TBLocalization.TranslateText(translator); 
        TBGame.TranslateText(translator); 
        TBLanguage.TranslateText(translator); 
        TBEntrance.TranslateText(translator); 
        TBEntranceNature.TranslateText(translator); 
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}