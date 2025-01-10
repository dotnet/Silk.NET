// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFT_ENUM_DATA_V1
{
    [NativeTypeName("DWORDLONG")]
    public ulong StartFileReferenceNumber;

    [NativeTypeName("USN")]
    public long LowUsn;

    [NativeTypeName("USN")]
    public long HighUsn;

    [NativeTypeName("WORD")]
    public ushort MinMajorVersion;

    [NativeTypeName("WORD")]
    public ushort MaxMajorVersion;
}
