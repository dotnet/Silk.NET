// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ES
{
    [NativeTypeName("#define ES_EX_ALLOWEOL_CR 0x0001L")]
    public const int ES_EX_ALLOWEOL_CR = 0x0001;

    [NativeTypeName("#define ES_EX_ALLOWEOL_LF 0x0002L")]
    public const int ES_EX_ALLOWEOL_LF = 0x0002;

    [NativeTypeName("#define ES_EX_ALLOWEOL_ALL (ES_EX_ALLOWEOL_CR | ES_EX_ALLOWEOL_LF)")]
    public const int ES_EX_ALLOWEOL_ALL = (0x0001 | 0x0002);

    [NativeTypeName("#define ES_EX_CONVERT_EOL_ON_PASTE 0x0004L")]
    public const int ES_EX_CONVERT_EOL_ON_PASTE = 0x0004;

    [NativeTypeName("#define ES_EX_ZOOMABLE 0x0010L")]
    public const int ES_EX_ZOOMABLE = 0x0010;
}
