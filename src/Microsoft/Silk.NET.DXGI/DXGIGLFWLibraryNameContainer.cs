// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Silk.NET.Core.Loader;

namespace Silk.NET.DXGI;

internal class DXGIGLFWLibraryNameContainer : DXGILibraryNameContainer
{
    public override string[] Linux => new[] { "glfw-libdxvk_dxgi.so" }.Concat(base.Linux).ToArray();
}
