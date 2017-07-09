using Microsoft.Extensions.Logging;

namespace Net.Chdk.Meta.Providers.Camera.Sdm
{
    sealed class SdmCameraModelValidator : CameraModelValidator
    {
        public SdmCameraModelValidator(ILogger<SdmCameraModelValidator> logger)
            : base(logger)
        {
        }

        protected override void OnListRevisionMissing(string platform, string revision)
        {
            Logger.LogWarning("{0}: {1} missing from list", platform, revision);
        }
    }
}
