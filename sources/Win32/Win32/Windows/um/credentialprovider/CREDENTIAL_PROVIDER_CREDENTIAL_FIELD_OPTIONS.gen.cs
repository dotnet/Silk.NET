// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS
{
    CPCFO_NONE = 0,
    CPCFO_ENABLE_PASSWORD_REVEAL = 0x1,
    CPCFO_IS_EMAIL_ADDRESS = 0x2,
    CPCFO_ENABLE_TOUCH_KEYBOARD_AUTO_INVOKE = 0x4,
    CPCFO_NUMBERS_ONLY = 0x8,
    CPCFO_SHOW_ENGLISH_KEYBOARD = 0x10,
}
