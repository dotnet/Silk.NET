// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetMultisamplePNameNV")]
public enum GetMultisamplePName : uint
{
    [NativeName("GL_SAMPLE_POSITION")]
    SamplePosition = 36432,

    [NativeName("GL_SAMPLE_LOCATION_ARB")]
    SampleLocationARB = 36432,

    [NativeName("GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB")]
    ProgrammableSampleLocationARB = 37697,
}
