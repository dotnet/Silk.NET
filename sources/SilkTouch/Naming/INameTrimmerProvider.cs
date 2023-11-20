using System.Collections.Generic;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Provides name trimmers.
/// </summary>
public interface INameTrimmerProvider
{
    /// <summary>
    /// The name trimmers.
    /// </summary>
    /// <param name="key">The job key.</param>
    public IEnumerable<INameTrimmer> GetTrimmers(string? key);
}
