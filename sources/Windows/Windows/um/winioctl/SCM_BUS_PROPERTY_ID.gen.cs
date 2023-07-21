// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCM_BUS_PROPERTY_ID.xml' path='doc/member[@name="SCM_BUS_PROPERTY_ID"]/*' />
public enum SCM_BUS_PROPERTY_ID
{
    /// <include file='SCM_BUS_PROPERTY_ID.xml' path='doc/member[@name="SCM_BUS_PROPERTY_ID.ScmBusProperty_RuntimeFwActivationInfo"]/*' />
    ScmBusProperty_RuntimeFwActivationInfo = 0,

    /// <include file='SCM_BUS_PROPERTY_ID.xml' path='doc/member[@name="SCM_BUS_PROPERTY_ID.ScmBusProperty_DedicatedMemoryInfo"]/*' />
    ScmBusProperty_DedicatedMemoryInfo = 1,

    /// <include file='SCM_BUS_PROPERTY_ID.xml' path='doc/member[@name="SCM_BUS_PROPERTY_ID.ScmBusProperty_DedicatedMemoryState"]/*' />
    ScmBusProperty_DedicatedMemoryState = 2,

    /// <include file='SCM_BUS_PROPERTY_ID.xml' path='doc/member[@name="SCM_BUS_PROPERTY_ID.ScmBusProperty_Max"]/*' />
    ScmBusProperty_Max,
}
