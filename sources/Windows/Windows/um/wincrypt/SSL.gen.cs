// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
public static partial class SSL
{
    [NativeTypeName("#define SSL_F12_ERROR_TEXT_LENGTH 256")]
    public const int SSL_F12_ERROR_TEXT_LENGTH = 256;
    [NativeTypeName("#define SSL_HPKP_PKP_HEADER_INDEX 0")]
    public const int SSL_HPKP_PKP_HEADER_INDEX = 0;
    [NativeTypeName("#define SSL_HPKP_PKP_RO_HEADER_INDEX 1")]
    public const int SSL_HPKP_PKP_RO_HEADER_INDEX = 1;
    [NativeTypeName("#define SSL_HPKP_HEADER_COUNT 2")]
    public const int SSL_HPKP_HEADER_COUNT = 2;
    [NativeTypeName("#define SSL_KEY_PIN_ERROR_TEXT_LENGTH 512")]
    public const int SSL_KEY_PIN_ERROR_TEXT_LENGTH = 512;
    [NativeTypeName("#define SSL_OBJECT_LOCATOR_PFX_FUNC \"SslObjectLocatorInitializePfx\"")]
    public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_PFX_FUNC => "SslObjectLocatorInitializePfx"u8;

    [NativeTypeName("#define SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC \"SslObjectLocatorInitializeIssuerList\"")]
    public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_ISSUER_LIST_FUNC => "SslObjectLocatorInitializeIssuerList"u8;

    [NativeTypeName("#define SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC \"SslObjectLocatorInitializeCertValidationConfig\"")]
    public static ReadOnlySpan<byte> SSL_OBJECT_LOCATOR_CERT_VALIDATION_CONFIG_FUNC => "SslObjectLocatorInitializeCertValidationConfig"u8;
}