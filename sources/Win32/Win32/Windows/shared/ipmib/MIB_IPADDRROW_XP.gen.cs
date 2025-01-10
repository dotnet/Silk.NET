// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IPADDRROW_XP
{
    [NativeTypeName("DWORD")]
    public uint dwAddr;

    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;

    [NativeTypeName("DWORD")]
    public uint dwMask;

    [NativeTypeName("DWORD")]
    public uint dwBCastAddr;

    [NativeTypeName("DWORD")]
    public uint dwReasmSize;

    [NativeTypeName("unsigned short")]
    public ushort unused1;

    [NativeTypeName("unsigned short")]
    public ushort wType;
}
