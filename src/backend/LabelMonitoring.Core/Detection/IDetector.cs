using OpenCvSharp;

namespace LabelMonitoring.Core.Detection;

public interface IDetector
{
    Task<DetectionResult> DetectAsync(Mat frame);
    void LoadModel(string modelPath);
    event Action<DetectionResult> DetectionCompleted;
}