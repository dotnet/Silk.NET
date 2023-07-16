// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION"]/*'/>
public enum MOVEUNIT_ACTION
{
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVCHAR"]/*'/>
    MOVEUNIT_PREVCHAR = 0,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTCHAR"]/*'/>
    MOVEUNIT_NEXTCHAR = 1,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVCLUSTERBEGIN"]/*'/>
    MOVEUNIT_PREVCLUSTERBEGIN = 2,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTCLUSTERBEGIN"]/*'/>
    MOVEUNIT_NEXTCLUSTERBEGIN = 3,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVCLUSTEREND"]/*'/>
    MOVEUNIT_PREVCLUSTEREND = 4,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTCLUSTEREND"]/*'/>
    MOVEUNIT_NEXTCLUSTEREND = 5,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVWORDBEGIN"]/*'/>
    MOVEUNIT_PREVWORDBEGIN = 6,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTWORDBEGIN"]/*'/>
    MOVEUNIT_NEXTWORDBEGIN = 7,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVWORDEND"]/*'/>
    MOVEUNIT_PREVWORDEND = 8,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTWORDEND"]/*'/>
    MOVEUNIT_NEXTWORDEND = 9,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVPROOFWORD"]/*'/>
    MOVEUNIT_PREVPROOFWORD = 10,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTPROOFWORD"]/*'/>
    MOVEUNIT_NEXTPROOFWORD = 11,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTURLBEGIN"]/*'/>
    MOVEUNIT_NEXTURLBEGIN = 12,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVURLBEGIN"]/*'/>
    MOVEUNIT_PREVURLBEGIN = 13,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTURLEND"]/*'/>
    MOVEUNIT_NEXTURLEND = 14,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVURLEND"]/*'/>
    MOVEUNIT_PREVURLEND = 15,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVSENTENCE"]/*'/>
    MOVEUNIT_PREVSENTENCE = 16,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTSENTENCE"]/*'/>
    MOVEUNIT_NEXTSENTENCE = 17,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_PREVBLOCK"]/*'/>
    MOVEUNIT_PREVBLOCK = 18,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_NEXTBLOCK"]/*'/>
    MOVEUNIT_NEXTBLOCK = 19,
    /// <include file='MOVEUNIT_ACTION.xml' path='doc/member[@name="MOVEUNIT_ACTION.MOVEUNIT_ACTION_Max"]/*'/>
    MOVEUNIT_ACTION_Max = 2147483647,
}