// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES"]/*'/>
public enum TOOLBARSTYLESTATES
{
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_NORMAL"]/*'/>
    TS_NORMAL = 1,
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_HOT"]/*'/>
    TS_HOT = 2,
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_PRESSED"]/*'/>
    TS_PRESSED = 3,
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_DISABLED"]/*'/>
    TS_DISABLED = 4,
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_CHECKED"]/*'/>
    TS_CHECKED = 5,
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_HOTCHECKED"]/*'/>
    TS_HOTCHECKED = 6,
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_NEARHOT"]/*'/>
    TS_NEARHOT = 7,
    /// <include file='TOOLBARSTYLESTATES.xml' path='doc/member[@name="TOOLBARSTYLESTATES.TS_OTHERSIDEHOT"]/*'/>
    TS_OTHERSIDEHOT = 8,
}