// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SCM_INTERLEAVED_PD_INFO.xml' path='doc/member[@name="SCM_INTERLEAVED_PD_INFO"]/*'/>
public partial struct SCM_INTERLEAVED_PD_INFO
{
    /// <include file='SCM_INTERLEAVED_PD_INFO.xml' path='doc/member[@name="SCM_INTERLEAVED_PD_INFO.DeviceHandle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DeviceHandle;
    /// <include file='SCM_INTERLEAVED_PD_INFO.xml' path='doc/member[@name="SCM_INTERLEAVED_PD_INFO.DeviceGuid"]/*'/>
    public Guid DeviceGuid;
}