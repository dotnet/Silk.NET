// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum TextureEnvMode
{
    Blend = 0x0BE2,
    Replace = 0x1E01,
    ADD = 0x0104,
    Modulate = 0x2100,
    Decal = 0x2101,
    Combine = 0x8570,
    ReplaceEXT = 0x8062,
    TextureEnvBiasSGIX = 0x80BE
}
