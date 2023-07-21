// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GCS
{
    [NativeTypeName("#define GCS_COMP (GCS_COMPSTR|GCS_COMPATTR|GCS_COMPCLAUSE)")]
    public const int GCS_COMP = (0x0008 | 0x0010 | 0x0020);

    [NativeTypeName("#define GCS_COMPREAD (GCS_COMPREADSTR|GCS_COMPREADATTR |GCS_COMPREADCLAUSE)")]
    public const int GCS_COMPREAD = (0x0001 | 0x0002 | 0x0004);

    [NativeTypeName("#define GCS_RESULT (GCS_RESULTSTR|GCS_RESULTCLAUSE)")]
    public const int GCS_RESULT = (0x0800 | 0x1000);

    [NativeTypeName("#define GCS_RESULTREAD (GCS_RESULTREADSTR|GCS_RESULTREADCLAUSE)")]
    public const int GCS_RESULTREAD = (0x0200 | 0x0400);
}
