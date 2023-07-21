// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_TPM_SPECIFICATION_INFO.xml' path='doc/member[@name="CERT_TPM_SPECIFICATION_INFO"]/*' />
public unsafe partial struct CERT_TPM_SPECIFICATION_INFO
{
    /// <include file='CERT_TPM_SPECIFICATION_INFO.xml' path='doc/member[@name="CERT_TPM_SPECIFICATION_INFO.pwszFamily"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszFamily;

    /// <include file='CERT_TPM_SPECIFICATION_INFO.xml' path='doc/member[@name="CERT_TPM_SPECIFICATION_INFO.dwLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLevel;

    /// <include file='CERT_TPM_SPECIFICATION_INFO.xml' path='doc/member[@name="CERT_TPM_SPECIFICATION_INFO.dwRevision"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRevision;
}
