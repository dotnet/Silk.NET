using System;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// The 2.18 name trimmer.
/// </summary>
[Obsolete("Use NameTrimmer instead for 3.0 names")]
public class NameTrimmer218 : NameTrimmer
{
    /// <inheritdoc />
    public override Version Version => new(2, 18);

    /// <inheritdoc/>
    public override int Order => (int)TrimmerOrder.NameTrimmer218;

    /// <inheritdoc />
    protected override bool HasRawPass => false;

    /// <inheritdoc />
    protected override bool HasNaivePass => false;
}
