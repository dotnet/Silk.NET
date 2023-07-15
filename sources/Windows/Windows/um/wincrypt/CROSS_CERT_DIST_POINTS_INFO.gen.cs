// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CROSS_CERT_DIST_POINTS_INFO.xml' path='doc/member[@name="CROSS_CERT_DIST_POINTS_INFO"]/*'/>
public unsafe partial struct CROSS_CERT_DIST_POINTS_INFO
{
    /// <include file='CROSS_CERT_DIST_POINTS_INFO.xml' path='doc/member[@name="CROSS_CERT_DIST_POINTS_INFO.dwSyncDeltaTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSyncDeltaTime;
    /// <include file='CROSS_CERT_DIST_POINTS_INFO.xml' path='doc/member[@name="CROSS_CERT_DIST_POINTS_INFO.cDistPoint"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cDistPoint;
    /// <include file='CROSS_CERT_DIST_POINTS_INFO.xml' path='doc/member[@name="CROSS_CERT_DIST_POINTS_INFO.rgDistPoint"]/*'/>
    [NativeTypeName("PCERT_ALT_NAME_INFO")]
    public CERT_ALT_NAME_INFO* rgDistPoint;
}