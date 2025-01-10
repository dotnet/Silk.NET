// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEMTIME
{
    [NativeTypeName("WORD")]
    public ushort wYear;

    [NativeTypeName("WORD")]
    public ushort wMonth;

    [NativeTypeName("WORD")]
    public ushort wDayOfWeek;

    [NativeTypeName("WORD")]
    public ushort wDay;

    [NativeTypeName("WORD")]
    public ushort wHour;

    [NativeTypeName("WORD")]
    public ushort wMinute;

    [NativeTypeName("WORD")]
    public ushort wSecond;

    [NativeTypeName("WORD")]
    public ushort wMilliseconds;
}
