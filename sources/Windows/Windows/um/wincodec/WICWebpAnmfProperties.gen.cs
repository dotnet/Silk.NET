// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WICWebpAnmfProperties.xml' path='doc/member[@name="WICWebpAnmfProperties"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public enum WICWebpAnmfProperties
{
    /// <include file='WICWebpAnmfProperties.xml' path='doc/member[@name="WICWebpAnmfProperties.WICWebpAnmfFrameDuration"]/*' />
    WICWebpAnmfFrameDuration = 0x1,

    /// <include file='WICWebpAnmfProperties.xml' path='doc/member[@name="WICWebpAnmfProperties.WICWebpAnmfProperties_FORCE_DWORD"]/*' />
    WICWebpAnmfProperties_FORCE_DWORD = 0x7fffffff,
}
