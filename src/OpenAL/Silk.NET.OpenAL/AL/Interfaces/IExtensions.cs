// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the extension-related functions of OpenAL 1.1. Furthermore, this interface is
    /// used to constrain extension implementation classes.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IExtensions : IALExtension
    {
    }
}