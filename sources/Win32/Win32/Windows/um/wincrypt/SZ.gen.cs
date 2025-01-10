// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SZ
{
    [NativeTypeName("#define sz_CERT_STORE_PROV_MEMORY \"Memory\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_MEMORY => "Memory"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME_W \"File\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME_W => "File"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME sz_CERT_STORE_PROV_FILENAME_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME => "File"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_W \"System\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_W => "System"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM sz_CERT_STORE_PROV_SYSTEM_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM => "System"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS7 \"PKCS7\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS7 => "PKCS7"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS12 \"PKCS12\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS12 => "PKCS12"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SERIALIZED \"Serialized\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SERIALIZED => "Serialized"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_COLLECTION \"Collection\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_COLLECTION => "Collection"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W \"SystemRegistry\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W => "SystemRegistry"u8;

    [NativeTypeName(
        "#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W"
    )]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY => "SystemRegistry"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL_W \"Physical\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL_W => "Physical"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL sz_CERT_STORE_PROV_PHYSICAL_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL => "Physical"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD_W \"SmartCard\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD_W => "SmartCard"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD sz_CERT_STORE_PROV_SMART_CARD_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD => "SmartCard"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP_W \"Ldap\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP_W => "Ldap"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP sz_CERT_STORE_PROV_LDAP_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP => "Ldap"u8;
}
