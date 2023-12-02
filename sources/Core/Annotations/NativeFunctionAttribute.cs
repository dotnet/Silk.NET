using System.Runtime.InteropServices;

namespace Silk.NET.Core;

/// <summary>
/// A simple annotation marking a function as containing a managed-to-native transition to the given function name.
/// Used for code generation hinting.
/// </summary>
/// <remarks>
/// The members and their meaning are exactly as in <see cref="DllImportAttribute"/>.
/// </remarks>
/// <seealso cref="DllImportAttribute"/>
public class NativeFunctionAttribute : Attribute
{
    /// <summary>
    /// Creates an instance for the given DLL name.
    /// </summary>
    /// <param name="dllName">The DLL name.</param>
    public NativeFunctionAttribute(string dllName) => Value = dllName;

    /// <summary>
    /// The DLL to import.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// The native entry-point. If <c>null</c> this will be determined by the name of the function this annotation is
    /// present on.
    /// </summary>
    public string? EntryPoint;
}
