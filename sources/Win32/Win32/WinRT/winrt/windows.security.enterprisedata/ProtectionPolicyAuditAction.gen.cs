// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ProtectionPolicyAuditAction
{
    ProtectionPolicyAuditAction_Decrypt = 0,
    ProtectionPolicyAuditAction_CopyToLocation = 1,
    ProtectionPolicyAuditAction_SendToRecipient = 2,
    ProtectionPolicyAuditAction_Other = 3,
}
