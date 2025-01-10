// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct KERB_EXTERNAL_TICKET
{
    [NativeTypeName("PKERB_EXTERNAL_NAME")]
    public KERB_EXTERNAL_NAME* ServiceName;

    [NativeTypeName("PKERB_EXTERNAL_NAME")]
    public KERB_EXTERNAL_NAME* TargetName;

    [NativeTypeName("PKERB_EXTERNAL_NAME")]
    public KERB_EXTERNAL_NAME* ClientName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING TargetDomainName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING AltTargetDomainName;
    public KERB_CRYPTO_KEY SessionKey;

    [NativeTypeName("ULONG")]
    public uint TicketFlags;

    [NativeTypeName("ULONG")]
    public uint Flags;
    public LARGE_INTEGER KeyExpirationTime;
    public LARGE_INTEGER StartTime;
    public LARGE_INTEGER EndTime;
    public LARGE_INTEGER RenewUntil;
    public LARGE_INTEGER TimeSkew;

    [NativeTypeName("ULONG")]
    public uint EncodedTicketSize;

    [NativeTypeName("PUCHAR")]
    public byte* EncodedTicket;
}
