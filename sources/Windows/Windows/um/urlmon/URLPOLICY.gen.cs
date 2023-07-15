// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class URLPOLICY
{
    [NativeTypeName("#define URLPOLICY_ACTIVEX_CHECK_LIST 0x00010000")]
    public const int URLPOLICY_ACTIVEX_CHECK_LIST = 0x00010000;
    [NativeTypeName("#define URLPOLICY_CREDENTIALS_SILENT_LOGON_OK 0x00000000")]
    public const int URLPOLICY_CREDENTIALS_SILENT_LOGON_OK = 0x00000000;
    [NativeTypeName("#define URLPOLICY_CREDENTIALS_MUST_PROMPT_USER 0x00010000")]
    public const int URLPOLICY_CREDENTIALS_MUST_PROMPT_USER = 0x00010000;
    [NativeTypeName("#define URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT 0x00020000")]
    public const int URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT = 0x00020000;
    [NativeTypeName("#define URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY 0x00030000")]
    public const int URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY = 0x00030000;
    [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CLEARTEXT_OK 0x00000000")]
    public const int URLPOLICY_AUTHENTICATE_CLEARTEXT_OK = 0x00000000;
    [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE 0x00010000")]
    public const int URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE = 0x00010000;
    [NativeTypeName("#define URLPOLICY_AUTHENTICATE_MUTUAL_ONLY 0x00030000")]
    public const int URLPOLICY_AUTHENTICATE_MUTUAL_ONLY = 0x00030000;
    [NativeTypeName("#define URLPOLICY_JAVA_PROHIBIT 0x00000000")]
    public const int URLPOLICY_JAVA_PROHIBIT = 0x00000000;
    [NativeTypeName("#define URLPOLICY_JAVA_HIGH 0x00010000")]
    public const int URLPOLICY_JAVA_HIGH = 0x00010000;
    [NativeTypeName("#define URLPOLICY_JAVA_MEDIUM 0x00020000")]
    public const int URLPOLICY_JAVA_MEDIUM = 0x00020000;
    [NativeTypeName("#define URLPOLICY_JAVA_LOW 0x00030000")]
    public const int URLPOLICY_JAVA_LOW = 0x00030000;
    [NativeTypeName("#define URLPOLICY_JAVA_CUSTOM 0x00800000")]
    public const int URLPOLICY_JAVA_CUSTOM = 0x00800000;
    [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT 0x00010000")]
    public const int URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT = 0x00010000;
    [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PRECACHE 0x00020000")]
    public const int URLPOLICY_CHANNEL_SOFTDIST_PRECACHE = 0x00020000;
    [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL 0x00030000")]
    public const int URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL = 0x00030000;
    [NativeTypeName("#define URLPOLICY_BEHAVIOR_CHECK_LIST 0x00010000")]
    public const int URLPOLICY_BEHAVIOR_CHECK_LIST = 0x00010000;
    [NativeTypeName("#define URLPOLICY_ALLOW 0x00")]
    public const int URLPOLICY_ALLOW = 0x00;
    [NativeTypeName("#define URLPOLICY_QUERY 0x01")]
    public const int URLPOLICY_QUERY = 0x01;
    [NativeTypeName("#define URLPOLICY_DISALLOW 0x03")]
    public const int URLPOLICY_DISALLOW = 0x03;
    [NativeTypeName("#define URLPOLICY_NOTIFY_ON_ALLOW 0x10")]
    public const int URLPOLICY_NOTIFY_ON_ALLOW = 0x10;
    [NativeTypeName("#define URLPOLICY_NOTIFY_ON_DISALLOW 0x20")]
    public const int URLPOLICY_NOTIFY_ON_DISALLOW = 0x20;
    [NativeTypeName("#define URLPOLICY_LOG_ON_ALLOW 0x40")]
    public const int URLPOLICY_LOG_ON_ALLOW = 0x40;
    [NativeTypeName("#define URLPOLICY_LOG_ON_DISALLOW 0x80")]
    public const int URLPOLICY_LOG_ON_DISALLOW = 0x80;
    [NativeTypeName("#define URLPOLICY_MASK_PERMISSIONS 0x0f")]
    public const int URLPOLICY_MASK_PERMISSIONS = 0x0f;
    [NativeTypeName("#define URLPOLICY_DONTCHECKDLGBOX 0x100")]
    public const int URLPOLICY_DONTCHECKDLGBOX = 0x100;
}