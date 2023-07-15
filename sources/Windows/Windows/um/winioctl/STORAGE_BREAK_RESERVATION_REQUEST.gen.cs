// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_BREAK_RESERVATION_REQUEST.xml' path='doc/member[@name="STORAGE_BREAK_RESERVATION_REQUEST"]/*'/>
public partial struct STORAGE_BREAK_RESERVATION_REQUEST
{
    /// <include file='STORAGE_BREAK_RESERVATION_REQUEST.xml' path='doc/member[@name="STORAGE_BREAK_RESERVATION_REQUEST.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='STORAGE_BREAK_RESERVATION_REQUEST.xml' path='doc/member[@name="STORAGE_BREAK_RESERVATION_REQUEST._unused"]/*'/>
    public byte _unused;
    /// <include file='STORAGE_BREAK_RESERVATION_REQUEST.xml' path='doc/member[@name="STORAGE_BREAK_RESERVATION_REQUEST.PathId"]/*'/>
    public byte PathId;
    /// <include file='STORAGE_BREAK_RESERVATION_REQUEST.xml' path='doc/member[@name="STORAGE_BREAK_RESERVATION_REQUEST.TargetId"]/*'/>
    public byte TargetId;
    /// <include file='STORAGE_BREAK_RESERVATION_REQUEST.xml' path='doc/member[@name="STORAGE_BREAK_RESERVATION_REQUEST.Lun"]/*'/>
    public byte Lun;
}