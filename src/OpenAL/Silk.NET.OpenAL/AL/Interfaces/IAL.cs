//
// IAL.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface of the OpenAL 1.1 library.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IAL : IBuffers, IErrors, IExtensions, IListener, ISources, IState
    {
    }
}
