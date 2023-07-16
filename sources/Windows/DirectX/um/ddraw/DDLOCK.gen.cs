// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DDLOCK
{
    [NativeTypeName("#define DDLOCK_SURFACEMEMORYPTR 0x00000000L")]
    public const int DDLOCK_SURFACEMEMORYPTR = 0x00000000;
    [NativeTypeName("#define DDLOCK_WAIT 0x00000001L")]
    public const int DDLOCK_WAIT = 0x00000001;
    [NativeTypeName("#define DDLOCK_EVENT 0x00000002L")]
    public const int DDLOCK_EVENT = 0x00000002;
    [NativeTypeName("#define DDLOCK_READONLY 0x00000010L")]
    public const int DDLOCK_READONLY = 0x00000010;
    [NativeTypeName("#define DDLOCK_WRITEONLY 0x00000020L")]
    public const int DDLOCK_WRITEONLY = 0x00000020;
    [NativeTypeName("#define DDLOCK_NOSYSLOCK 0x00000800L")]
    public const int DDLOCK_NOSYSLOCK = 0x00000800;
    [NativeTypeName("#define DDLOCK_NOOVERWRITE 0x00001000L")]
    public const int DDLOCK_NOOVERWRITE = 0x00001000;
    [NativeTypeName("#define DDLOCK_DISCARDCONTENTS 0x00002000L")]
    public const int DDLOCK_DISCARDCONTENTS = 0x00002000;
    [NativeTypeName("#define DDLOCK_OKTOSWAP 0x00002000L")]
    public const int DDLOCK_OKTOSWAP = 0x00002000;
    [NativeTypeName("#define DDLOCK_DONOTWAIT 0x00004000L")]
    public const int DDLOCK_DONOTWAIT = 0x00004000;
    [NativeTypeName("#define DDLOCK_HASVOLUMETEXTUREBOXRECT 0x00008000L")]
    public const int DDLOCK_HASVOLUMETEXTUREBOXRECT = 0x00008000;
    [NativeTypeName("#define DDLOCK_NODIRTYUPDATE 0x00010000L")]
    public const int DDLOCK_NODIRTYUPDATE = 0x00010000;
}