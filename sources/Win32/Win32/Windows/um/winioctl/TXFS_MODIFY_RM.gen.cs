// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TXFS_MODIFY_RM
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint LogContainerCountMax;

    [NativeTypeName("DWORD")]
    public uint LogContainerCountMin;

    [NativeTypeName("DWORD")]
    public uint LogContainerCount;

    [NativeTypeName("DWORD")]
    public uint LogGrowthIncrement;

    [NativeTypeName("DWORD")]
    public uint LogAutoShrinkPercentage;

    [NativeTypeName("DWORDLONG")]
    public ulong Reserved;

    [NativeTypeName("WORD")]
    public ushort LoggingMode;
}
