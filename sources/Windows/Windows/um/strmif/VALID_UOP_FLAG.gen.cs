// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG"]/*'/>
public enum VALID_UOP_FLAG
{
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Play_Title_Or_AtTime"]/*'/>
    UOP_FLAG_Play_Title_Or_AtTime = 0x1,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Play_Chapter"]/*'/>
    UOP_FLAG_Play_Chapter = 0x2,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Play_Title"]/*'/>
    UOP_FLAG_Play_Title = 0x4,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Stop"]/*'/>
    UOP_FLAG_Stop = 0x8,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_ReturnFromSubMenu"]/*'/>
    UOP_FLAG_ReturnFromSubMenu = 0x10,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Play_Chapter_Or_AtTime"]/*'/>
    UOP_FLAG_Play_Chapter_Or_AtTime = 0x20,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_PlayPrev_Or_Replay_Chapter"]/*'/>
    UOP_FLAG_PlayPrev_Or_Replay_Chapter = 0x40,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_PlayNext_Chapter"]/*'/>
    UOP_FLAG_PlayNext_Chapter = 0x80,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Play_Forwards"]/*'/>
    UOP_FLAG_Play_Forwards = 0x100,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Play_Backwards"]/*'/>
    UOP_FLAG_Play_Backwards = 0x200,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_ShowMenu_Title"]/*'/>
    UOP_FLAG_ShowMenu_Title = 0x400,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_ShowMenu_Root"]/*'/>
    UOP_FLAG_ShowMenu_Root = 0x800,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_ShowMenu_SubPic"]/*'/>
    UOP_FLAG_ShowMenu_SubPic = 0x1000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_ShowMenu_Audio"]/*'/>
    UOP_FLAG_ShowMenu_Audio = 0x2000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_ShowMenu_Angle"]/*'/>
    UOP_FLAG_ShowMenu_Angle = 0x4000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_ShowMenu_Chapter"]/*'/>
    UOP_FLAG_ShowMenu_Chapter = 0x8000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Resume"]/*'/>
    UOP_FLAG_Resume = 0x10000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Select_Or_Activate_Button"]/*'/>
    UOP_FLAG_Select_Or_Activate_Button = 0x20000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Still_Off"]/*'/>
    UOP_FLAG_Still_Off = 0x40000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Pause_On"]/*'/>
    UOP_FLAG_Pause_On = 0x80000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Select_Audio_Stream"]/*'/>
    UOP_FLAG_Select_Audio_Stream = 0x100000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Select_SubPic_Stream"]/*'/>
    UOP_FLAG_Select_SubPic_Stream = 0x200000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Select_Angle"]/*'/>
    UOP_FLAG_Select_Angle = 0x400000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Select_Karaoke_Audio_Presentation_Mode"]/*'/>
    UOP_FLAG_Select_Karaoke_Audio_Presentation_Mode = 0x800000,
    /// <include file='VALID_UOP_FLAG.xml' path='doc/member[@name="VALID_UOP_FLAG.UOP_FLAG_Select_Video_Mode_Preference"]/*'/>
    UOP_FLAG_Select_Video_Mode_Preference = 0x1000000,
}