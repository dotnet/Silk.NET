using System.Collections.Generic;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A resolver for standard includes.
/// </summary>
public interface IStdIncludeResolver
{
    /// <summary>
    /// Gets the standard includes for the C compilation on this PC.
    /// </summary>
    /// <returns>Standard include directories.</returns>
    IEnumerable<string> GetStandardIncludes();
}
