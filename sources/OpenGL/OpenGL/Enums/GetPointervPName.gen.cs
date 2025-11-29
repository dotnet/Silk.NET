// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum GetPointervPName : uint
{
    VertexArrayPointer = unchecked((uint)0x808E),
    NormalArrayPointer = unchecked((uint)0x808F),
    ColorArrayPointer = unchecked((uint)0x8090),
    IndexArrayPointer = unchecked((uint)0x8091),
    TextureCoordArrayPointer = unchecked((uint)0x8092),
    EdgeFlagArrayPointer = unchecked((uint)0x8093),
    FeedbackBufferPointer = unchecked((uint)0x0DF0),
    SelectionBufferPointer = unchecked((uint)0x0DF3),
    DebugCallbackFunction = unchecked((uint)0x8244),
    DebugCallbackUserParam = unchecked((uint)0x8245),
    VertexArrayPointerEXT = unchecked((uint)0x808E),
    NormalArrayPointerEXT = unchecked((uint)0x808F),
    ColorArrayPointerEXT = unchecked((uint)0x8090),
    IndexArrayPointerEXT = unchecked((uint)0x8091),
    TextureCoordArrayPointerEXT = unchecked((uint)0x8092),
    EdgeFlagArrayPointerEXT = unchecked((uint)0x8093),
    InstrumentBufferPointerSGIX = unchecked((uint)0x8180),
}
