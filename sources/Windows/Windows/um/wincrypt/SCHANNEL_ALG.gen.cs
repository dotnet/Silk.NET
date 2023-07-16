// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCHANNEL_ALG.xml' path='doc/member[@name="SCHANNEL_ALG"]/*'/>
public partial struct SCHANNEL_ALG
{
    /// <include file='SCHANNEL_ALG.xml' path='doc/member[@name="SCHANNEL_ALG.dwUse"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUse;
    /// <include file='SCHANNEL_ALG.xml' path='doc/member[@name="SCHANNEL_ALG.Algid"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint Algid;
    /// <include file='SCHANNEL_ALG.xml' path='doc/member[@name="SCHANNEL_ALG.cBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cBits;
    /// <include file='SCHANNEL_ALG.xml' path='doc/member[@name="SCHANNEL_ALG.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SCHANNEL_ALG.xml' path='doc/member[@name="SCHANNEL_ALG.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
}