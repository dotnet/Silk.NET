// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum TextureGenParameter
{
    TextureGenMode = 0x2500,
    ObjectPlane = 0x2501,
    EyePlane = 0x2502,
    EyePointSGIS = 0x81F4,
    ObjectPointSGIS = 0x81F5,
    EyeLineSGIS = 0x81F6,
    ObjectLineSGIS = 0x81F7,
    TextureGenModeOES = 0x2500
}
