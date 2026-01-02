using System;
using System.Collections.Generic;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Represents a name trimmer.
/// </summary>
public interface INameTrimmer
{
    /// <summary>
    /// Gets the name trimmer version i.e. the Silk.NET version that introduced this name trimming method. This is so
    /// new bindings released with or after this version don't have to have older trimming methods executed (the name
    /// version can be specified in the mod configuration)
    /// </summary>
    Version Version { get; }

    /// <summary>
    /// Trims prefixes from the given constituent names within the given container.
    /// </summary>
    /// <param name="context">The arguments.</param>
    void Trim(NameTrimmerContext context);
}
