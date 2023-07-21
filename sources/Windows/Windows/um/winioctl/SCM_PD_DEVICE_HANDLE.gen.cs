// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SCM_PD_DEVICE_HANDLE.xml' path='doc/member[@name="SCM_PD_DEVICE_HANDLE"]/*' />
public partial struct SCM_PD_DEVICE_HANDLE
{
    /// <include file='SCM_PD_DEVICE_HANDLE.xml' path='doc/member[@name="SCM_PD_DEVICE_HANDLE.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_DEVICE_HANDLE.xml' path='doc/member[@name="SCM_PD_DEVICE_HANDLE.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_DEVICE_HANDLE.xml' path='doc/member[@name="SCM_PD_DEVICE_HANDLE.DeviceGuid"]/*' />
    public Guid DeviceGuid;

    /// <include file='SCM_PD_DEVICE_HANDLE.xml' path='doc/member[@name="SCM_PD_DEVICE_HANDLE.DeviceHandle"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceHandle;
}
