// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class VM
{
    [NativeTypeName(
        "#define VM_SAVED_STATE_DUMP_E_PARTITION_STATE_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370500L)"
    )]
    public const int VM_SAVED_STATE_DUMP_E_PARTITION_STATE_NOT_FOUND = unchecked((int)(0xC0370500));

    [NativeTypeName(
        "#define VM_SAVED_STATE_DUMP_E_GUEST_MEMORY_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370501L)"
    )]
    public const int VM_SAVED_STATE_DUMP_E_GUEST_MEMORY_NOT_FOUND = unchecked((int)(0xC0370501));

    [NativeTypeName(
        "#define VM_SAVED_STATE_DUMP_E_NO_VP_FOUND_IN_PARTITION_STATE _HRESULT_TYPEDEF_(0xC0370502L)"
    )]
    public const int VM_SAVED_STATE_DUMP_E_NO_VP_FOUND_IN_PARTITION_STATE = unchecked(
        (int)(0xC0370502)
    );

    [NativeTypeName(
        "#define VM_SAVED_STATE_DUMP_E_NESTED_VIRTUALIZATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0370503L)"
    )]
    public const int VM_SAVED_STATE_DUMP_E_NESTED_VIRTUALIZATION_NOT_SUPPORTED = unchecked(
        (int)(0xC0370503)
    );

    [NativeTypeName(
        "#define VM_SAVED_STATE_DUMP_E_WINDOWS_KERNEL_IMAGE_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370504L)"
    )]
    public const int VM_SAVED_STATE_DUMP_E_WINDOWS_KERNEL_IMAGE_NOT_FOUND = unchecked(
        (int)(0xC0370504)
    );

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_VA_NOT_MAPPED _HRESULT_TYPEDEF_(0xC0370505L)")]
    public const int VM_SAVED_STATE_DUMP_E_VA_NOT_MAPPED = unchecked((int)(0xC0370505));

    [NativeTypeName(
        "#define VM_SAVED_STATE_DUMP_E_INVALID_VP_STATE _HRESULT_TYPEDEF_(0xC0370506L)"
    )]
    public const int VM_SAVED_STATE_DUMP_E_INVALID_VP_STATE = unchecked((int)(0xC0370506));

    [NativeTypeName(
        "#define VM_SAVED_STATE_DUMP_E_VP_VTL_NOT_ENABLED _HRESULT_TYPEDEF_(0xC0370509L)"
    )]
    public const int VM_SAVED_STATE_DUMP_E_VP_VTL_NOT_ENABLED = unchecked((int)(0xC0370509));

    [NativeTypeName("#define VM_E_CLIENT_NAME_REQUIRED _HRESULT_TYPEDEF_(0xC0370700L)")]
    public const int VM_E_CLIENT_NAME_REQUIRED = unchecked((int)(0xC0370700));

    [NativeTypeName("#define VM_E_MODIFY_VTL2_SETTINGS_CONFLICT _HRESULT_TYPEDEF_(0xC0370701L)")]
    public const int VM_E_MODIFY_VTL2_SETTINGS_CONFLICT = unchecked((int)(0xC0370701));

    [NativeTypeName("#define VM_E_VTL2_NOT_AVAILABLE _HRESULT_TYPEDEF_(0xC0370702L)")]
    public const int VM_E_VTL2_NOT_AVAILABLE = unchecked((int)(0xC0370702));

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_IN_PROGRESS _HRESULT_TYPEDEF_(0xC0370800L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_IN_PROGRESS = unchecked((int)(0xC0370800));

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_INVALID_PROTOCOL_RESPONSE _HRESULT_TYPEDEF_(0xC0370801L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_INVALID_PROTOCOL_RESPONSE = unchecked(
        (int)(0xC0370801)
    );

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_SAVE_FAILURE _HRESULT_TYPEDEF_(0xC0370802L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_SAVE_FAILURE = unchecked((int)(0xC0370802));

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_RESTORE_FAILURE _HRESULT_TYPEDEF_(0xC0370803L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_RESTORE_FAILURE = unchecked((int)(0xC0370803));

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_NO_SAVED_STATE _HRESULT_TYPEDEF_(0xC0370804L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_NO_SAVED_STATE = unchecked((int)(0xC0370804));

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_INVALID_SAVE_NOTIFICATION_RECEIVED _HRESULT_TYPEDEF_(0xC0370805L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_INVALID_SAVE_NOTIFICATION_RECEIVED = unchecked(
        (int)(0xC0370805)
    );

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_INVALID_RESTORE_REQUEST_RECEIVED _HRESULT_TYPEDEF_(0xC0370806L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_INVALID_RESTORE_REQUEST_RECEIVED = unchecked(
        (int)(0xC0370806)
    );

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_INVALID_RESTORE_NOTIFICATION_RECEIVED _HRESULT_TYPEDEF_(0xC0370807L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_INVALID_RESTORE_NOTIFICATION_RECEIVED = unchecked(
        (int)(0xC0370807)
    );

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_NO_IGVM_FILE _HRESULT_TYPEDEF_(0xC0370808L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_NO_IGVM_FILE = unchecked((int)(0xC0370808));

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_RELOAD_UNSUPPORTED _HRESULT_TYPEDEF_(0xC0370809L)"
    )]
    public const int VM_E_MANAGEMENT_VTL_RELOAD_UNSUPPORTED = unchecked((int)(0xC0370809));

    [NativeTypeName(
        "#define VM_E_MANAGEMENT_VTL_PROTOCOL_ESTABLISHMENT_TIMEOUT _HRESULT_TYPEDEF_(0xC037080AL)"
    )]
    public const int VM_E_MANAGEMENT_VTL_PROTOCOL_ESTABLISHMENT_TIMEOUT = unchecked(
        (int)(0xC037080A)
    );
}
