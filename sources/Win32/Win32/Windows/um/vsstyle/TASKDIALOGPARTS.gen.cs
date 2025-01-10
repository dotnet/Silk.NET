// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TASKDIALOGPARTS
{
    TDLG_PRIMARYPANEL = 1,
    TDLG_MAININSTRUCTIONPANE = 2,
    TDLG_MAINICON = 3,
    TDLG_CONTENTPANE = 4,
    TDLG_CONTENTICON = 5,
    TDLG_EXPANDEDCONTENT = 6,
    TDLG_COMMANDLINKPANE = 7,
    TDLG_SECONDARYPANEL = 8,
    TDLG_CONTROLPANE = 9,
    TDLG_BUTTONSECTION = 10,
    TDLG_BUTTONWRAPPER = 11,
    TDLG_EXPANDOTEXT = 12,
    TDLG_EXPANDOBUTTON = 13,
    TDLG_VERIFICATIONTEXT = 14,
    TDLG_FOOTNOTEPANE = 15,
    TDLG_FOOTNOTEAREA = 16,
    TDLG_FOOTNOTESEPARATOR = 17,
    TDLG_EXPANDEDFOOTERAREA = 18,
    TDLG_PROGRESSBAR = 19,
    TDLG_IMAGEALIGNMENT = 20,
    TDLG_RADIOBUTTONPANE = 21,
}
