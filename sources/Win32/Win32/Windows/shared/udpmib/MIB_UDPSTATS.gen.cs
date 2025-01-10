// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_UDPSTATS
{
    [NativeTypeName("DWORD")]
    public uint dwInDatagrams;

    [NativeTypeName("DWORD")]
    public uint dwNoPorts;

    [NativeTypeName("DWORD")]
    public uint dwInErrors;

    [NativeTypeName("DWORD")]
    public uint dwOutDatagrams;

    [NativeTypeName("DWORD")]
    public uint dwNumAddrs;
}
