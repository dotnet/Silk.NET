// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRL_DIST_POINTS_INFO.xml' path='doc/member[@name="CRL_DIST_POINTS_INFO"]/*' />
public unsafe partial struct CRL_DIST_POINTS_INFO
{
    /// <include file='CRL_DIST_POINTS_INFO.xml' path='doc/member[@name="CRL_DIST_POINTS_INFO.cDistPoint"]/*' />
    [NativeTypeName("DWORD")]
    public uint cDistPoint;

    /// <include file='CRL_DIST_POINTS_INFO.xml' path='doc/member[@name="CRL_DIST_POINTS_INFO.rgDistPoint"]/*' />
    [NativeTypeName("PCRL_DIST_POINT")]
    public CRL_DIST_POINT* rgDistPoint;
}
