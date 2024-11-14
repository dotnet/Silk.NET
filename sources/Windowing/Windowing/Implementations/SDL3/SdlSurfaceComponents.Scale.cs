// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceScale
{
    float ISurfaceScale.ContentScale => throw new NotImplementedException();

    float ISurfaceScale.DrawScale => throw new NotImplementedException();

    float ISurfaceScale.PixelDensity => throw new NotImplementedException();
}
