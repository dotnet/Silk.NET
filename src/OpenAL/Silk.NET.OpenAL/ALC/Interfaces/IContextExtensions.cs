// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the extension-related context functions of OpenAL 1.1. Furthermore, this interface is
    /// used to constrain extension implementation classes.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    public interface IContextExtensions
    {
        /// <summary>
        /// Determines whether or not the named extension is available.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="name">The name of the extension.</param>
        /// <returns>true if the extension is available; otherwise, false.</returns>
        unsafe bool IsExtensionPresent(Device* device, [CallerFree] string name);

        /// <summary>
        /// Gets the address of an OpenAL extension function.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="name">The name of the function.</param>
        /// <returns>The function pointer.</returns>
        unsafe void* GetProcAddress(Device* device, [CallerFree] string name);

        /// <summary>
        /// Gets the value of the named OpenAL extension enumeration member.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="name">The name of the enumeration member.</param>
        /// <returns>The value of the member.</returns>
        unsafe int GetEnumValue(Device* device, [CallerFree] string name);
    }
}