using JaLoader;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace JaLoader_Mod_1
{
    /// <summary>
    /// The wiki is your best friend. Check it out here: https://github.com/theLeaxx/JaLoader/wiki
    /// You can also find a version of this template without any comments on the wiki.
    /// Highly recommended to check out the wiki before starting to code.
    /// Also suggest checking out the Order Of Execution page, to understand the order in which functions are called (https://github.com/theLeaxx/JaLoader/wiki/Order-of-Execution).
    /// </summary>
    public class JaLoader_Mod_1 : Mod
    {
        /// <summary>
        /// The mod's ID. Try making it as unique as possible, to avoid conflicting IDs.
        /// </summary>
        public override string ModID => "LiebegMod1";

        /// <summary>
        /// The mod's name. This is shown in the mods list. Does not need to be unique.
        /// </summary>
        public override string ModName => "Liebegs Test mod1";

        /// <summary>
        /// The mod's author (you). Also shown in the mods list.
        /// </summary>
        public override string ModAuthor => "Liebeg";

        /// <summary>
        /// The mod's description. This is also shown in the mods list, upon clicking on "More Info".
        /// </summary>
        public override string ModDescription => "Liebeg test mod 1";

        /// <summary>
        /// The mod's version. Also shown in the mods list. 
        /// If your mod is open-source on GitHub, make sure that you're using the same format as your release tags (for example, 1.0.0)
        /// For more information, check out the wiki page on versioning. (https://github.com/theLeaxx/JaLoader/wiki/Versioning-your-mod)
        /// </summary>
        public override string ModVersion => "1.0.0";

        /// <summary>
        /// If your mod is open-source on GitHub, you can link it here to allow for automatic update-checking in-game.
        /// It compares the current ModVersion with the tag of the latest release (ex. 1.0.0 compared with 1.0.1)
        /// For more information, check out the wiki page on versioning. (https://github.com/theLeaxx/JaLoader/wiki/Versioning-your-mod)
        /// </summary>
        public override string GitHubLink => "";

        /// <summary>
        /// When to initialize the mod.
        /// InGame: When the game is loaded, stops functioning in the main menu.
        /// InMenu: When the main menu is loaded, continues to function in-game too.
        /// </summary>
        public override WhenToInit WhenToInit => WhenToInit.InGame;

        /// <summary>
        /// If you mod depends on a certain version of JaLoader, or another mod, you can specify it here. 
        /// The format is (ModID, ModAuthor, ModVersion), and for JaLoader it's ("JaLoader", "Leaxx", {version}).
        /// Versions are usually formatted in the (x.y.z) format (for example, 1.2.0), although certain mods may follow other formats.
        /// Enable Debug Mode in JaLoader settings to view ModIDs instead of ModNames in the mod list.
        /// If you don't have any dependencies, you can just return an empty list.
        /// For more information, check out the wiki page on dependencies. (https://github.com/theLeaxx/JaLoader/wiki/Using-dependencies)
        /// </summary>
        public override List<(string, string, string)> Dependencies => new List<(string, string, string)>()
        {
        };

        /// <summary>
        /// If your mod uses custom assets, you need to set this to true.
        /// In other words, if your mod uses the "LoadAsset>T>" function, you need to set this to true.
        /// For more information, check out the wiki page on custom assets. (https://github.com/theLeaxx/JaLoader/wiki/Using-custom-assets)
        /// </summary>
        public override bool UseAssets => false;

        /// <summary>
        /// Declare all of your events here.
        /// Events are used to call functions when certain things happen in-game.
        /// They are held by the script "EventsManager". You can use "EventsManager.Instance.{event} += FunctionName()" to subscribe to them.
        /// For more information, check out the wiki page on events. (https://github.com/theLeaxx/JaLoader/wiki/Using-events)
        /// </summary>
        public override void EventsDeclaration()
        {
            base.EventsDeclaration();
        }

        /// <summary>
        /// Declare all of your settings here.
        /// Make sure to call "InstantiateSettings()" in here before declaring your settings.
        /// For more information, check out the wiki page on settings. (https://github.com/theLeaxx/JaLoader/wiki/Adding-settings-for-mods)
        /// </summary>
        public override void SettingsDeclaration()
        {
            base.SettingsDeclaration();
            InstantiateSettings();
            AddHeader("Choose your Lanfuage prefered.");
            AddHeader("On = English OFF = German");
            AddToggle("atoggle","Jokes in Ennglish", true);
        }

        /// <summary>
        /// Register all of your custom objects here.
        /// Custom objects are objects that are not part of the game's default objects, but act like them.
        /// Basically, if you want to add a new object to the game that can be picked up/placed/etc, you need to register it here.
        /// For more information, check out the wiki page on custom objects. (https://github.com/theLeaxx/JaLoader/wiki/Using-Custom-Objects)
        /// </summary>
        public override void CustomObjectsRegistration()
        {
            base.CustomObjectsRegistration();
        }

        /// <summary>
        /// This is the default Unity OnEnable() function, called as soon as the mod is enabled, before Awake() & Start().
        /// </summary>
        public override void OnEnable()
        {
            base.OnEnable();
        }

        /// <summary>
        /// This is the default Unity Awake() function, called as soon as the mod is enabled, before Start().
        /// </summary>
        public override void Awake()
        {
            base.Awake();
        }

        /// <summary>
        /// This is the default Unity Start() function, called when the mod is enabled.
        /// </summary>
        public override void Start()
        {   
           // string Meme1 =null;
            base.Start();
            JaLoader.Console.Instance.AddCommand("meme", "Prints a random meme", nameof(Sendmeme),this);


        }

        /// <summary>
        /// This is the default Unity Update() function, called every frame after the mod is enabled.
        /// </summary>
        public override void Update()
        {
            base.Update();
        }
        public void Sendmeme()
        {
            //List<String> memelist = new List<String>();
            //memelist.Add("");
            //System.Random rng = new System.Random();

            //int rand1 = rng.Next(100); // number between 0 and 99

            //JaLoader.Console.Log("Sendmeme should be triggered here" + rand1);
            string defilePath = "de_jokes.txt";
            string enfilePath = "en_jokes.txt";
            // Check if the file exists

            if (GetToggleValue("atoggle") == true)
            {
                if (File.Exists(enfilePath))
                {
                    // Read all lines from the file
                    string[] enjokes = File.ReadAllLines(enfilePath);

                    // Check if the file is not empty
                    if (enjokes.Length > 0)
                    {
                        // Create a random number generator
                        System.Random random = new System.Random();

                        // Get a random index
                        int randomIndex = random.Next(enjokes.Length);

                        // Print the random joke
                        JaLoader.Console.Log(enjokes[randomIndex]);
                    }
                    else
                    {
                        JaLoader.Console.Log("The file is empty.");
                    }
                }
                else
                {
                    JaLoader.Console.Log($"File not found: {enfilePath}");
                }
            }

            if (GetToggleValue("atoggle") == false)
            {
                if (File.Exists(defilePath))
            {
                // Read all lines from the file
                string[] jokes = File.ReadAllLines(defilePath);

                // Check if the file is not empty
                if (jokes.Length > 0)
                {
                    // Create a random number generator
                    System.Random random = new System.Random();

                    // Get a random index
                    int randomIndex = random.Next(jokes.Length);

                    // Print the random joke
                    JaLoader.Console.Log(jokes[randomIndex]);
                }
                else
                {
                    JaLoader.Console.Log("The file is empty.");
                }
            }
            else
            {
                JaLoader.Console.Log($"File not found: {defilePath}");
            }
        }
        }
        /// <summary>
        /// This is the default Unity OnDisable() function, called when the mod is disabled.
        /// </summary>
        public override void OnDisable()
        {
            base.OnDisable();
            JaLoader.Console.Log("If you had any problems please write me.");
        }
    }
}
