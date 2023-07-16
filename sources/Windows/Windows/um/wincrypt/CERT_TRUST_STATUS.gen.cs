// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_TRUST_STATUS.xml' path='doc/member[@name="CERT_TRUST_STATUS"]/*'/>
public partial struct CERT_TRUST_STATUS
{
    /// <include file='CERT_TRUST_STATUS.xml' path='doc/member[@name="CERT_TRUST_STATUS.dwErrorStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwErrorStatus;
    /// <include file='CERT_TRUST_STATUS.xml' path='doc/member[@name="CERT_TRUST_STATUS.dwInfoStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInfoStatus;
}