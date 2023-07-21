// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DETECTION_TYPE.xml' path='doc/member[@name="DETECTION_TYPE"]/*' />
public enum DETECTION_TYPE
{
    /// <include file='DETECTION_TYPE.xml' path='doc/member[@name="DETECTION_TYPE.DetectNone"]/*' />
    DetectNone,

    /// <include file='DETECTION_TYPE.xml' path='doc/member[@name="DETECTION_TYPE.DetectInt13"]/*' />
    DetectInt13,

    /// <include file='DETECTION_TYPE.xml' path='doc/member[@name="DETECTION_TYPE.DetectExInt13"]/*' />
    DetectExInt13,
}
