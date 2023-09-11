using SonsSdk;

namespace TemplateSonsMod;

public class TemplateSonsMod : SonsMod
{
    public TemplateSonsMod()
    {
        // Don't register any update callbacks here. Manually register them instead.
        // Removing this will call OnUpdate, OnFixedUpdate etc. even if you don't use them.
        NoUpdate = true;
    }

    protected override void OnInitializeMod()
    {
        // Do your early mod initialization which doesn't involve game or sdk references here
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        // Do your mod initialization which involves game or sdk references here
        // This is for stuff like UI creation, event registration etc.
        
        TemplateSonsModUi.Create();
    }

    protected override void OnGameStart()
    {
        // This is called once the player spawns in the world and gains control.
    }
    
    // This is called every frame.
    // public override void OnUpdate()
    // {
    // }
}