// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDOVERZ
{
    [NativeTypeName("#define DDOVERZ_SENDTOFRONT 0x00000000l")]
    public const int DDOVERZ_SENDTOFRONT = 0x00000000;

    [NativeTypeName("#define DDOVERZ_SENDTOBACK 0x00000001l")]
    public const int DDOVERZ_SENDTOBACK = 0x00000001;

    [NativeTypeName("#define DDOVERZ_MOVEFORWARD 0x00000002l")]
    public const int DDOVERZ_MOVEFORWARD = 0x00000002;

    [NativeTypeName("#define DDOVERZ_MOVEBACKWARD 0x00000003l")]
    public const int DDOVERZ_MOVEBACKWARD = 0x00000003;

    [NativeTypeName("#define DDOVERZ_INSERTINFRONTOF 0x00000004l")]
    public const int DDOVERZ_INSERTINFRONTOF = 0x00000004;

    [NativeTypeName("#define DDOVERZ_INSERTINBACKOF 0x00000005l")]
    public const int DDOVERZ_INSERTINBACKOF = 0x00000005;
}
