// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_PREFERRED_DISPLAY_MODE
{
    DISPLAY_CONTENT_DEFAULT = 0,
    DISPLAY_16x9 = 1,
    DISPLAY_4x3_PANSCAN_PREFERRED = 2,
    DISPLAY_4x3_LETTERBOX_PREFERRED = 3,
}
