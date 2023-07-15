// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CREDUI
{
    [NativeTypeName("#define CREDUI_MAX_MESSAGE_LENGTH 1024")]
    public const int CREDUI_MAX_MESSAGE_LENGTH = 1024;
    [NativeTypeName("#define CREDUI_MAX_CAPTION_LENGTH 128")]
    public const int CREDUI_MAX_CAPTION_LENGTH = 128;
    [NativeTypeName("#define CREDUI_MAX_GENERIC_TARGET_LENGTH CRED_MAX_GENERIC_TARGET_NAME_LENGTH")]
    public const int CREDUI_MAX_GENERIC_TARGET_LENGTH = 32767;
    [NativeTypeName("#define CREDUI_MAX_DOMAIN_TARGET_LENGTH CRED_MAX_DOMAIN_TARGET_NAME_LENGTH")]
    public const int CREDUI_MAX_DOMAIN_TARGET_LENGTH = (256 + 1 + 80);
    [NativeTypeName("#define CREDUI_MAX_USERNAME_LENGTH CRED_MAX_USERNAME_LENGTH")]
    public const int CREDUI_MAX_USERNAME_LENGTH = (256 + 1 + 256);
    [NativeTypeName("#define CREDUI_MAX_PASSWORD_LENGTH (512 / 2)")]
    public const int CREDUI_MAX_PASSWORD_LENGTH = (512 / 2);
    [NativeTypeName("#define CREDUI_FLAGS_INCORRECT_PASSWORD 0x00001")]
    public const int CREDUI_FLAGS_INCORRECT_PASSWORD = 0x00001;
    [NativeTypeName("#define CREDUI_FLAGS_DO_NOT_PERSIST 0x00002")]
    public const int CREDUI_FLAGS_DO_NOT_PERSIST = 0x00002;
    [NativeTypeName("#define CREDUI_FLAGS_REQUEST_ADMINISTRATOR 0x00004")]
    public const int CREDUI_FLAGS_REQUEST_ADMINISTRATOR = 0x00004;
    [NativeTypeName("#define CREDUI_FLAGS_EXCLUDE_CERTIFICATES 0x00008")]
    public const int CREDUI_FLAGS_EXCLUDE_CERTIFICATES = 0x00008;
    [NativeTypeName("#define CREDUI_FLAGS_REQUIRE_CERTIFICATE 0x00010")]
    public const int CREDUI_FLAGS_REQUIRE_CERTIFICATE = 0x00010;
    [NativeTypeName("#define CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX 0x00040")]
    public const int CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX = 0x00040;
    [NativeTypeName("#define CREDUI_FLAGS_ALWAYS_SHOW_UI 0x00080")]
    public const int CREDUI_FLAGS_ALWAYS_SHOW_UI = 0x00080;
    [NativeTypeName("#define CREDUI_FLAGS_REQUIRE_SMARTCARD 0x00100")]
    public const int CREDUI_FLAGS_REQUIRE_SMARTCARD = 0x00100;
    [NativeTypeName("#define CREDUI_FLAGS_PASSWORD_ONLY_OK 0x00200")]
    public const int CREDUI_FLAGS_PASSWORD_ONLY_OK = 0x00200;
    [NativeTypeName("#define CREDUI_FLAGS_VALIDATE_USERNAME 0x00400")]
    public const int CREDUI_FLAGS_VALIDATE_USERNAME = 0x00400;
    [NativeTypeName("#define CREDUI_FLAGS_COMPLETE_USERNAME 0x00800")]
    public const int CREDUI_FLAGS_COMPLETE_USERNAME = 0x00800;
    [NativeTypeName("#define CREDUI_FLAGS_PERSIST 0x01000")]
    public const int CREDUI_FLAGS_PERSIST = 0x01000;
    [NativeTypeName("#define CREDUI_FLAGS_SERVER_CREDENTIAL 0x04000")]
    public const int CREDUI_FLAGS_SERVER_CREDENTIAL = 0x04000;
    [NativeTypeName("#define CREDUI_FLAGS_EXPECT_CONFIRMATION 0x20000")]
    public const int CREDUI_FLAGS_EXPECT_CONFIRMATION = 0x20000;
    [NativeTypeName("#define CREDUI_FLAGS_GENERIC_CREDENTIALS 0x40000")]
    public const int CREDUI_FLAGS_GENERIC_CREDENTIALS = 0x40000;
    [NativeTypeName("#define CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS 0x80000")]
    public const int CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS = 0x80000;
    [NativeTypeName("#define CREDUI_FLAGS_KEEP_USERNAME 0x100000")]
    public const int CREDUI_FLAGS_KEEP_USERNAME = 0x100000;
    [NativeTypeName("#define CREDUI_FLAGS_PROMPT_VALID ( \\\r\n        CREDUI_FLAGS_INCORRECT_PASSWORD | \\\r\n        CREDUI_FLAGS_DO_NOT_PERSIST | \\\r\n        CREDUI_FLAGS_REQUEST_ADMINISTRATOR | \\\r\n        CREDUI_FLAGS_EXCLUDE_CERTIFICATES | \\\r\n        CREDUI_FLAGS_REQUIRE_CERTIFICATE | \\\r\n        CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX | \\\r\n        CREDUI_FLAGS_ALWAYS_SHOW_UI | \\\r\n        CREDUI_FLAGS_REQUIRE_SMARTCARD | \\\r\n        CREDUI_FLAGS_PASSWORD_ONLY_OK | \\\r\n        CREDUI_FLAGS_VALIDATE_USERNAME | \\\r\n        CREDUI_FLAGS_COMPLETE_USERNAME | \\\r\n        CREDUI_FLAGS_PERSIST | \\\r\n        CREDUI_FLAGS_SERVER_CREDENTIAL | \\\r\n        CREDUI_FLAGS_EXPECT_CONFIRMATION | \\\r\n        CREDUI_FLAGS_GENERIC_CREDENTIALS | \\\r\n        CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS | \\\r\n        CREDUI_FLAGS_KEEP_USERNAME )")]
    public const int CREDUI_FLAGS_PROMPT_VALID = (0x00001 | 0x00002 | 0x00004 | 0x00008 | 0x00010 | 0x00040 | 0x00080 | 0x00100 | 0x00200 | 0x00400 | 0x00800 | 0x01000 | 0x04000 | 0x20000 | 0x40000 | 0x80000 | 0x100000);
}