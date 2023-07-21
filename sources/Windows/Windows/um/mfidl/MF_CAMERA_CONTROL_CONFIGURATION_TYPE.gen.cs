// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_CAMERA_CONTROL_CONFIGURATION_TYPE.xml' path='doc/member[@name="MF_CAMERA_CONTROL_CONFIGURATION_TYPE"]/*' />
public enum MF_CAMERA_CONTROL_CONFIGURATION_TYPE
{
    /// <include file='MF_CAMERA_CONTROL_CONFIGURATION_TYPE.xml' path='doc/member[@name="MF_CAMERA_CONTROL_CONFIGURATION_TYPE.MF_CAMERA_CONTROL_CONFIGURATION_TYPE_PRESTART"]/*' />
    MF_CAMERA_CONTROL_CONFIGURATION_TYPE_PRESTART = 0,

    /// <include file='MF_CAMERA_CONTROL_CONFIGURATION_TYPE.xml' path='doc/member[@name="MF_CAMERA_CONTROL_CONFIGURATION_TYPE.MF_CAMERA_CONTROL_CONFIGURATION_TYPE_POSTSTART"]/*' />
    MF_CAMERA_CONTROL_CONFIGURATION_TYPE_POSTSTART = (MF_CAMERA_CONTROL_CONFIGURATION_TYPE_PRESTART + 1),
}
