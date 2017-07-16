using Net.Chdk.Meta.Model.Camera.Ps;
using Net.Chdk.Meta.Model.CameraList;
using Net.Chdk.Meta.Model.CameraTree;
using Net.Chdk.Meta.Providers.Camera.Ps;

namespace Net.Chdk.Meta.Providers.Camera.Sdm
{
    sealed class SdmRevisionProvider : ProductRevisionProvider
    {
        public override string ProductName => "SDM";

        public override RevisionData GetRevision(string revision, TreeRevisionData treeRevision, ListPlatformData list, TreePlatformData tree)
        {
            var key = treeRevision.Source?.Revision ?? revision;
            if (!list.Revisions.ContainsKey(key))
                return null;

            return GetRevision(key);
        }
    }
}
