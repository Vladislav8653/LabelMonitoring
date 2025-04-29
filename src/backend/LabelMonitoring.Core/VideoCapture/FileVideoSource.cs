using OpenCvSharp;

namespace LabelMonitoring.Core.VideoCapture;

public class FileVideoSource :  IVideoSource
{
    public event Action<Mat>? FrameReady;
    public bool IsLiveStream { get; }
    
    public void StartCapture()
    {
        throw new NotImplementedException();
    }

    public void StopCapture()
    {
        throw new NotImplementedException();
    }
    
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}