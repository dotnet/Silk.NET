// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct WCM_TIME_INTERVAL
{
    [NativeTypeName("WORD")]
    public ushort wYear;

    [NativeTypeName("WORD")]
    public ushort wMonth;

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
