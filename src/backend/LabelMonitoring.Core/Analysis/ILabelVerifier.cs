using OpenCvSharp;

namespace LabelMonitoring.Core.Analysis;

public interface ILabelVerifier
{
    VerificationResult Verify(Mat frame, Rect labelRegion);
}