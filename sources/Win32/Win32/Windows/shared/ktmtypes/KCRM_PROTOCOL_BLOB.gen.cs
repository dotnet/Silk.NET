// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KCRM_PROTOCOL_BLOB
{
    [NativeTypeName("CRM_PROTOCOL_ID")]
    public Guid ProtocolId;

    [NativeTypeName("ULONG")]
    public uint StaticInfoLength;

    [NativeTypeName("ULONG")]
    public uint TransactionIdInfoLength;

    [NativeTypeName("ULONG")]
    public uint Unused1;

    [NativeTypeName("ULONG")]
    public uint Unused2;
}
