// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_REGION
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint NfitHandle;
    public Guid LogicalDeviceGuid;
    public Guid AddressRangeType;

    [NativeTypeName("DWORD")]
    public uint AssociatedId;

    [NativeTypeName("DWORD64")]
    public ulong Length;

    [NativeTypeName("DWORD64")]
    public ulong StartingDPA;

    [NativeTypeName("DWORD64")]
    public ulong BaseSPA;

    [NativeTypeName("DWORD64")]
    public ulong SPAOffset;

    [NativeTypeName("DWORD64")]
    public ulong RegionOffset;
}
