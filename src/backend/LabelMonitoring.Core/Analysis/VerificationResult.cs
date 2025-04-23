namespace LabelMonitoring.Core.Analysis;

public record VerificationResult
{
    public bool IsValid { get; init; }
    public string[] Defects { get; init; } = [];
}