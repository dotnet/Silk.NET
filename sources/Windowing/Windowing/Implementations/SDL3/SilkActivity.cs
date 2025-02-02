// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if ANDROID
using Org.Libsdl.App;

namespace Silk.NET.Windowing.SDL3;

public abstract class SilkActivity<T> : SDLActivity
    where T : ISurfaceApplication
{
    protected override void Main() => ISurfaceApplication.Run<T>();
}
#endif
