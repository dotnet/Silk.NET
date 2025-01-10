// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TASKDIALOG_MESSAGES
{
    TDM_NAVIGATE_PAGE = 0x0400 + 101,
    TDM_CLICK_BUTTON = 0x0400 + 102,
    TDM_SET_MARQUEE_PROGRESS_BAR = 0x0400 + 103,
    TDM_SET_PROGRESS_BAR_STATE = 0x0400 + 104,
    TDM_SET_PROGRESS_BAR_RANGE = 0x0400 + 105,
    TDM_SET_PROGRESS_BAR_POS = 0x0400 + 106,
    TDM_SET_PROGRESS_BAR_MARQUEE = 0x0400 + 107,
    TDM_SET_ELEMENT_TEXT = 0x0400 + 108,
    TDM_CLICK_RADIO_BUTTON = 0x0400 + 110,
    TDM_ENABLE_BUTTON = 0x0400 + 111,
    TDM_ENABLE_RADIO_BUTTON = 0x0400 + 112,
    TDM_CLICK_VERIFICATION = 0x0400 + 113,
    TDM_UPDATE_ELEMENT_TEXT = 0x0400 + 114,
    TDM_SET_BUTTON_ELEVATION_REQUIRED_STATE = 0x0400 + 115,
    TDM_UPDATE_ICON = 0x0400 + 116,
}
