// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TIME
{
    [NativeTypeName("#define TIME_ZONE_ID_UNKNOWN 0")]
    public const int TIME_ZONE_ID_UNKNOWN = 0;
    [NativeTypeName("#define TIME_ZONE_ID_STANDARD 1")]
    public const int TIME_ZONE_ID_STANDARD = 1;
    [NativeTypeName("#define TIME_ZONE_ID_DAYLIGHT 2")]
    public const int TIME_ZONE_ID_DAYLIGHT = 2;
}