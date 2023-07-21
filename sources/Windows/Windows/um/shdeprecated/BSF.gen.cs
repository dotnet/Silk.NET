// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class BSF
{
    [NativeTypeName("#define BSF_REGISTERASDROPTARGET 0x00000001")]
    public const int BSF_REGISTERASDROPTARGET = 0x00000001;

    [NativeTypeName("#define BSF_THEATERMODE 0x00000002")]
    public const int BSF_THEATERMODE = 0x00000002;

    [NativeTypeName("#define BSF_NOLOCALFILEWARNING 0x00000010")]
    public const int BSF_NOLOCALFILEWARNING = 0x00000010;

    [NativeTypeName("#define BSF_UISETBYAUTOMATION 0x00000100")]
    public const int BSF_UISETBYAUTOMATION = 0x00000100;

    [NativeTypeName("#define BSF_RESIZABLE 0x00000200")]
    public const int BSF_RESIZABLE = 0x00000200;

    [NativeTypeName("#define BSF_CANMAXIMIZE 0x00000400")]
    public const int BSF_CANMAXIMIZE = 0x00000400;

    [NativeTypeName("#define BSF_TOPBROWSER 0x00000800")]
    public const int BSF_TOPBROWSER = 0x00000800;

    [NativeTypeName("#define BSF_NAVNOHISTORY 0x00001000")]
    public const int BSF_NAVNOHISTORY = 0x00001000;

    [NativeTypeName("#define BSF_HTMLNAVCANCELED 0x00002000")]
    public const int BSF_HTMLNAVCANCELED = 0x00002000;

    [NativeTypeName("#define BSF_DONTSHOWNAVCANCELPAGE 0x00004000")]
    public const int BSF_DONTSHOWNAVCANCELPAGE = 0x00004000;

    [NativeTypeName("#define BSF_SETNAVIGATABLECODEPAGE 0x00008000")]
    public const int BSF_SETNAVIGATABLECODEPAGE = 0x00008000;

    [NativeTypeName("#define BSF_DELEGATEDNAVIGATION 0x00010000")]
    public const int BSF_DELEGATEDNAVIGATION = 0x00010000;

    [NativeTypeName("#define BSF_TRUSTEDFORACTIVEX 0x00020000")]
    public const int BSF_TRUSTEDFORACTIVEX = 0x00020000;

    [NativeTypeName("#define BSF_MERGEDMENUS 0x00040000")]
    public const int BSF_MERGEDMENUS = 0x00040000;

    [NativeTypeName("#define BSF_FEEDNAVIGATION 0x00080000")]
    public const int BSF_FEEDNAVIGATION = 0x00080000;

    [NativeTypeName("#define BSF_FEEDSUBSCRIBED 0x00100000")]
    public const int BSF_FEEDSUBSCRIBED = 0x00100000;
}
