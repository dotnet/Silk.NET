// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HCN
{
    [NativeTypeName("#define HCN_E_NETWORK_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0001L)")]
    public const int HCN_E_NETWORK_NOT_FOUND = unchecked((int)(0x803B0001));

    [NativeTypeName("#define HCN_E_ENDPOINT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0002L)")]
    public const int HCN_E_ENDPOINT_NOT_FOUND = unchecked((int)(0x803B0002));

    [NativeTypeName("#define HCN_E_LAYER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0003L)")]
    public const int HCN_E_LAYER_NOT_FOUND = unchecked((int)(0x803B0003));

    [NativeTypeName("#define HCN_E_SWITCH_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0004L)")]
    public const int HCN_E_SWITCH_NOT_FOUND = unchecked((int)(0x803B0004));

    [NativeTypeName("#define HCN_E_SUBNET_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0005L)")]
    public const int HCN_E_SUBNET_NOT_FOUND = unchecked((int)(0x803B0005));

    [NativeTypeName("#define HCN_E_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0006L)")]
    public const int HCN_E_ADAPTER_NOT_FOUND = unchecked((int)(0x803B0006));

    [NativeTypeName("#define HCN_E_PORT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0007L)")]
    public const int HCN_E_PORT_NOT_FOUND = unchecked((int)(0x803B0007));

    [NativeTypeName("#define HCN_E_POLICY_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0008L)")]
    public const int HCN_E_POLICY_NOT_FOUND = unchecked((int)(0x803B0008));

    [NativeTypeName("#define HCN_E_VFP_PORTSETTING_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0009L)")]
    public const int HCN_E_VFP_PORTSETTING_NOT_FOUND = unchecked((int)(0x803B0009));

    [NativeTypeName("#define HCN_E_INVALID_NETWORK _HRESULT_TYPEDEF_(0x803B000AL)")]
    public const int HCN_E_INVALID_NETWORK = unchecked((int)(0x803B000A));

    [NativeTypeName("#define HCN_E_INVALID_NETWORK_TYPE _HRESULT_TYPEDEF_(0x803B000BL)")]
    public const int HCN_E_INVALID_NETWORK_TYPE = unchecked((int)(0x803B000B));

    [NativeTypeName("#define HCN_E_INVALID_ENDPOINT _HRESULT_TYPEDEF_(0x803B000CL)")]
    public const int HCN_E_INVALID_ENDPOINT = unchecked((int)(0x803B000C));

    [NativeTypeName("#define HCN_E_INVALID_POLICY _HRESULT_TYPEDEF_(0x803B000DL)")]
    public const int HCN_E_INVALID_POLICY = unchecked((int)(0x803B000D));

    [NativeTypeName("#define HCN_E_INVALID_POLICY_TYPE _HRESULT_TYPEDEF_(0x803B000EL)")]
    public const int HCN_E_INVALID_POLICY_TYPE = unchecked((int)(0x803B000E));

    [NativeTypeName(
        "#define HCN_E_INVALID_REMOTE_ENDPOINT_OPERATION _HRESULT_TYPEDEF_(0x803B000FL)"
    )]
    public const int HCN_E_INVALID_REMOTE_ENDPOINT_OPERATION = unchecked((int)(0x803B000F));

    [NativeTypeName("#define HCN_E_NETWORK_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0010L)")]
    public const int HCN_E_NETWORK_ALREADY_EXISTS = unchecked((int)(0x803B0010));

    [NativeTypeName("#define HCN_E_LAYER_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0011L)")]
    public const int HCN_E_LAYER_ALREADY_EXISTS = unchecked((int)(0x803B0011));

    [NativeTypeName("#define HCN_E_POLICY_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0012L)")]
    public const int HCN_E_POLICY_ALREADY_EXISTS = unchecked((int)(0x803B0012));

    [NativeTypeName("#define HCN_E_PORT_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0013L)")]
    public const int HCN_E_PORT_ALREADY_EXISTS = unchecked((int)(0x803B0013));

    [NativeTypeName("#define HCN_E_ENDPOINT_ALREADY_ATTACHED _HRESULT_TYPEDEF_(0x803B0014L)")]
    public const int HCN_E_ENDPOINT_ALREADY_ATTACHED = unchecked((int)(0x803B0014));

    [NativeTypeName("#define HCN_E_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x803B0015L)")]
    public const int HCN_E_REQUEST_UNSUPPORTED = unchecked((int)(0x803B0015));

    [NativeTypeName("#define HCN_E_MAPPING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803B0016L)")]
    public const int HCN_E_MAPPING_NOT_SUPPORTED = unchecked((int)(0x803B0016));

    [NativeTypeName("#define HCN_E_DEGRADED_OPERATION _HRESULT_TYPEDEF_(0x803B0017L)")]
    public const int HCN_E_DEGRADED_OPERATION = unchecked((int)(0x803B0017));

    [NativeTypeName("#define HCN_E_SHARED_SWITCH_MODIFICATION _HRESULT_TYPEDEF_(0x803B0018L)")]
    public const int HCN_E_SHARED_SWITCH_MODIFICATION = unchecked((int)(0x803B0018));

    [NativeTypeName("#define HCN_E_GUID_CONVERSION_FAILURE _HRESULT_TYPEDEF_(0x803B0019L)")]
    public const int HCN_E_GUID_CONVERSION_FAILURE = unchecked((int)(0x803B0019));

    [NativeTypeName("#define HCN_E_REGKEY_FAILURE _HRESULT_TYPEDEF_(0x803B001AL)")]
    public const int HCN_E_REGKEY_FAILURE = unchecked((int)(0x803B001A));

    [NativeTypeName("#define HCN_E_INVALID_JSON _HRESULT_TYPEDEF_(0x803B001BL)")]
    public const int HCN_E_INVALID_JSON = unchecked((int)(0x803B001B));

    [NativeTypeName("#define HCN_E_INVALID_JSON_REFERENCE _HRESULT_TYPEDEF_(0x803B001CL)")]
    public const int HCN_E_INVALID_JSON_REFERENCE = unchecked((int)(0x803B001C));

    [NativeTypeName("#define HCN_E_ENDPOINT_SHARING_DISABLED _HRESULT_TYPEDEF_(0x803B001DL)")]
    public const int HCN_E_ENDPOINT_SHARING_DISABLED = unchecked((int)(0x803B001D));

    [NativeTypeName("#define HCN_E_INVALID_IP _HRESULT_TYPEDEF_(0x803B001EL)")]
    public const int HCN_E_INVALID_IP = unchecked((int)(0x803B001E));

    [NativeTypeName("#define HCN_E_SWITCH_EXTENSION_NOT_FOUND _HRESULT_TYPEDEF_(0x803B001FL)")]
    public const int HCN_E_SWITCH_EXTENSION_NOT_FOUND = unchecked((int)(0x803B001F));

    [NativeTypeName("#define HCN_E_MANAGER_STOPPED _HRESULT_TYPEDEF_(0x803B0020L)")]
    public const int HCN_E_MANAGER_STOPPED = unchecked((int)(0x803B0020));

    [NativeTypeName("#define HCN_E_ICS_DISABLED _HRESULT_TYPEDEF_(0x803B002AL)")]
    public const int HCN_E_ICS_DISABLED = unchecked((int)(0x803B002A));

    [NativeTypeName(
        "#define HCN_E_ENDPOINT_NAMESPACE_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B002BL)"
    )]
    public const int HCN_E_ENDPOINT_NAMESPACE_ALREADY_EXISTS = unchecked((int)(0x803B002B));

    [NativeTypeName("#define HCN_E_ENTITY_HAS_REFERENCES _HRESULT_TYPEDEF_(0x803B002CL)")]
    public const int HCN_E_ENTITY_HAS_REFERENCES = unchecked((int)(0x803B002C));

    [NativeTypeName("#define HCN_E_INVALID_INTERNAL_PORT _HRESULT_TYPEDEF_(0x803B002DL)")]
    public const int HCN_E_INVALID_INTERNAL_PORT = unchecked((int)(0x803B002D));

    [NativeTypeName("#define HCN_E_NAMESPACE_ATTACH_FAILED _HRESULT_TYPEDEF_(0x803B002EL)")]
    public const int HCN_E_NAMESPACE_ATTACH_FAILED = unchecked((int)(0x803B002E));

    [NativeTypeName("#define HCN_E_ADDR_INVALID_OR_RESERVED _HRESULT_TYPEDEF_(0x803B002FL)")]
    public const int HCN_E_ADDR_INVALID_OR_RESERVED = unchecked((int)(0x803B002F));

    [NativeTypeName("#define HCN_E_INVALID_PREFIX _HRESULT_TYPEDEF_(0x803B0030L)")]
    public const int HCN_E_INVALID_PREFIX = unchecked((int)(0x803B0030));

    [NativeTypeName("#define HCN_E_OBJECT_USED_AFTER_UNLOAD _HRESULT_TYPEDEF_(0x803B0031L)")]
    public const int HCN_E_OBJECT_USED_AFTER_UNLOAD = unchecked((int)(0x803B0031));

    [NativeTypeName("#define HCN_E_INVALID_SUBNET _HRESULT_TYPEDEF_(0x803B0032L)")]
    public const int HCN_E_INVALID_SUBNET = unchecked((int)(0x803B0032));

    [NativeTypeName("#define HCN_E_INVALID_IP_SUBNET _HRESULT_TYPEDEF_(0x803B0033L)")]
    public const int HCN_E_INVALID_IP_SUBNET = unchecked((int)(0x803B0033));

    [NativeTypeName("#define HCN_E_ENDPOINT_NOT_ATTACHED _HRESULT_TYPEDEF_(0x803B0034L)")]
    public const int HCN_E_ENDPOINT_NOT_ATTACHED = unchecked((int)(0x803B0034));

    [NativeTypeName("#define HCN_E_ENDPOINT_NOT_LOCAL _HRESULT_TYPEDEF_(0x803B0035L)")]
    public const int HCN_E_ENDPOINT_NOT_LOCAL = unchecked((int)(0x803B0035));

    [NativeTypeName(
        "#define HCN_INTERFACEPARAMETERS_ALREADY_APPLIED _HRESULT_TYPEDEF_(0x803B0036L)"
    )]
    public const int HCN_INTERFACEPARAMETERS_ALREADY_APPLIED = unchecked((int)(0x803B0036));

    [NativeTypeName("#define HCN_E_VFP_NOT_ALLOWED _HRESULT_TYPEDEF_(0x803B0037L)")]
    public const int HCN_E_VFP_NOT_ALLOWED = unchecked((int)(0x803B0037));
}
