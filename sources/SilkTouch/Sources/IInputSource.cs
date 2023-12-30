using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Sources;

/// <summary>
/// A job input source i.e. a thing that can resolve a raw path to its canonical path.
/// </summary>
public interface IInputSource : IInputResolver
{
    /// <summary>
    /// The scheme used by this source.
    /// </summary>
    public string Scheme { get; }
}
