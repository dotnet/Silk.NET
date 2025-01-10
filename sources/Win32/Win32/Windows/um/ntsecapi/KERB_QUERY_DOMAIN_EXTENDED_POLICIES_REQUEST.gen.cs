// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST
{
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
}
