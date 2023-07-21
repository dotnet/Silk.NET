// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class POLICY
{
    [NativeTypeName("#define POLICY_AUDIT_SUBCATEGORY_COUNT (59)")]
    public const int POLICY_AUDIT_SUBCATEGORY_COUNT = (59);
}
