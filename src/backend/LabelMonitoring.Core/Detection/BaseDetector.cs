using OpenCvSharp;

namespace LabelMonitoring.Core.Detection;

public abstract class BaseDetector : IDetector
{
    public abstract Task<DetectionResult> DetectAsync(Mat frame);
    public abstract void LoadModel(string modelPath);
    public event Action<DetectionResult>? DetectionCompleted;
}
