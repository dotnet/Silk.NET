// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DISFFC
{
    [NativeTypeName("#define DISFFC_RESET 0x00000001")]
    public const int DISFFC_RESET = 0x00000001;
    [NativeTypeName("#define DISFFC_STOPALL 0x00000002")]
    public const int DISFFC_STOPALL = 0x00000002;
    [NativeTypeName("#define DISFFC_PAUSE 0x00000004")]
    public const int DISFFC_PAUSE = 0x00000004;
    [NativeTypeName("#define DISFFC_CONTINUE 0x00000008")]
    public const int DISFFC_CONTINUE = 0x00000008;
    [NativeTypeName("#define DISFFC_SETACTUATORSON 0x00000010")]
    public const int DISFFC_SETACTUATORSON = 0x00000010;
    [NativeTypeName("#define DISFFC_SETACTUATORSOFF 0x00000020")]
    public const int DISFFC_SETACTUATORSOFF = 0x00000020;
}