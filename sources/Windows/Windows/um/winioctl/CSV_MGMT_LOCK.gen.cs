// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CSV_MGMT_LOCK.xml' path='doc/member[@name="CSV_MGMT_LOCK"]/*'/>
public partial struct CSV_MGMT_LOCK
{
    /// <include file='CSV_MGMT_LOCK.xml' path='doc/member[@name="CSV_MGMT_LOCK.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}