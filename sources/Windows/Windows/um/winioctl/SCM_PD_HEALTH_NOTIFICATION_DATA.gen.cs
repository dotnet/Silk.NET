// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SCM_PD_HEALTH_NOTIFICATION_DATA.xml' path='doc/member[@name="SCM_PD_HEALTH_NOTIFICATION_DATA"]/*'/>
public partial struct SCM_PD_HEALTH_NOTIFICATION_DATA
{
    /// <include file='SCM_PD_HEALTH_NOTIFICATION_DATA.xml' path='doc/member[@name="SCM_PD_HEALTH_NOTIFICATION_DATA.DeviceGuid"]/*'/>
    public Guid DeviceGuid;
}