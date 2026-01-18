// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NativeName("StringPName")]
public enum StringPName : uint
{
    [NativeName("AL_VENDOR")]
    Vendor = 45057,

    [NativeName("AL_VERSION")]
    Version = 45058,

    [NativeName("AL_RENDERER")]
    Renderer = 45059,

    [NativeName("AL_EXTENSIONS")]
    Extensions = 45060,

    [NativeName("AL_RESAMPLER_NAME_SOFT")]
    ResamplerNameSOFT = 4627,
}
