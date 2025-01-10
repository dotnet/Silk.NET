// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct KERB_QUERY_S4U2PROXY_CACHE_RESPONSE
{
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    [NativeTypeName("ULONG")]
    public uint CountOfCreds;

    [NativeTypeName("PKERB_S4U2PROXY_CRED")]
    public KERB_S4U2PROXY_CRED* Creds;
}
