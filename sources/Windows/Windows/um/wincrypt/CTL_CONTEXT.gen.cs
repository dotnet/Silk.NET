// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT"]/*'/>
public unsafe partial struct CTL_CONTEXT
{
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.dwMsgAndCertEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMsgAndCertEncodingType;
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.pbCtlEncoded"]/*'/>
    public byte* pbCtlEncoded;
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.cbCtlEncoded"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCtlEncoded;
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.pCtlInfo"]/*'/>
    [NativeTypeName("PCTL_INFO")]
    public CTL_INFO* pCtlInfo;
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.hCertStore"]/*'/>
    public HCERTSTORE hCertStore;
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.hCryptMsg"]/*'/>
    public HCRYPTMSG hCryptMsg;
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.pbCtlContent"]/*'/>
    public byte* pbCtlContent;
    /// <include file='CTL_CONTEXT.xml' path='doc/member[@name="CTL_CONTEXT.cbCtlContent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCtlContent;
}