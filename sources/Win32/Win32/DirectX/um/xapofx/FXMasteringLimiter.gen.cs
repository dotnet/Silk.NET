// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C4137916-2BE1-46FD-8599-441536F49856")]
public unsafe partial struct FXMasteringLimiter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_FXMasteringLimiter));

    [NativeTypeName("#define FXMASTERINGLIMITER_MIN_RELEASE 1")]
    public const int FXMASTERINGLIMITER_MIN_RELEASE = 1;

    [NativeTypeName("#define FXMASTERINGLIMITER_MAX_RELEASE 20")]
    public const int FXMASTERINGLIMITER_MAX_RELEASE = 20;

    [NativeTypeName("#define FXMASTERINGLIMITER_DEFAULT_RELEASE 6")]
    public const int FXMASTERINGLIMITER_DEFAULT_RELEASE = 6;

    [NativeTypeName("#define FXMASTERINGLIMITER_MIN_LOUDNESS 1")]
    public const int FXMASTERINGLIMITER_MIN_LOUDNESS = 1;

    [NativeTypeName("#define FXMASTERINGLIMITER_MAX_LOUDNESS 1800")]
    public const int FXMASTERINGLIMITER_MAX_LOUDNESS = 1800;

    [NativeTypeName("#define FXMASTERINGLIMITER_DEFAULT_LOUDNESS 1000")]
    public const int FXMASTERINGLIMITER_DEFAULT_LOUDNESS = 1000;
}
