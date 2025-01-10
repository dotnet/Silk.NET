// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum VALID_UOP_FLAG
{
    UOP_FLAG_Play_Title_Or_AtTime = 0x1,
    UOP_FLAG_Play_Chapter = 0x2,
    UOP_FLAG_Play_Title = 0x4,
    UOP_FLAG_Stop = 0x8,
    UOP_FLAG_ReturnFromSubMenu = 0x10,
    UOP_FLAG_Play_Chapter_Or_AtTime = 0x20,
    UOP_FLAG_PlayPrev_Or_Replay_Chapter = 0x40,
    UOP_FLAG_PlayNext_Chapter = 0x80,
    UOP_FLAG_Play_Forwards = 0x100,
    UOP_FLAG_Play_Backwards = 0x200,
    UOP_FLAG_ShowMenu_Title = 0x400,
    UOP_FLAG_ShowMenu_Root = 0x800,
    UOP_FLAG_ShowMenu_SubPic = 0x1000,
    UOP_FLAG_ShowMenu_Audio = 0x2000,
    UOP_FLAG_ShowMenu_Angle = 0x4000,
    UOP_FLAG_ShowMenu_Chapter = 0x8000,
    UOP_FLAG_Resume = 0x10000,
    UOP_FLAG_Select_Or_Activate_Button = 0x20000,
    UOP_FLAG_Still_Off = 0x40000,
    UOP_FLAG_Pause_On = 0x80000,
    UOP_FLAG_Select_Audio_Stream = 0x100000,
    UOP_FLAG_Select_SubPic_Stream = 0x200000,
    UOP_FLAG_Select_Angle = 0x400000,
    UOP_FLAG_Select_Karaoke_Audio_Presentation_Mode = 0x800000,
    UOP_FLAG_Select_Video_Mode_Preference = 0x1000000,
}
