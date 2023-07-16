// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SERVICE_SECURITY_IDENTITIES.xml' path='doc/member[@name="WS_SERVICE_SECURITY_IDENTITIES"]/*'/>
public unsafe partial struct WS_SERVICE_SECURITY_IDENTITIES
{
    /// <include file='WS_SERVICE_SECURITY_IDENTITIES.xml' path='doc/member[@name="WS_SERVICE_SECURITY_IDENTITIES.serviceIdentities"]/*'/>
    public WS_STRING* serviceIdentities;
    /// <include file='WS_SERVICE_SECURITY_IDENTITIES.xml' path='doc/member[@name="WS_SERVICE_SECURITY_IDENTITIES.serviceIdentityCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint serviceIdentityCount;
}