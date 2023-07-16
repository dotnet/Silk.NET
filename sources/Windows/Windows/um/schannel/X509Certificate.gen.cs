// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate"]/*'/>
public unsafe partial struct X509Certificate
{
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.SerialNumber"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint SerialNumber[4];
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.SignatureAlgorithm"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint SignatureAlgorithm;
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.ValidFrom"]/*'/>
    public FILETIME ValidFrom;
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.ValidUntil"]/*'/>
    public FILETIME ValidUntil;
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.pszIssuer"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* pszIssuer;
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.pszSubject"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* pszSubject;
    /// <include file='X509Certificate.xml' path='doc/member[@name="X509Certificate.pPublicKey"]/*'/>
    public PctPublicKey* pPublicKey;
}