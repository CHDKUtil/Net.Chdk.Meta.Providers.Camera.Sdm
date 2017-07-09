using Microsoft.Extensions.Logging;

namespace Net.Chdk.Meta.Providers.Camera.Sdm
{
    sealed class SdmCameraValidator : CameraValidator
    {
        public SdmCameraValidator(ILogger<SdmCameraValidator> logger)
            : base(logger)
        {
        }

        protected override void OnListPlatformMissing(string platform)
        {
            Logger.LogWarning("{0} missing from list", platform);
        }
    }
}
