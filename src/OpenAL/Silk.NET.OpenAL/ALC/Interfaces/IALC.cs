// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface of the context in the OpenAL 1.1 library.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IALC : IContext, IContextDevices, IContextErrors, IContextExtensions, IContextState
    {
    }
}