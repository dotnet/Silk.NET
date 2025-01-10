// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum UIElementType
{
    UIElementType_ActiveCaption = 0,
    UIElementType_Background = 1,
    UIElementType_ButtonFace = 2,
    UIElementType_ButtonText = 3,
    UIElementType_CaptionText = 4,
    UIElementType_GrayText = 5,
    UIElementType_Highlight = 6,
    UIElementType_HighlightText = 7,
    UIElementType_Hotlight = 8,
    UIElementType_InactiveCaption = 9,
    UIElementType_InactiveCaptionText = 10,
    UIElementType_Window = 11,
    UIElementType_WindowText = 12,
    UIElementType_AccentColor = 1000,
    UIElementType_TextHigh = 1001,
    UIElementType_TextMedium = 1002,
    UIElementType_TextLow = 1003,
    UIElementType_TextContrastWithHigh = 1004,
    UIElementType_NonTextHigh = 1005,
    UIElementType_NonTextMediumHigh = 1006,
    UIElementType_NonTextMedium = 1007,
    UIElementType_NonTextMediumLow = 1008,
    UIElementType_NonTextLow = 1009,
    UIElementType_PageBackground = 1010,
    UIElementType_PopupBackground = 1011,
    UIElementType_OverlayOutsidePopup = 1012,
}
