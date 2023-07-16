// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE"]/*'/>
public unsafe partial struct SCHANNEL_CLIENT_SIGNATURE
{
    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.cbLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbLength;
    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.aiHash"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint aiHash;
    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.cbHash"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbHash;
    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.HashValue"]/*'/>
    [NativeTypeName("BYTE[36]")]
    public fixed byte HashValue[36];
    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.CertThumbprint"]/*'/>
    [NativeTypeName("BYTE[20]")]
    public fixed byte CertThumbprint[20];
}