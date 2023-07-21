// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP"]/*' />
public unsafe partial struct CERT_FORTEZZA_DATA_PROP
{
    /// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP.SerialNumber"]/*' />
    [NativeTypeName("unsigned char[8]")]
    public fixed byte SerialNumber[8];

    /// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP.CertIndex"]/*' />
    public int CertIndex;

    /// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP.CertLabel"]/*' />
    [NativeTypeName("unsigned char[36]")]
    public fixed byte CertLabel[36];
}
