// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleBreak.xml' path='doc/member[@name="styleBreak"]/*'/>
public enum styleBreak
{
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakNotSet"]/*'/>
    styleBreakNotSet = 0,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakAuto"]/*'/>
    styleBreakAuto = 1,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakAlways"]/*'/>
    styleBreakAlways = 2,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakAvoid"]/*'/>
    styleBreakAvoid = 3,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakLeft"]/*'/>
    styleBreakLeft = 4,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakRight"]/*'/>
    styleBreakRight = 5,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakPage"]/*'/>
    styleBreakPage = 6,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakColumn"]/*'/>
    styleBreakColumn = 7,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakAvoidPage"]/*'/>
    styleBreakAvoidPage = 8,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreakAvoidColumn"]/*'/>
    styleBreakAvoidColumn = 9,
    /// <include file='styleBreak.xml' path='doc/member[@name="styleBreak.styleBreak_Max"]/*'/>
    styleBreak_Max = 2147483647,
}