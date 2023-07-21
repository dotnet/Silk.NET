// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class STR
{
    [NativeTypeName("#define STR_PARSE_WITH_PROPERTIES L\"ParseWithProperties\"")]
    public const string STR_PARSE_WITH_PROPERTIES = "ParseWithProperties";

    [NativeTypeName("#define STR_PARSE_PARTIAL_IDLIST L\"ParseOriginalItem\"")]
    public const string STR_PARSE_PARTIAL_IDLIST = "ParseOriginalItem";
}
