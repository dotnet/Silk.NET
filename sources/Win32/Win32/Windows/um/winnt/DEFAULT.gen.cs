// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SECURITY_IMPERSONATION_LEVEL;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DEFAULT
{
    [NativeTypeName("#define DEFAULT_IMPERSONATION_LEVEL SecurityImpersonation")]
    public const SECURITY_IMPERSONATION_LEVEL DEFAULT_IMPERSONATION_LEVEL = SecurityImpersonation;
}
