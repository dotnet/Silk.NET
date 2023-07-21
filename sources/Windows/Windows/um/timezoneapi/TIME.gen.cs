// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class TIME
{
    [NativeTypeName("#define TIME_ZONE_ID_INVALID ((DWORD)0xFFFFFFFF)")]
    public const uint TIME_ZONE_ID_INVALID = ((uint)(0xFFFFFFFF));
}
