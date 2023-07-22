// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.InteropServices;

namespace SelfContainedTexturedCube;

[StructLayout(LayoutKind.Sequential)]
public ref struct CameraInfo
{
    public Matrix4x4 ProjectionMatrix;
    public Matrix4x4 ViewMatrix;
}
