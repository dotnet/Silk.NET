using System.Collections.Generic;
using System.Threading.Tasks;
using Silk.NET.SilkTouch.Clang;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Represents a "mod" - a type that will ingest ClangSharp configurations and the outputs from their configurations,
/// possibly adding modifications to either before and after it goes to ClangSharp. This is essentially to manipulate
/// the data flowing in and out of the ClangSharp P/Invoke Generator according to some external configuration without
/// having to modify the original response files.
/// </summary>
/// <remarks>
/// Each mod type is instantiated for each SilkTouch job to enable the safe storage of state.
/// </remarks>
public interface IMod
{
    /// <summary>
    /// Initializes the mod.
    /// </summary>
    /// <param name="context"></param>
    void Initialize(IModContext context);
}
