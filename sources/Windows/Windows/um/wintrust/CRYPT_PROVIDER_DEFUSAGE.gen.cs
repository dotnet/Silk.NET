// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CRYPT_PROVIDER_DEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_DEFUSAGE"]/*' />
public unsafe partial struct CRYPT_PROVIDER_DEFUSAGE
{
    /// <include file='CRYPT_PROVIDER_DEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_DEFUSAGE.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='CRYPT_PROVIDER_DEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_DEFUSAGE.gActionID"]/*' />
    public Guid gActionID;

    /// <include file='CRYPT_PROVIDER_DEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_DEFUSAGE.pDefPolicyCallbackData"]/*' />
    [NativeTypeName("LPVOID")]
    public void* pDefPolicyCallbackData;

    /// <include file='CRYPT_PROVIDER_DEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_DEFUSAGE.pDefSIPClientData"]/*' />
    [NativeTypeName("LPVOID")]
    public void* pDefSIPClientData;
}
