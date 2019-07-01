//
// IExtensions.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using Silk.NET.Core.Extensions;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the extension-related functions of OpenAL 1.1. Furthermore, this interface is
    /// used to constrain extension implementation classes.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IExtensions : IAPIExtension
    {
    }
}
