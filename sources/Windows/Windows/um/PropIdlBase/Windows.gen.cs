// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define PROPSETFLAG_DEFAULT ( 0 )")]
    public const int PROPSETFLAG_DEFAULT = (0);

    [NativeTypeName("#define PROPSETFLAG_NONSIMPLE ( 1 )")]
    public const int PROPSETFLAG_NONSIMPLE = (1);

    [NativeTypeName("#define PROPSETFLAG_ANSI ( 2 )")]
    public const int PROPSETFLAG_ANSI = (2);

    [NativeTypeName("#define PROPSETFLAG_UNBUFFERED ( 4 )")]
    public const int PROPSETFLAG_UNBUFFERED = (4);

    [NativeTypeName("#define PROPSETFLAG_CASE_SENSITIVE ( 8 )")]
    public const int PROPSETFLAG_CASE_SENSITIVE = (8);

    [NativeTypeName("#define PROPSET_BEHAVIOR_CASE_SENSITIVE ( 1 )")]
    public const int PROPSET_BEHAVIOR_CASE_SENSITIVE = (1);

    [NativeTypeName("#define PRSPEC_INVALID ( 0xffffffff )")]
    public const uint PRSPEC_INVALID = (0xffffffff);

    [NativeTypeName("#define PRSPEC_LPWSTR ( 0 )")]
    public const int PRSPEC_LPWSTR = (0);

    [NativeTypeName("#define PRSPEC_PROPID ( 1 )")]
    public const int PRSPEC_PROPID = (1);

    [NativeTypeName("#define PROPSETHDR_OSVERSION_UNKNOWN 0xFFFFFFFF")]
    public const uint PROPSETHDR_OSVERSION_UNKNOWN = 0xFFFFFFFF;
}
