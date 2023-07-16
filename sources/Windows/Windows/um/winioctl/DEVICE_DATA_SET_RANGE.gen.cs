// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DEVICE_DATA_SET_RANGE.xml' path='doc/member[@name="DEVICE_DATA_SET_RANGE"]/*'/>
public partial struct DEVICE_DATA_SET_RANGE
{
    /// <include file='DEVICE_DATA_SET_RANGE.xml' path='doc/member[@name="DEVICE_DATA_SET_RANGE.StartingOffset"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long StartingOffset;
    /// <include file='DEVICE_DATA_SET_RANGE.xml' path='doc/member[@name="DEVICE_DATA_SET_RANGE.LengthInBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LengthInBytes;
}