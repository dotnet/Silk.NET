// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WHV
{
    [NativeTypeName("#define WHV_E_UNKNOWN_CAPABILITY _HRESULT_TYPEDEF_(0x80370300L)")]
    public const int WHV_E_UNKNOWN_CAPABILITY = unchecked((int)(0x80370300));

    [NativeTypeName("#define WHV_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x80370301L)")]
    public const int WHV_E_INSUFFICIENT_BUFFER = unchecked((int)(0x80370301));

    [NativeTypeName("#define WHV_E_UNKNOWN_PROPERTY _HRESULT_TYPEDEF_(0x80370302L)")]
    public const int WHV_E_UNKNOWN_PROPERTY = unchecked((int)(0x80370302));

    [NativeTypeName("#define WHV_E_UNSUPPORTED_HYPERVISOR_CONFIG _HRESULT_TYPEDEF_(0x80370303L)")]
    public const int WHV_E_UNSUPPORTED_HYPERVISOR_CONFIG = unchecked((int)(0x80370303));

    [NativeTypeName("#define WHV_E_INVALID_PARTITION_CONFIG _HRESULT_TYPEDEF_(0x80370304L)")]
    public const int WHV_E_INVALID_PARTITION_CONFIG = unchecked((int)(0x80370304));

    [NativeTypeName("#define WHV_E_GPA_RANGE_NOT_FOUND _HRESULT_TYPEDEF_(0x80370305L)")]
    public const int WHV_E_GPA_RANGE_NOT_FOUND = unchecked((int)(0x80370305));

    [NativeTypeName("#define WHV_E_VP_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80370306L)")]
    public const int WHV_E_VP_ALREADY_EXISTS = unchecked((int)(0x80370306));

    [NativeTypeName("#define WHV_E_VP_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0x80370307L)")]
    public const int WHV_E_VP_DOES_NOT_EXIST = unchecked((int)(0x80370307));

    [NativeTypeName("#define WHV_E_INVALID_VP_STATE _HRESULT_TYPEDEF_(0x80370308L)")]
    public const int WHV_E_INVALID_VP_STATE = unchecked((int)(0x80370308));

    [NativeTypeName("#define WHV_E_INVALID_VP_REGISTER_NAME _HRESULT_TYPEDEF_(0x80370309L)")]
    public const int WHV_E_INVALID_VP_REGISTER_NAME = unchecked((int)(0x80370309));

    [NativeTypeName("#define WHV_E_UNSUPPORTED_PROCESSOR_CONFIG _HRESULT_TYPEDEF_(0x80370310L)")]
    public const int WHV_E_UNSUPPORTED_PROCESSOR_CONFIG = unchecked((int)(0x80370310));
}
