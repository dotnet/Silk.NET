// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum GetPointervPName
{
    DebugCallbackFunction = 0x8244,
    DebugCallbackUserParam = 0x8245,
    VertexArrayPointer = 0x808E,
    NormalArrayPointer = 0x808F,
    ColorArrayPointer = 0x8090,
    IndexArrayPointer = 0x8091,
    TextureCoordArrayPointer = 0x8092,
    EdgeFlagArrayPointer = 0x8093,
    FeedbackBufferPointer = 0x0DF0,
    SelectionBufferPointer = 0x0DF3,
    VertexArrayPointerEXT = 0x808E,
    NormalArrayPointerEXT = 0x808F,
    ColorArrayPointerEXT = 0x8090,
    IndexArrayPointerEXT = 0x8091,
    TextureCoordArrayPointerEXT = 0x8092,
    EdgeFlagArrayPointerEXT = 0x8093,
    InstrumentBufferPointerSGIX = 0x8180
}
