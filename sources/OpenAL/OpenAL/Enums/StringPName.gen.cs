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
    Vendor = unchecked((uint)0xB001),

    [NativeName("AL_VERSION")]
    Version = unchecked((uint)0xB002),

    [NativeName("AL_RENDERER")]
    Renderer = unchecked((uint)0xB003),

    [NativeName("AL_EXTENSIONS")]
    Extensions = unchecked((uint)0xB004),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_RESAMPLER_NAME_SOFT")]
    ResamplerNameSOFT = unchecked((uint)0x1213),
}
