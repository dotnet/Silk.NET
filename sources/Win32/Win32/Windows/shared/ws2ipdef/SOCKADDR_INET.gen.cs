// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct SOCKADDR_INET
{
    [FieldOffset(0)]
    public SOCKADDR_IN Ipv4;

    [FieldOffset(0)]
    public SOCKADDR_IN6 Ipv6;

    [FieldOffset(0)]
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort si_family;
}
