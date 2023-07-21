// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='VIRTUALIZATION_INSTANCE_INFO_OUTPUT.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_OUTPUT"]/*' />
public partial struct VIRTUALIZATION_INSTANCE_INFO_OUTPUT
{
    /// <include file='VIRTUALIZATION_INSTANCE_INFO_OUTPUT.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_OUTPUT.VirtualizationInstanceID"]/*' />
    public Guid VirtualizationInstanceID;
}
