// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCM_PD_SET_TYPE.xml' path='doc/member[@name="SCM_PD_SET_TYPE"]/*' />
public enum SCM_PD_SET_TYPE
{
    /// <include file='SCM_PD_SET_TYPE.xml' path='doc/member[@name="SCM_PD_SET_TYPE.ScmPhysicalDeviceSet_Descriptor"]/*' />
    ScmPhysicalDeviceSet_Descriptor = 0,

    /// <include file='SCM_PD_SET_TYPE.xml' path='doc/member[@name="SCM_PD_SET_TYPE.ScmPhysicalDeviceSet_IsSupported"]/*' />
    ScmPhysicalDeviceSet_IsSupported,

    /// <include file='SCM_PD_SET_TYPE.xml' path='doc/member[@name="SCM_PD_SET_TYPE.ScmPhysicalDeviceSet_Max"]/*' />
    ScmPhysicalDeviceSet_Max,
}
