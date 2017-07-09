using Net.Chdk.Meta.Model.CameraTree;
using Net.Chdk.Meta.Providers.Camera.Ps;

namespace Net.Chdk.Meta.Providers.Camera.Sdm
{
    sealed class SdmAltProvider : AltProvider
    {
        protected override string GetAltButton(string platform, TreeAltData tree)
        {
            return "Menu";
        }
    }
}
