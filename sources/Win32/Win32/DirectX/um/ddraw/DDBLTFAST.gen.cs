// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDBLTFAST
{
    [NativeTypeName("#define DDBLTFAST_NOCOLORKEY 0x00000000")]
    public const int DDBLTFAST_NOCOLORKEY = 0x00000000;

    [NativeTypeName("#define DDBLTFAST_SRCCOLORKEY 0x00000001")]
    public const int DDBLTFAST_SRCCOLORKEY = 0x00000001;

    [NativeTypeName("#define DDBLTFAST_DESTCOLORKEY 0x00000002")]
    public const int DDBLTFAST_DESTCOLORKEY = 0x00000002;

    [NativeTypeName("#define DDBLTFAST_WAIT 0x00000010")]
    public const int DDBLTFAST_WAIT = 0x00000010;

    [NativeTypeName("#define DDBLTFAST_DONOTWAIT 0x00000020")]
    public const int DDBLTFAST_DONOTWAIT = 0x00000020;
}
