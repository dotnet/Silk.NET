// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ICMP_ECHO_REPLY32
{
    [NativeTypeName("IPAddr")]
    public uint Address;

    [NativeTypeName("ULONG")]
    public uint Status;

    [NativeTypeName("ULONG")]
    public uint RoundTripTime;
    public ushort DataSize;
    public ushort Reserved;

    [NativeTypeName("void * __ptr32")]
    public void* Data;

    [NativeTypeName("struct ip_option_information32")]
    public IP_OPTION_INFORMATION32 Options;
}
