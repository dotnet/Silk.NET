// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CENTRAL_ACCESSPOLICY
{
    [NativeTypeName("#define CENTRAL_ACCESS_POLICY_OWNER_RIGHTS_PRESENT_FLAG 0x00000001")]
    public const int CENTRAL_ACCESS_POLICY_OWNER_RIGHTS_PRESENT_FLAG = 0x00000001;

    [NativeTypeName("#define CENTRAL_ACCESS_POLICY_STAGED_OWNER_RIGHTS_PRESENT_FLAG 0x00000100")]
    public const int CENTRAL_ACCESS_POLICY_STAGED_OWNER_RIGHTS_PRESENT_FLAG = 0x00000100;

    [NativeTypeName("#define CENTRAL_ACCESS_POLICY_STAGED_FLAG 0x00010000")]
    public const int CENTRAL_ACCESS_POLICY_STAGED_FLAG = 0x00010000;

    [NativeTypeName(
        "#define CENTRAL_ACCESS_POLICY_VALID_FLAG_MASK (                                                               \\\r\n            CENTRAL_ACCESS_POLICY_OWNER_RIGHTS_PRESENT_FLAG         |   \\\r\n            CENTRAL_ACCESS_POLICY_STAGED_OWNER_RIGHTS_PRESENT_FLAG  |   \\\r\n            CENTRAL_ACCESS_POLICY_STAGED_FLAG                           \\\r\n        )"
    )]
    public const int CENTRAL_ACCESS_POLICY_VALID_FLAG_MASK = (0x00000001 | 0x00000100 | 0x00010000);
}
