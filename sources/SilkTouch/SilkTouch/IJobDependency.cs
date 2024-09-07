using System.Collections.Generic;

namespace Silk.NET.SilkTouch;

/// <summary>
/// A dependency injection helper that can be used to load dependency injection registered types that may or may not be
/// applicable depending on the job configuration.
/// </summary>
public interface IJobDependency<out T>
{
    /// <summary>
    /// Gets all instances of <typeparamref name="T"/> for the given job key.
    /// </summary>
    /// <param name="jobKey">The job key.</param>
    /// <returns>The instances.</returns>
    IEnumerable<T> Get(string? jobKey);
}
