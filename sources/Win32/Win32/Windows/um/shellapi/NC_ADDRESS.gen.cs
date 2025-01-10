// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct NC_ADDRESS
{
    [NativeTypeName("struct NET_ADDRESS_INFO_ *")]
    public NET_ADDRESS_INFO* pAddrInfo;
    public ushort PortNumber;
    public byte PrefixLength;
}
