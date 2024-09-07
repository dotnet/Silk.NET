using System.Collections.Generic;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A resolver for standard includes.
/// </summary>
public interface IStdIncludeResolver
{
    /// <summary>
    /// Gets the standard include libclang arguments for the C compilation on this PC.
    /// </summary>
    /// <returns>Standard include libclang arguments.</returns>
    IEnumerable<string> GetStandardIncludes();
}
