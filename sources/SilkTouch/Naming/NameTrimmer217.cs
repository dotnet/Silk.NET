using System;
using System.Collections.Generic;
using Humanizer;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// The 2.17 name trimmer.
/// </summary>
[Obsolete("Use NameTrimmer instead for 3.0 names")]
public class NameTrimmer217 : NameTrimmer
{
    /// <inheritdoc />
    public override Version Version => new(2, 17);

    /// <inheritdoc />
    protected override bool HasRawPass => false;

    /// <inheritdoc />
    protected override bool HasNaivePass => false;

    /// <inheritdoc />
    protected override string GetTrimmingName(
        Dictionary<string, string>? prefixOverrides,
        string name,
        bool isContainer
    )
    {
        if (!isContainer)
        {
            return name;
        }

        return !name.Contains('_') ? name.Underscore() : name;
    }
}
