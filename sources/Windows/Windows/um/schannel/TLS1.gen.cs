// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TLS1
{
    [NativeTypeName("#define TLS1_ALERT_WARNING 1")]
    public const int TLS1_ALERT_WARNING = 1;
    [NativeTypeName("#define TLS1_ALERT_FATAL 2")]
    public const int TLS1_ALERT_FATAL = 2;
    [NativeTypeName("#define TLS1_ALERT_CLOSE_NOTIFY 0")]
    public const int TLS1_ALERT_CLOSE_NOTIFY = 0;
    [NativeTypeName("#define TLS1_ALERT_UNEXPECTED_MESSAGE 10")]
    public const int TLS1_ALERT_UNEXPECTED_MESSAGE = 10;
    [NativeTypeName("#define TLS1_ALERT_BAD_RECORD_MAC 20")]
    public const int TLS1_ALERT_BAD_RECORD_MAC = 20;
    [NativeTypeName("#define TLS1_ALERT_DECRYPTION_FAILED 21")]
    public const int TLS1_ALERT_DECRYPTION_FAILED = 21;
    [NativeTypeName("#define TLS1_ALERT_RECORD_OVERFLOW 22")]
    public const int TLS1_ALERT_RECORD_OVERFLOW = 22;
    [NativeTypeName("#define TLS1_ALERT_DECOMPRESSION_FAIL 30")]
    public const int TLS1_ALERT_DECOMPRESSION_FAIL = 30;
    [NativeTypeName("#define TLS1_ALERT_HANDSHAKE_FAILURE 40")]
    public const int TLS1_ALERT_HANDSHAKE_FAILURE = 40;
    [NativeTypeName("#define TLS1_ALERT_BAD_CERTIFICATE 42")]
    public const int TLS1_ALERT_BAD_CERTIFICATE = 42;
    [NativeTypeName("#define TLS1_ALERT_UNSUPPORTED_CERT 43")]
    public const int TLS1_ALERT_UNSUPPORTED_CERT = 43;
    [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_REVOKED 44")]
    public const int TLS1_ALERT_CERTIFICATE_REVOKED = 44;
    [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_EXPIRED 45")]
    public const int TLS1_ALERT_CERTIFICATE_EXPIRED = 45;
    [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_UNKNOWN 46")]
    public const int TLS1_ALERT_CERTIFICATE_UNKNOWN = 46;
    [NativeTypeName("#define TLS1_ALERT_ILLEGAL_PARAMETER 47")]
    public const int TLS1_ALERT_ILLEGAL_PARAMETER = 47;
    [NativeTypeName("#define TLS1_ALERT_UNKNOWN_CA 48")]
    public const int TLS1_ALERT_UNKNOWN_CA = 48;
    [NativeTypeName("#define TLS1_ALERT_ACCESS_DENIED 49")]
    public const int TLS1_ALERT_ACCESS_DENIED = 49;
    [NativeTypeName("#define TLS1_ALERT_DECODE_ERROR 50")]
    public const int TLS1_ALERT_DECODE_ERROR = 50;
    [NativeTypeName("#define TLS1_ALERT_DECRYPT_ERROR 51")]
    public const int TLS1_ALERT_DECRYPT_ERROR = 51;
    [NativeTypeName("#define TLS1_ALERT_EXPORT_RESTRICTION 60")]
    public const int TLS1_ALERT_EXPORT_RESTRICTION = 60;
    [NativeTypeName("#define TLS1_ALERT_PROTOCOL_VERSION 70")]
    public const int TLS1_ALERT_PROTOCOL_VERSION = 70;
    [NativeTypeName("#define TLS1_ALERT_INSUFFIENT_SECURITY 71")]
    public const int TLS1_ALERT_INSUFFIENT_SECURITY = 71;
    [NativeTypeName("#define TLS1_ALERT_INTERNAL_ERROR 80")]
    public const int TLS1_ALERT_INTERNAL_ERROR = 80;
    [NativeTypeName("#define TLS1_ALERT_USER_CANCELED 90")]
    public const int TLS1_ALERT_USER_CANCELED = 90;
    [NativeTypeName("#define TLS1_ALERT_NO_RENEGOTIATION 100")]
    public const int TLS1_ALERT_NO_RENEGOTIATION = 100;
    [NativeTypeName("#define TLS1_ALERT_UNSUPPORTED_EXT 110")]
    public const int TLS1_ALERT_UNSUPPORTED_EXT = 110;
    [NativeTypeName("#define TLS1_ALERT_UNKNOWN_PSK_IDENTITY 115")]
    public const int TLS1_ALERT_UNKNOWN_PSK_IDENTITY = 115;
    [NativeTypeName("#define TLS1_ALERT_NO_APP_PROTOCOL 120")]
    public const int TLS1_ALERT_NO_APP_PROTOCOL = 120;
}