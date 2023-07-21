// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class S
{
    [NativeTypeName("#define S_OK ((HRESULT)0L)")]
    public const int S_OK = ((int)(0));

    [NativeTypeName("#define S_FALSE ((HRESULT)1L)")]
    public const int S_FALSE = ((int)(1));

    [NativeTypeName("#define S_STORE_LAUNCHED_FOR_REMEDIATION _HRESULT_TYPEDEF_(0x00270258L)")]
    public const int S_STORE_LAUNCHED_FOR_REMEDIATION = ((int)(0x00270258));

    [NativeTypeName("#define S_APPLICATION_ACTIVATION_ERROR_HANDLED_BY_DIALOG _HRESULT_TYPEDEF_(0x00270259L)")]
    public const int S_APPLICATION_ACTIVATION_ERROR_HANDLED_BY_DIALOG = ((int)(0x00270259));
}
