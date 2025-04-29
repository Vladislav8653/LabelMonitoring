using OpenCvSharp;

namespace LabelMonitoring.Core.VideoCapture;

public interface IVideoSource : IDisposable
{
    event Action<Mat> FrameReady;
    bool IsLiveStream { get; }
    void StartCapture();
    void StopCapture();
}