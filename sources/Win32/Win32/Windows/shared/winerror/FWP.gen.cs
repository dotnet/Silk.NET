// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FWP
{
    [NativeTypeName("#define FWP_E_CALLOUT_NOT_FOUND _HRESULT_TYPEDEF_(0x80320001L)")]
    public const int FWP_E_CALLOUT_NOT_FOUND = unchecked((int)(0x80320001));

    [NativeTypeName("#define FWP_E_CONDITION_NOT_FOUND _HRESULT_TYPEDEF_(0x80320002L)")]
    public const int FWP_E_CONDITION_NOT_FOUND = unchecked((int)(0x80320002));

    [NativeTypeName("#define FWP_E_FILTER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320003L)")]
    public const int FWP_E_FILTER_NOT_FOUND = unchecked((int)(0x80320003));

    [NativeTypeName("#define FWP_E_LAYER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320004L)")]
    public const int FWP_E_LAYER_NOT_FOUND = unchecked((int)(0x80320004));

    [NativeTypeName("#define FWP_E_PROVIDER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320005L)")]
    public const int FWP_E_PROVIDER_NOT_FOUND = unchecked((int)(0x80320005));

    [NativeTypeName("#define FWP_E_PROVIDER_CONTEXT_NOT_FOUND _HRESULT_TYPEDEF_(0x80320006L)")]
    public const int FWP_E_PROVIDER_CONTEXT_NOT_FOUND = unchecked((int)(0x80320006));

    [NativeTypeName("#define FWP_E_SUBLAYER_NOT_FOUND _HRESULT_TYPEDEF_(0x80320007L)")]
    public const int FWP_E_SUBLAYER_NOT_FOUND = unchecked((int)(0x80320007));

    [NativeTypeName("#define FWP_E_NOT_FOUND _HRESULT_TYPEDEF_(0x80320008L)")]
    public const int FWP_E_NOT_FOUND = unchecked((int)(0x80320008));

    [NativeTypeName("#define FWP_E_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80320009L)")]
    public const int FWP_E_ALREADY_EXISTS = unchecked((int)(0x80320009));

    [NativeTypeName("#define FWP_E_IN_USE _HRESULT_TYPEDEF_(0x8032000AL)")]
    public const int FWP_E_IN_USE = unchecked((int)(0x8032000A));

    [NativeTypeName("#define FWP_E_DYNAMIC_SESSION_IN_PROGRESS _HRESULT_TYPEDEF_(0x8032000BL)")]
    public const int FWP_E_DYNAMIC_SESSION_IN_PROGRESS = unchecked((int)(0x8032000B));

    [NativeTypeName("#define FWP_E_WRONG_SESSION _HRESULT_TYPEDEF_(0x8032000CL)")]
    public const int FWP_E_WRONG_SESSION = unchecked((int)(0x8032000C));

    [NativeTypeName("#define FWP_E_NO_TXN_IN_PROGRESS _HRESULT_TYPEDEF_(0x8032000DL)")]
    public const int FWP_E_NO_TXN_IN_PROGRESS = unchecked((int)(0x8032000D));

    [NativeTypeName("#define FWP_E_TXN_IN_PROGRESS _HRESULT_TYPEDEF_(0x8032000EL)")]
    public const int FWP_E_TXN_IN_PROGRESS = unchecked((int)(0x8032000E));

    [NativeTypeName("#define FWP_E_TXN_ABORTED _HRESULT_TYPEDEF_(0x8032000FL)")]
    public const int FWP_E_TXN_ABORTED = unchecked((int)(0x8032000F));

    [NativeTypeName("#define FWP_E_SESSION_ABORTED _HRESULT_TYPEDEF_(0x80320010L)")]
    public const int FWP_E_SESSION_ABORTED = unchecked((int)(0x80320010));

    [NativeTypeName("#define FWP_E_INCOMPATIBLE_TXN _HRESULT_TYPEDEF_(0x80320011L)")]
    public const int FWP_E_INCOMPATIBLE_TXN = unchecked((int)(0x80320011));

    [NativeTypeName("#define FWP_E_TIMEOUT _HRESULT_TYPEDEF_(0x80320012L)")]
    public const int FWP_E_TIMEOUT = unchecked((int)(0x80320012));

    [NativeTypeName("#define FWP_E_NET_EVENTS_DISABLED _HRESULT_TYPEDEF_(0x80320013L)")]
    public const int FWP_E_NET_EVENTS_DISABLED = unchecked((int)(0x80320013));

    [NativeTypeName("#define FWP_E_INCOMPATIBLE_LAYER _HRESULT_TYPEDEF_(0x80320014L)")]
    public const int FWP_E_INCOMPATIBLE_LAYER = unchecked((int)(0x80320014));

    [NativeTypeName("#define FWP_E_KM_CLIENTS_ONLY _HRESULT_TYPEDEF_(0x80320015L)")]
    public const int FWP_E_KM_CLIENTS_ONLY = unchecked((int)(0x80320015));

    [NativeTypeName("#define FWP_E_LIFETIME_MISMATCH _HRESULT_TYPEDEF_(0x80320016L)")]
    public const int FWP_E_LIFETIME_MISMATCH = unchecked((int)(0x80320016));

    [NativeTypeName("#define FWP_E_BUILTIN_OBJECT _HRESULT_TYPEDEF_(0x80320017L)")]
    public const int FWP_E_BUILTIN_OBJECT = unchecked((int)(0x80320017));

    [NativeTypeName("#define FWP_E_TOO_MANY_CALLOUTS _HRESULT_TYPEDEF_(0x80320018L)")]
    public const int FWP_E_TOO_MANY_CALLOUTS = unchecked((int)(0x80320018));

    [NativeTypeName("#define FWP_E_NOTIFICATION_DROPPED _HRESULT_TYPEDEF_(0x80320019L)")]
    public const int FWP_E_NOTIFICATION_DROPPED = unchecked((int)(0x80320019));

    [NativeTypeName("#define FWP_E_TRAFFIC_MISMATCH _HRESULT_TYPEDEF_(0x8032001AL)")]
    public const int FWP_E_TRAFFIC_MISMATCH = unchecked((int)(0x8032001A));

    [NativeTypeName("#define FWP_E_INCOMPATIBLE_SA_STATE _HRESULT_TYPEDEF_(0x8032001BL)")]
    public const int FWP_E_INCOMPATIBLE_SA_STATE = unchecked((int)(0x8032001B));

    [NativeTypeName("#define FWP_E_NULL_POINTER _HRESULT_TYPEDEF_(0x8032001CL)")]
    public const int FWP_E_NULL_POINTER = unchecked((int)(0x8032001C));

    [NativeTypeName("#define FWP_E_INVALID_ENUMERATOR _HRESULT_TYPEDEF_(0x8032001DL)")]
    public const int FWP_E_INVALID_ENUMERATOR = unchecked((int)(0x8032001D));

    [NativeTypeName("#define FWP_E_INVALID_FLAGS _HRESULT_TYPEDEF_(0x8032001EL)")]
    public const int FWP_E_INVALID_FLAGS = unchecked((int)(0x8032001E));

    [NativeTypeName("#define FWP_E_INVALID_NET_MASK _HRESULT_TYPEDEF_(0x8032001FL)")]
    public const int FWP_E_INVALID_NET_MASK = unchecked((int)(0x8032001F));

    [NativeTypeName("#define FWP_E_INVALID_RANGE _HRESULT_TYPEDEF_(0x80320020L)")]
    public const int FWP_E_INVALID_RANGE = unchecked((int)(0x80320020));

    [NativeTypeName("#define FWP_E_INVALID_INTERVAL _HRESULT_TYPEDEF_(0x80320021L)")]
    public const int FWP_E_INVALID_INTERVAL = unchecked((int)(0x80320021));

    [NativeTypeName("#define FWP_E_ZERO_LENGTH_ARRAY _HRESULT_TYPEDEF_(0x80320022L)")]
    public const int FWP_E_ZERO_LENGTH_ARRAY = unchecked((int)(0x80320022));

    [NativeTypeName("#define FWP_E_NULL_DISPLAY_NAME _HRESULT_TYPEDEF_(0x80320023L)")]
    public const int FWP_E_NULL_DISPLAY_NAME = unchecked((int)(0x80320023));

    [NativeTypeName("#define FWP_E_INVALID_ACTION_TYPE _HRESULT_TYPEDEF_(0x80320024L)")]
    public const int FWP_E_INVALID_ACTION_TYPE = unchecked((int)(0x80320024));

    [NativeTypeName("#define FWP_E_INVALID_WEIGHT _HRESULT_TYPEDEF_(0x80320025L)")]
    public const int FWP_E_INVALID_WEIGHT = unchecked((int)(0x80320025));

    [NativeTypeName("#define FWP_E_MATCH_TYPE_MISMATCH _HRESULT_TYPEDEF_(0x80320026L)")]
    public const int FWP_E_MATCH_TYPE_MISMATCH = unchecked((int)(0x80320026));

    [NativeTypeName("#define FWP_E_TYPE_MISMATCH _HRESULT_TYPEDEF_(0x80320027L)")]
    public const int FWP_E_TYPE_MISMATCH = unchecked((int)(0x80320027));

    [NativeTypeName("#define FWP_E_OUT_OF_BOUNDS _HRESULT_TYPEDEF_(0x80320028L)")]
    public const int FWP_E_OUT_OF_BOUNDS = unchecked((int)(0x80320028));

    [NativeTypeName("#define FWP_E_RESERVED _HRESULT_TYPEDEF_(0x80320029L)")]
    public const int FWP_E_RESERVED = unchecked((int)(0x80320029));

    [NativeTypeName("#define FWP_E_DUPLICATE_CONDITION _HRESULT_TYPEDEF_(0x8032002AL)")]
    public const int FWP_E_DUPLICATE_CONDITION = unchecked((int)(0x8032002A));

    [NativeTypeName("#define FWP_E_DUPLICATE_KEYMOD _HRESULT_TYPEDEF_(0x8032002BL)")]
    public const int FWP_E_DUPLICATE_KEYMOD = unchecked((int)(0x8032002B));

    [NativeTypeName("#define FWP_E_ACTION_INCOMPATIBLE_WITH_LAYER _HRESULT_TYPEDEF_(0x8032002CL)")]
    public const int FWP_E_ACTION_INCOMPATIBLE_WITH_LAYER = unchecked((int)(0x8032002C));

    [NativeTypeName(
        "#define FWP_E_ACTION_INCOMPATIBLE_WITH_SUBLAYER _HRESULT_TYPEDEF_(0x8032002DL)"
    )]
    public const int FWP_E_ACTION_INCOMPATIBLE_WITH_SUBLAYER = unchecked((int)(0x8032002D));

    [NativeTypeName("#define FWP_E_CONTEXT_INCOMPATIBLE_WITH_LAYER _HRESULT_TYPEDEF_(0x8032002EL)")]
    public const int FWP_E_CONTEXT_INCOMPATIBLE_WITH_LAYER = unchecked((int)(0x8032002E));

    [NativeTypeName(
        "#define FWP_E_CONTEXT_INCOMPATIBLE_WITH_CALLOUT _HRESULT_TYPEDEF_(0x8032002FL)"
    )]
    public const int FWP_E_CONTEXT_INCOMPATIBLE_WITH_CALLOUT = unchecked((int)(0x8032002F));

    [NativeTypeName("#define FWP_E_INCOMPATIBLE_AUTH_METHOD _HRESULT_TYPEDEF_(0x80320030L)")]
    public const int FWP_E_INCOMPATIBLE_AUTH_METHOD = unchecked((int)(0x80320030));

    [NativeTypeName("#define FWP_E_INCOMPATIBLE_DH_GROUP _HRESULT_TYPEDEF_(0x80320031L)")]
    public const int FWP_E_INCOMPATIBLE_DH_GROUP = unchecked((int)(0x80320031));

    [NativeTypeName("#define FWP_E_EM_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80320032L)")]
    public const int FWP_E_EM_NOT_SUPPORTED = unchecked((int)(0x80320032));

    [NativeTypeName("#define FWP_E_NEVER_MATCH _HRESULT_TYPEDEF_(0x80320033L)")]
    public const int FWP_E_NEVER_MATCH = unchecked((int)(0x80320033));

    [NativeTypeName("#define FWP_E_PROVIDER_CONTEXT_MISMATCH _HRESULT_TYPEDEF_(0x80320034L)")]
    public const int FWP_E_PROVIDER_CONTEXT_MISMATCH = unchecked((int)(0x80320034));

    [NativeTypeName("#define FWP_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80320035L)")]
    public const int FWP_E_INVALID_PARAMETER = unchecked((int)(0x80320035));

    [NativeTypeName("#define FWP_E_TOO_MANY_SUBLAYERS _HRESULT_TYPEDEF_(0x80320036L)")]
    public const int FWP_E_TOO_MANY_SUBLAYERS = unchecked((int)(0x80320036));

    [NativeTypeName("#define FWP_E_CALLOUT_NOTIFICATION_FAILED _HRESULT_TYPEDEF_(0x80320037L)")]
    public const int FWP_E_CALLOUT_NOTIFICATION_FAILED = unchecked((int)(0x80320037));

    [NativeTypeName("#define FWP_E_INVALID_AUTH_TRANSFORM _HRESULT_TYPEDEF_(0x80320038L)")]
    public const int FWP_E_INVALID_AUTH_TRANSFORM = unchecked((int)(0x80320038));

    [NativeTypeName("#define FWP_E_INVALID_CIPHER_TRANSFORM _HRESULT_TYPEDEF_(0x80320039L)")]
    public const int FWP_E_INVALID_CIPHER_TRANSFORM = unchecked((int)(0x80320039));

    [NativeTypeName("#define FWP_E_INCOMPATIBLE_CIPHER_TRANSFORM _HRESULT_TYPEDEF_(0x8032003AL)")]
    public const int FWP_E_INCOMPATIBLE_CIPHER_TRANSFORM = unchecked((int)(0x8032003A));

    [NativeTypeName("#define FWP_E_INVALID_TRANSFORM_COMBINATION _HRESULT_TYPEDEF_(0x8032003BL)")]
    public const int FWP_E_INVALID_TRANSFORM_COMBINATION = unchecked((int)(0x8032003B));

    [NativeTypeName("#define FWP_E_DUPLICATE_AUTH_METHOD _HRESULT_TYPEDEF_(0x8032003CL)")]
    public const int FWP_E_DUPLICATE_AUTH_METHOD = unchecked((int)(0x8032003C));

    [NativeTypeName("#define FWP_E_INVALID_TUNNEL_ENDPOINT _HRESULT_TYPEDEF_(0x8032003DL)")]
    public const int FWP_E_INVALID_TUNNEL_ENDPOINT = unchecked((int)(0x8032003D));

    [NativeTypeName("#define FWP_E_L2_DRIVER_NOT_READY _HRESULT_TYPEDEF_(0x8032003EL)")]
    public const int FWP_E_L2_DRIVER_NOT_READY = unchecked((int)(0x8032003E));

    [NativeTypeName("#define FWP_E_KEY_DICTATOR_ALREADY_REGISTERED _HRESULT_TYPEDEF_(0x8032003FL)")]
    public const int FWP_E_KEY_DICTATOR_ALREADY_REGISTERED = unchecked((int)(0x8032003F));

    [NativeTypeName(
        "#define FWP_E_KEY_DICTATION_INVALID_KEYING_MATERIAL _HRESULT_TYPEDEF_(0x80320040L)"
    )]
    public const int FWP_E_KEY_DICTATION_INVALID_KEYING_MATERIAL = unchecked((int)(0x80320040));

    [NativeTypeName("#define FWP_E_CONNECTIONS_DISABLED _HRESULT_TYPEDEF_(0x80320041L)")]
    public const int FWP_E_CONNECTIONS_DISABLED = unchecked((int)(0x80320041));

    [NativeTypeName("#define FWP_E_INVALID_DNS_NAME _HRESULT_TYPEDEF_(0x80320042L)")]
    public const int FWP_E_INVALID_DNS_NAME = unchecked((int)(0x80320042));

    [NativeTypeName("#define FWP_E_STILL_ON _HRESULT_TYPEDEF_(0x80320043L)")]
    public const int FWP_E_STILL_ON = unchecked((int)(0x80320043));

    [NativeTypeName("#define FWP_E_IKEEXT_NOT_RUNNING _HRESULT_TYPEDEF_(0x80320044L)")]
    public const int FWP_E_IKEEXT_NOT_RUNNING = unchecked((int)(0x80320044));

    [NativeTypeName("#define FWP_E_DROP_NOICMP _HRESULT_TYPEDEF_(0x80320104L)")]
    public const int FWP_E_DROP_NOICMP = unchecked((int)(0x80320104));
}
