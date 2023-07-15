// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TBIF
{
    [NativeTypeName("#define TBIF_APPEND 0")]
    public const int TBIF_APPEND = 0;
    [NativeTypeName("#define TBIF_PREPEND 1")]
    public const int TBIF_PREPEND = 1;
    [NativeTypeName("#define TBIF_REPLACE 2")]
    public const int TBIF_REPLACE = 2;
    [NativeTypeName("#define TBIF_DEFAULT 0x00000000")]
    public const int TBIF_DEFAULT = 0x00000000;
    [NativeTypeName("#define TBIF_INTERNETBAR 0x00010000")]
    public const int TBIF_INTERNETBAR = 0x00010000;
    [NativeTypeName("#define TBIF_STANDARDTOOLBAR 0x00020000")]
    public const int TBIF_STANDARDTOOLBAR = 0x00020000;
    [NativeTypeName("#define TBIF_NOTOOLBAR 0x00030000")]
    public const int TBIF_NOTOOLBAR = 0x00030000;
}