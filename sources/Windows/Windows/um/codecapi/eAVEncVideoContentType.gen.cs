// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='eAVEncVideoContentType.xml' path='doc/member[@name="eAVEncVideoContentType"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum eAVEncVideoContentType
{
    /// <include file='eAVEncVideoContentType.xml' path='doc/member[@name="eAVEncVideoContentType.eAVEncVideoContentType_Unknown"]/*' />
    eAVEncVideoContentType_Unknown = 0,

    /// <include file='eAVEncVideoContentType.xml' path='doc/member[@name="eAVEncVideoContentType.eAVEncVideoContentType_FixedCameraAngle"]/*' />
    eAVEncVideoContentType_FixedCameraAngle = 1,
}
