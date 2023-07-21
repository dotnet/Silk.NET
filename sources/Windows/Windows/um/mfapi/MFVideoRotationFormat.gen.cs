// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MFVideoRotationFormat.xml' path='doc/member[@name="MFVideoRotationFormat"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MFVideoRotationFormat
{
    /// <include file='MFVideoRotationFormat.xml' path='doc/member[@name="MFVideoRotationFormat.MFVideoRotationFormat_0"]/*' />
    MFVideoRotationFormat_0 = 0,

    /// <include file='MFVideoRotationFormat.xml' path='doc/member[@name="MFVideoRotationFormat.MFVideoRotationFormat_90"]/*' />
    MFVideoRotationFormat_90 = 90,

    /// <include file='MFVideoRotationFormat.xml' path='doc/member[@name="MFVideoRotationFormat.MFVideoRotationFormat_180"]/*' />
    MFVideoRotationFormat_180 = 180,

    /// <include file='MFVideoRotationFormat.xml' path='doc/member[@name="MFVideoRotationFormat.MFVideoRotationFormat_270"]/*' />
    MFVideoRotationFormat_270 = 270,
}
