// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class BS
{
    [NativeTypeName("#define BS_SPLITBUTTON 0x0000000CL")]
    public const int BS_SPLITBUTTON = 0x0000000C;

    [NativeTypeName("#define BS_DEFSPLITBUTTON 0x0000000DL")]
    public const int BS_DEFSPLITBUTTON = 0x0000000D;

    [NativeTypeName("#define BS_COMMANDLINK 0x0000000EL")]
    public const int BS_COMMANDLINK = 0x0000000E;

    [NativeTypeName("#define BS_DEFCOMMANDLINK 0x0000000FL")]
    public const int BS_DEFCOMMANDLINK = 0x0000000F;
}
