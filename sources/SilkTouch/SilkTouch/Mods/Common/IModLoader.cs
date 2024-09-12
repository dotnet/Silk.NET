// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;

namespace Silk.NET.SilkTouch.Mods;

public interface IModLoader
{
    bool TryLoadMod(string identifier, [NotNullWhen(true)] out IMod? mod);
}
