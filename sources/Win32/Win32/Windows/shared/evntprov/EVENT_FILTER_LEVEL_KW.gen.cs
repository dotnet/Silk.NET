// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EVENT_FILTER_LEVEL_KW
{
    [NativeTypeName("ULONGLONG")]
    public ulong MatchAnyKeyword;

    [NativeTypeName("ULONGLONG")]
    public ulong MatchAllKeyword;

    [NativeTypeName("UCHAR")]
    public byte Level;

    [NativeTypeName("BOOLEAN")]
    public byte FilterIn;
}
