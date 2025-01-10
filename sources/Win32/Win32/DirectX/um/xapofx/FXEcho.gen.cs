// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("5039D740-F736-449A-84D3-A56202557B87")]
public unsafe partial struct FXEcho : INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_FXEcho));

    [NativeTypeName("#define FXECHO_MIN_WETDRYMIX 0.0f")]
    public const float FXECHO_MIN_WETDRYMIX = 0.0f;

    [NativeTypeName("#define FXECHO_MAX_WETDRYMIX 1.0f")]
    public const float FXECHO_MAX_WETDRYMIX = 1.0f;

    [NativeTypeName("#define FXECHO_DEFAULT_WETDRYMIX 0.5f")]
    public const float FXECHO_DEFAULT_WETDRYMIX = 0.5f;

    [NativeTypeName("#define FXECHO_MIN_FEEDBACK 0.0f")]
    public const float FXECHO_MIN_FEEDBACK = 0.0f;

    [NativeTypeName("#define FXECHO_MAX_FEEDBACK 1.0f")]
    public const float FXECHO_MAX_FEEDBACK = 1.0f;

    [NativeTypeName("#define FXECHO_DEFAULT_FEEDBACK 0.5f")]
    public const float FXECHO_DEFAULT_FEEDBACK = 0.5f;

    [NativeTypeName("#define FXECHO_MIN_DELAY 1.0f")]
    public const float FXECHO_MIN_DELAY = 1.0f;

    [NativeTypeName("#define FXECHO_MAX_DELAY 2000.0f")]
    public const float FXECHO_MAX_DELAY = 2000.0f;

    [NativeTypeName("#define FXECHO_DEFAULT_DELAY 500.0f")]
    public const float FXECHO_DEFAULT_DELAY = 500.0f;
}
