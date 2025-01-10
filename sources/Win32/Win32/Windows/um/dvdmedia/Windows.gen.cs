// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define AMCOPYPROTECT_RestrictDuplication 0x00000001")]
    public const int AMCOPYPROTECT_RestrictDuplication = 0x00000001;

    [NativeTypeName("#define AMCONTROL_USED 0x00000001")]
    public const int AMCONTROL_USED = 0x00000001;

    [NativeTypeName("#define AMCONTROL_PAD_TO_4x3 0x00000002")]
    public const int AMCONTROL_PAD_TO_4x3 = 0x00000002;

    [NativeTypeName("#define AMCONTROL_PAD_TO_16x9 0x00000004")]
    public const int AMCONTROL_PAD_TO_16x9 = 0x00000004;

    [NativeTypeName("#define AMCONTROL_COLORINFO_PRESENT 0x00000080")]
    public const int AMCONTROL_COLORINFO_PRESENT = 0x00000080;
}
