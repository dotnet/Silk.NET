// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WICHeifProperties.xml' path='doc/member[@name="WICHeifProperties"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public enum WICHeifProperties
{
    /// <include file='WICHeifProperties.xml' path='doc/member[@name="WICHeifProperties.WICHeifOrientation"]/*' />
    WICHeifOrientation = 0x1,

    /// <include file='WICHeifProperties.xml' path='doc/member[@name="WICHeifProperties.WICHeifProperties_FORCE_DWORD"]/*' />
    WICHeifProperties_FORCE_DWORD = 0x7fffffff,
}
