using OpenCvSharp;

namespace LabelMonitoring.Core.Detection;

public class LabelDetector : BaseDetector 
{
    public override Task<DetectionResult> DetectAsync(Mat frame)
    {
        throw new NotImplementedException();
    }

    public override void LoadModel(string modelPath)
    {
        throw new NotImplementedException();
    }
}