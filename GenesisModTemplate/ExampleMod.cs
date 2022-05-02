using ZGenesis.Mod;
using ZGenesis.Attributes;

namespace GenesisModTemplate {
    [GenesisMod]
    public class ExampleMod : GenesisMod {
        public override string Name => "Example Mod";
        public override string ModNamespace => "com.example";
        public override string Description => "An example mod template for use by other modders.";
        public override string Version => "v0.1.0";

        public ExampleMod() {
            // Register patchers and run pre-patching code here!
        }

        public override void PostPatches() {
            // Here, you can put things that should run after ALL mods have been patched
            // For example, event handler registration!
        }
    }
}
