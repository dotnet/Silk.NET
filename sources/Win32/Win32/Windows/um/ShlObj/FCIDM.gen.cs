// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FCIDM
{
    [NativeTypeName("#define FCIDM_TOOLBAR (FCIDM_BROWSERFIRST + 0)")]
    public const int FCIDM_TOOLBAR = (0xa000 + 0);

    [NativeTypeName("#define FCIDM_STATUS (FCIDM_BROWSERFIRST + 1)")]
    public const int FCIDM_STATUS = (0xa000 + 1);
}
