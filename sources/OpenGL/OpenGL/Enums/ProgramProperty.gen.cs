// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ProgramProperty : uint
{
    DeleteStatus = unchecked((uint)0x8B80),
    LinkStatus = unchecked((uint)0x8B82),
    ValidateStatus = unchecked((uint)0x8B83),
    InfoLogLength = unchecked((uint)0x8B84),
    AttachedShaders = unchecked((uint)0x8B85),
    ActiveUniforms = unchecked((uint)0x8B86),
    ActiveUniformMaxLength = unchecked((uint)0x8B87),
    ActiveAttributes = unchecked((uint)0x8B89),
    ActiveAttributeMaxLength = unchecked((uint)0x8B8A),
    TransformFeedbackVaryingMaxLength = unchecked((uint)0x8C76),
    TransformFeedbackBufferMode = unchecked((uint)0x8C7F),
    TransformFeedbackVaryings = unchecked((uint)0x8C83),
    ActiveUniformBlockMaxNameLength = unchecked((uint)0x8A35),
    ActiveUniformBlocks = unchecked((uint)0x8A36),
    GeometryVerticesOut = unchecked((uint)0x8916),
    GeometryInputType = unchecked((uint)0x8917),
    GeometryOutputType = unchecked((uint)0x8918),
    ProgramBinaryLength = unchecked((uint)0x8741),
    ActiveAtomicCounterBuffers = unchecked((uint)0x92D9),
    ComputeWorkGroupSize = unchecked((uint)0x8267),
}
