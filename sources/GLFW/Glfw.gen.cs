// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.GLFW;

partial class Glfw(INativeContext nativeContext) : IDisposable
{
    public static IGlfw Create(INativeContext ctx) => new Glfw(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
