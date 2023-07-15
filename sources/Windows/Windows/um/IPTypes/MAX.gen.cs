// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MAX
{
    [NativeTypeName("#define MAX_ADAPTER_DESCRIPTION_LENGTH 128")]
    public const int MAX_ADAPTER_DESCRIPTION_LENGTH = 128;
    [NativeTypeName("#define MAX_ADAPTER_NAME_LENGTH 256")]
    public const int MAX_ADAPTER_NAME_LENGTH = 256;
    [NativeTypeName("#define MAX_ADAPTER_ADDRESS_LENGTH 8")]
    public const int MAX_ADAPTER_ADDRESS_LENGTH = 8;
    [NativeTypeName("#define MAX_HOSTNAME_LEN 128")]
    public const int MAX_HOSTNAME_LEN = 128;
    [NativeTypeName("#define MAX_DOMAIN_NAME_LEN 128")]
    public const int MAX_DOMAIN_NAME_LEN = 128;
    [NativeTypeName("#define MAX_SCOPE_ID_LEN 256")]
    public const int MAX_SCOPE_ID_LEN = 256;
    [NativeTypeName("#define MAX_DHCPV6_DUID_LENGTH 130")]
    public const int MAX_DHCPV6_DUID_LENGTH = 130;
    [NativeTypeName("#define MAX_DNS_SUFFIX_STRING_LENGTH 256")]
    public const int MAX_DNS_SUFFIX_STRING_LENGTH = 256;
}