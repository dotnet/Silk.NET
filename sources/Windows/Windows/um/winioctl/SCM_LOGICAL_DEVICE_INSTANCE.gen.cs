// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SCM_LOGICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_LOGICAL_DEVICE_INSTANCE"]/*'/>
public unsafe partial struct SCM_LOGICAL_DEVICE_INSTANCE
{
    /// <include file='SCM_LOGICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_LOGICAL_DEVICE_INSTANCE.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_LOGICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_LOGICAL_DEVICE_INSTANCE.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_LOGICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_LOGICAL_DEVICE_INSTANCE.DeviceGuid"]/*'/>
    public Guid DeviceGuid;
    /// <include file='SCM_LOGICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_LOGICAL_DEVICE_INSTANCE.SymbolicLink"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort SymbolicLink[256];
}