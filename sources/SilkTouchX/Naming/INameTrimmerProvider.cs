using System.Collections.Generic;

namespace SilkTouchX.Naming;

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
