// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS"]/*'/>
public unsafe partial struct CTL_VERIFY_USAGE_STATUS
{
    /// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS.dwError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwError;
    /// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS.ppCtl"]/*'/>
    [NativeTypeName("PCCTL_CONTEXT *")]
    public CTL_CONTEXT** ppCtl;
    /// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS.dwCtlEntryIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCtlEntryIndex;
    /// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS.ppSigner"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT *")]
    public CERT_CONTEXT** ppSigner;
    /// <include file='CTL_VERIFY_USAGE_STATUS.xml' path='doc/member[@name="CTL_VERIFY_USAGE_STATUS.dwSignerIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignerIndex;
}