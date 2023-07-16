// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAY_BREAK.xml' path='doc/member[@name="DISPLAY_BREAK"]/*'/>
public enum DISPLAY_BREAK
{
    /// <include file='DISPLAY_BREAK.xml' path='doc/member[@name="DISPLAY_BREAK.DISPLAY_BREAK_None"]/*'/>
    DISPLAY_BREAK_None = 0,
    /// <include file='DISPLAY_BREAK.xml' path='doc/member[@name="DISPLAY_BREAK.DISPLAY_BREAK_Block"]/*'/>
    DISPLAY_BREAK_Block = 0x1,
    /// <include file='DISPLAY_BREAK.xml' path='doc/member[@name="DISPLAY_BREAK.DISPLAY_BREAK_Break"]/*'/>
    DISPLAY_BREAK_Break = 0x2,
    /// <include file='DISPLAY_BREAK.xml' path='doc/member[@name="DISPLAY_BREAK.DISPLAY_BREAK_Max"]/*'/>
    DISPLAY_BREAK_Max = 2147483647,
}