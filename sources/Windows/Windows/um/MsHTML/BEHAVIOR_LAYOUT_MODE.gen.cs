// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BEHAVIOR_LAYOUT_MODE.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_MODE"]/*'/>
public enum BEHAVIOR_LAYOUT_MODE
{
    /// <include file='BEHAVIOR_LAYOUT_MODE.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_MODE.BEHAVIORLAYOUTMODE_NATURAL"]/*'/>
    BEHAVIORLAYOUTMODE_NATURAL = 0x1,
    /// <include file='BEHAVIOR_LAYOUT_MODE.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_MODE.BEHAVIORLAYOUTMODE_MINWIDTH"]/*'/>
    BEHAVIORLAYOUTMODE_MINWIDTH = 0x2,
    /// <include file='BEHAVIOR_LAYOUT_MODE.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_MODE.BEHAVIORLAYOUTMODE_MAXWIDTH"]/*'/>
    BEHAVIORLAYOUTMODE_MAXWIDTH = 0x4,
    /// <include file='BEHAVIOR_LAYOUT_MODE.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_MODE.BEHAVIORLAYOUTMODE_MEDIA_RESOLUTION"]/*'/>
    BEHAVIORLAYOUTMODE_MEDIA_RESOLUTION = 0x4000,
    /// <include file='BEHAVIOR_LAYOUT_MODE.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_MODE.BEHAVIORLAYOUTMODE_FINAL_PERCENT"]/*'/>
    BEHAVIORLAYOUTMODE_FINAL_PERCENT = 0x8000,
    /// <include file='BEHAVIOR_LAYOUT_MODE.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_MODE.BEHAVIOR_LAYOUT_MODE_Max"]/*'/>
    BEHAVIOR_LAYOUT_MODE_Max = 2147483647,
}