// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCM_PD_DEVICE_SPECIFIC_PROPERTY.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_PROPERTY"]/*' />
public unsafe partial struct SCM_PD_DEVICE_SPECIFIC_PROPERTY
{
    /// <include file='SCM_PD_DEVICE_SPECIFIC_PROPERTY.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_PROPERTY.Name"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort Name[128];

    /// <include file='SCM_PD_DEVICE_SPECIFIC_PROPERTY.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_PROPERTY.Value"]/*' />
    [NativeTypeName("LONGLONG")]
    public long Value;
}
