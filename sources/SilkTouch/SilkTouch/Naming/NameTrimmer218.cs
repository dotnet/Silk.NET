namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// The 2.18 name trimmer.
/// </summary>
[Obsolete("Use NameTrimmer instead for 3.0 names")]
public class NameTrimmer218 : NameTrimmer
{
    /// <inheritdoc />
    protected override bool HasRawPass => false;

    /// <inheritdoc />
    protected override bool HasNaivePass => false;
}
