using SonsSdk;

namespace TemplateSonsMod;

public class TemplateSonsMod : SonsMod
{
    public TemplateSonsMod()
    {

        #if (comments)
        // Uncomment any of these if you need a method to run on a specific update loop.
        //OnUpdateCallback = MyUpdateMethod;
        //OnLateUpdateCallback = MyLateUpdateMethod;
        //OnFixedUpdateCallback = MyFixedUpdateMethod;
        //OnGUICallback = MyGUIMethod;

        // Uncomment this to automatically apply harmony patches in your assembly.
        #endif
        //HarmonyPatchAll = true;
    }

    protected override void OnInitializeMod()
    {
        #if (comments)
        // Do your early mod initialization which doesn't involve game or sdk references here
        #endif
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        #if (comments)
        // Do your mod initialization which involves game or sdk references here
        // This is for stuff like UI creation, event registration etc.
        #endif
        TemplateSonsModUi.Create();
    }

    protected override void OnGameStart()
    {
        #if (comments)
        // This is called once the player spawns in the world and gains control.
        #endif
    }
}