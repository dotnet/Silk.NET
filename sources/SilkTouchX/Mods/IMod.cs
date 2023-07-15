using Microsoft.Extensions.Configuration;

namespace SilkTouchX.Mods;

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
    /// For a configuration section representing a SilkTouch job referencing this mod, adds the configuration required
    /// for this mod to execute.
    /// </summary>
    /// <param name="section">The configuration section.</param>
    void AddConfigurationToSection(IConfigurationSection section);
}
