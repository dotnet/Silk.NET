// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SECURITY_IMPERSONATION_LEVEL;

namespace TerraFX.Interop.Windows;
public static partial class SECURITY
{
    [NativeTypeName("#define SECURITY_ANONYMOUS ( SecurityAnonymous      << 16 )")]
    public const int SECURITY_ANONYMOUS = ((int)(SecurityAnonymous) << 16);
    [NativeTypeName("#define SECURITY_IDENTIFICATION ( SecurityIdentification << 16 )")]
    public const int SECURITY_IDENTIFICATION = ((int)(SecurityIdentification) << 16);
    [NativeTypeName("#define SECURITY_IMPERSONATION ( SecurityImpersonation  << 16 )")]
    public const int SECURITY_IMPERSONATION = ((int)(SecurityImpersonation) << 16);
    [NativeTypeName("#define SECURITY_DELEGATION ( SecurityDelegation     << 16 )")]
    public const int SECURITY_DELEGATION = ((int)(SecurityDelegation) << 16);
    [NativeTypeName("#define SECURITY_CONTEXT_TRACKING 0x00040000")]
    public const int SECURITY_CONTEXT_TRACKING = 0x00040000;
    [NativeTypeName("#define SECURITY_EFFECTIVE_ONLY 0x00080000")]
    public const int SECURITY_EFFECTIVE_ONLY = 0x00080000;
    [NativeTypeName("#define SECURITY_SQOS_PRESENT 0x00100000")]
    public const int SECURITY_SQOS_PRESENT = 0x00100000;
    [NativeTypeName("#define SECURITY_VALID_SQOS_FLAGS 0x001F0000")]
    public const int SECURITY_VALID_SQOS_FLAGS = 0x001F0000;
}