//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TeamComponent team { get { return (TeamComponent)GetComponent(GameComponentsLookup.Team); } }
    public bool hasTeam { get { return HasComponent(GameComponentsLookup.Team); } }

    public void AddTeam(int newValue) {
        var index = GameComponentsLookup.Team;
        var component = (TeamComponent)CreateComponent(index, typeof(TeamComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTeam(int newValue) {
        var index = GameComponentsLookup.Team;
        var component = (TeamComponent)CreateComponent(index, typeof(TeamComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTeam() {
        RemoveComponent(GameComponentsLookup.Team);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTeam;

    public static Entitas.IMatcher<GameEntity> Team {
        get {
            if (_matcherTeam == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Team);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTeam = matcher;
            }

            return _matcherTeam;
        }
    }
}
