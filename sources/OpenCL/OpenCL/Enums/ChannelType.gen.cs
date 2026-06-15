// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_channel_type")]
public enum ChannelType : uint
{
    [NativeName("CL_SNORM_INT8")]
    SnormInt8 = 4304,

    [NativeName("CL_SNORM_INT16")]
    SnormInt16 = 4305,

    [NativeName("CL_UNORM_INT8")]
    UnormInt8 = 4306,

    [NativeName("CL_UNORM_INT16")]
    UnormInt16 = 4307,

    [NativeName("CL_UNORM_SHORT_565")]
    UnormShort565 = 4308,

    [NativeName("CL_UNORM_SHORT_555")]
    UnormShort555 = 4309,

    [NativeName("CL_UNORM_INT_101010")]
    UnormInt101010 = 4310,

    [NativeName("CL_SIGNED_INT8")]
    SignedInt8 = 4311,

    [NativeName("CL_SIGNED_INT16")]
    SignedInt16 = 4312,

    [NativeName("CL_SIGNED_INT32")]
    SignedInt32 = 4313,

    [NativeName("CL_UNSIGNED_INT8")]
    UnsignedInt8 = 4314,

    [NativeName("CL_UNSIGNED_INT16")]
    UnsignedInt16 = 4315,

    [NativeName("CL_UNSIGNED_INT32")]
    UnsignedInt32 = 4316,

    [NativeName("CL_HALF_FLOAT")]
    HalfFloat = 4317,

    [NativeName("CL_FLOAT")]
    Float = 4318,

    [NativeName("CL_UNORM_INT_101010_2")]
    UnormInt101010x2 = 4320,
}
