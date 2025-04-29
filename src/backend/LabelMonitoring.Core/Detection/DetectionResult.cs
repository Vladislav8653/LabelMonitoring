using OpenCvSharp;

namespace LabelMonitoring.Core.Detection;

public record DetectionResult
{
    public bool LabelDetected { get; init; }
    public Rect LabelPosition { get; init; }
    public string? LabelText { get; init; }
    public double Confidence { get; init; }
    public Mat? AnnotatedFrame { get; init; }
}