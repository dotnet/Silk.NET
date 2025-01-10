// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IMAGE_POLICY_ENTRY_TYPE
{
    ImagePolicyEntryTypeNone = 0,
    ImagePolicyEntryTypeBool,
    ImagePolicyEntryTypeInt8,
    ImagePolicyEntryTypeUInt8,
    ImagePolicyEntryTypeInt16,
    ImagePolicyEntryTypeUInt16,
    ImagePolicyEntryTypeInt32,
    ImagePolicyEntryTypeUInt32,
    ImagePolicyEntryTypeInt64,
    ImagePolicyEntryTypeUInt64,
    ImagePolicyEntryTypeAnsiString,
    ImagePolicyEntryTypeUnicodeString,
    ImagePolicyEntryTypeOverride,
    ImagePolicyEntryTypeMaximum,
}
