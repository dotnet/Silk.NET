namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// The intention behind a cache.
/// </summary>
public enum CacheIntent
{
    /// <summary>
    /// Cached downloaded artifacts for foreign inputs into a job (e.g. a NuGet package restored as part of build).
    /// </summary>
    ResolvedForeignInput,

    /// <summary>
    /// Intermediate output from a job stage (e.g. raw bindings generated from ClangSharp).
    /// </summary>
    StageIntermediateOutput
}
