// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DLOCK
{
    [NativeTypeName("#define D3DLOCK_READONLY 0x00000010L")]
    public const int D3DLOCK_READONLY = 0x00000010;

    [NativeTypeName("#define D3DLOCK_DISCARD 0x00002000L")]
    public const int D3DLOCK_DISCARD = 0x00002000;

    [NativeTypeName("#define D3DLOCK_NOOVERWRITE 0x00001000L")]
    public const int D3DLOCK_NOOVERWRITE = 0x00001000;

    [NativeTypeName("#define D3DLOCK_NOSYSLOCK 0x00000800L")]
    public const int D3DLOCK_NOSYSLOCK = 0x00000800;

    [NativeTypeName("#define D3DLOCK_DONOTWAIT 0x00004000L")]
    public const int D3DLOCK_DONOTWAIT = 0x00004000;

    [NativeTypeName("#define D3DLOCK_NO_DIRTY_UPDATE 0x00008000L")]
    public const int D3DLOCK_NO_DIRTY_UPDATE = 0x00008000;
}
