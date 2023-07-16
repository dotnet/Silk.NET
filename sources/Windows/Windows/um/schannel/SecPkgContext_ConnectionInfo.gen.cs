// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo"]/*'/>
public partial struct SecPkgContext_ConnectionInfo
{
    /// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo.dwProtocol"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProtocol;
    /// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo.aiCipher"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint aiCipher;
    /// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo.dwCipherStrength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCipherStrength;
    /// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo.aiHash"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint aiHash;
    /// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo.dwHashStrength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHashStrength;
    /// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo.aiExch"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint aiExch;
    /// <include file='SecPkgContext_ConnectionInfo.xml' path='doc/member[@name="SecPkgContext_ConnectionInfo.dwExchStrength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwExchStrength;
}