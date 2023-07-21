// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.DirectX;

[Guid("F5E01117-D6C4-485A-A3F5-695196F3DBFA")]
public unsafe partial struct FXEQ : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_FXEQ));

    [NativeTypeName("#define FXEQ_MIN_FRAMERATE 22000")]
    public const int FXEQ_MIN_FRAMERATE = 22000;

    [NativeTypeName("#define FXEQ_MAX_FRAMERATE 48000")]
    public const int FXEQ_MAX_FRAMERATE = 48000;

    [NativeTypeName("#define FXEQ_MIN_FREQUENCY_CENTER 20.0f")]
    public const float FXEQ_MIN_FREQUENCY_CENTER = 20.0f;

    [NativeTypeName("#define FXEQ_MAX_FREQUENCY_CENTER 20000.0f")]
    public const float FXEQ_MAX_FREQUENCY_CENTER = 20000.0f;

    [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_0 100.0f")]
    public const float FXEQ_DEFAULT_FREQUENCY_CENTER_0 = 100.0f;

    [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_1 800.0f")]
    public const float FXEQ_DEFAULT_FREQUENCY_CENTER_1 = 800.0f;

    [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_2 2000.0f")]
    public const float FXEQ_DEFAULT_FREQUENCY_CENTER_2 = 2000.0f;

    [NativeTypeName("#define FXEQ_DEFAULT_FREQUENCY_CENTER_3 10000.0f")]
    public const float FXEQ_DEFAULT_FREQUENCY_CENTER_3 = 10000.0f;

    [NativeTypeName("#define FXEQ_MIN_GAIN 0.126f")]
    public const float FXEQ_MIN_GAIN = 0.126f;

    [NativeTypeName("#define FXEQ_MAX_GAIN 7.94f")]
    public const float FXEQ_MAX_GAIN = 7.94f;

    [NativeTypeName("#define FXEQ_DEFAULT_GAIN 1.0f")]
    public const float FXEQ_DEFAULT_GAIN = 1.0f;

    [NativeTypeName("#define FXEQ_MIN_BANDWIDTH 0.1f")]
    public const float FXEQ_MIN_BANDWIDTH = 0.1f;

    [NativeTypeName("#define FXEQ_MAX_BANDWIDTH 2.0f")]
    public const float FXEQ_MAX_BANDWIDTH = 2.0f;

    [NativeTypeName("#define FXEQ_DEFAULT_BANDWIDTH 1.0f")]
    public const float FXEQ_DEFAULT_BANDWIDTH = 1.0f;
}
