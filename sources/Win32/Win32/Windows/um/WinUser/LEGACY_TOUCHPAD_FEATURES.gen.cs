// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum LEGACY_TOUCHPAD_FEATURES
{
    LEGACY_TOUCHPAD_FEATURE_NONE = 0x00000000,
    LEGACY_TOUCHPAD_FEATURE_ENABLE_DISABLE = 0x00000001,
    LEGACY_TOUCHPAD_FEATURE_REVERSE_SCROLL_DIRECTION = 0x00000004,
}
