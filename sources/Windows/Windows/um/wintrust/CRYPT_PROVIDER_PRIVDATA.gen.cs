// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CRYPT_PROVIDER_PRIVDATA.xml' path='doc/member[@name="CRYPT_PROVIDER_PRIVDATA"]/*' />
public unsafe partial struct CRYPT_PROVIDER_PRIVDATA
{
    /// <include file='CRYPT_PROVIDER_PRIVDATA.xml' path='doc/member[@name="CRYPT_PROVIDER_PRIVDATA.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='CRYPT_PROVIDER_PRIVDATA.xml' path='doc/member[@name="CRYPT_PROVIDER_PRIVDATA.gProviderID"]/*' />
    public Guid gProviderID;

    /// <include file='CRYPT_PROVIDER_PRIVDATA.xml' path='doc/member[@name="CRYPT_PROVIDER_PRIVDATA.cbProvData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbProvData;

    /// <include file='CRYPT_PROVIDER_PRIVDATA.xml' path='doc/member[@name="CRYPT_PROVIDER_PRIVDATA.pvProvData"]/*' />
    public void* pvProvData;
}
