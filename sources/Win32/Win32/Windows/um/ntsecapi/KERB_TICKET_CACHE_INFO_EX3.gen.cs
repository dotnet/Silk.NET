// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KERB_TICKET_CACHE_INFO_EX3
{
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientRealm;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerRealm;
    public LARGE_INTEGER StartTime;
    public LARGE_INTEGER EndTime;
    public LARGE_INTEGER RenewTime;

    [NativeTypeName("LONG")]
    public int EncryptionType;

    [NativeTypeName("ULONG")]
    public uint TicketFlags;

    [NativeTypeName("ULONG")]
    public uint SessionKeyType;

    [NativeTypeName("ULONG")]
    public uint BranchId;

    [NativeTypeName("ULONG")]
    public uint CacheFlags;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING KdcCalled;
}
