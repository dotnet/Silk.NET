// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CameraControlFlags.xml' path='doc/member[@name="CameraControlFlags"]/*' />
public enum CameraControlFlags
{
    /// <include file='CameraControlFlags.xml' path='doc/member[@name="CameraControlFlags.CameraControl_Flags_Auto"]/*' />
    CameraControl_Flags_Auto = 0x1,

    /// <include file='CameraControlFlags.xml' path='doc/member[@name="CameraControlFlags.CameraControl_Flags_Manual"]/*' />
    CameraControl_Flags_Manual = 0x2,
}
