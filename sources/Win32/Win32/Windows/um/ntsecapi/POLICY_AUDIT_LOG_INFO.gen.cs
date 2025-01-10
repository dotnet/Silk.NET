// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct POLICY_AUDIT_LOG_INFO
{
    [NativeTypeName("ULONG")]
    public uint AuditLogPercentFull;

    [NativeTypeName("ULONG")]
    public uint MaximumLogSize;
    public LARGE_INTEGER AuditRetentionPeriod;

    [NativeTypeName("BOOLEAN")]
    public byte AuditLogFullShutdownInProgress;
    public LARGE_INTEGER TimeToShutdown;

    [NativeTypeName("ULONG")]
    public uint NextAuditRecordId;
}
