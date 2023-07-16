// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_EVENT_NOTIFICATION.xml' path='doc/member[@name="STORAGE_EVENT_NOTIFICATION"]/*'/>
public partial struct STORAGE_EVENT_NOTIFICATION
{
    /// <include file='STORAGE_EVENT_NOTIFICATION.xml' path='doc/member[@name="STORAGE_EVENT_NOTIFICATION.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_EVENT_NOTIFICATION.xml' path='doc/member[@name="STORAGE_EVENT_NOTIFICATION.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_EVENT_NOTIFICATION.xml' path='doc/member[@name="STORAGE_EVENT_NOTIFICATION.Events"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Events;
}