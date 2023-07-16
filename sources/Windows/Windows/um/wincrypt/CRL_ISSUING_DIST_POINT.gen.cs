// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRL_ISSUING_DIST_POINT.xml' path='doc/member[@name="CRL_ISSUING_DIST_POINT"]/*'/>
public partial struct CRL_ISSUING_DIST_POINT
{
    /// <include file='CRL_ISSUING_DIST_POINT.xml' path='doc/member[@name="CRL_ISSUING_DIST_POINT.DistPointName"]/*'/>
    public CRL_DIST_POINT_NAME DistPointName;
    /// <include file='CRL_ISSUING_DIST_POINT.xml' path='doc/member[@name="CRL_ISSUING_DIST_POINT.fOnlyContainsUserCerts"]/*'/>
    public BOOL fOnlyContainsUserCerts;
    /// <include file='CRL_ISSUING_DIST_POINT.xml' path='doc/member[@name="CRL_ISSUING_DIST_POINT.fOnlyContainsCACerts"]/*'/>
    public BOOL fOnlyContainsCACerts;
    /// <include file='CRL_ISSUING_DIST_POINT.xml' path='doc/member[@name="CRL_ISSUING_DIST_POINT.OnlySomeReasonFlags"]/*'/>
    public CRYPT_BIT_BLOB OnlySomeReasonFlags;
    /// <include file='CRL_ISSUING_DIST_POINT.xml' path='doc/member[@name="CRL_ISSUING_DIST_POINT.fIndirectCRL"]/*'/>
    public BOOL fIndirectCRL;
}