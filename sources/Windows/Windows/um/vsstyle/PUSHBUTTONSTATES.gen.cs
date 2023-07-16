// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PUSHBUTTONSTATES.xml' path='doc/member[@name="PUSHBUTTONSTATES"]/*'/>
public enum PUSHBUTTONSTATES
{
    /// <include file='PUSHBUTTONSTATES.xml' path='doc/member[@name="PUSHBUTTONSTATES.PBS_NORMAL"]/*'/>
    PBS_NORMAL = 1,
    /// <include file='PUSHBUTTONSTATES.xml' path='doc/member[@name="PUSHBUTTONSTATES.PBS_HOT"]/*'/>
    PBS_HOT = 2,
    /// <include file='PUSHBUTTONSTATES.xml' path='doc/member[@name="PUSHBUTTONSTATES.PBS_PRESSED"]/*'/>
    PBS_PRESSED = 3,
    /// <include file='PUSHBUTTONSTATES.xml' path='doc/member[@name="PUSHBUTTONSTATES.PBS_DISABLED"]/*'/>
    PBS_DISABLED = 4,
    /// <include file='PUSHBUTTONSTATES.xml' path='doc/member[@name="PUSHBUTTONSTATES.PBS_DEFAULTED"]/*'/>
    PBS_DEFAULTED = 5,
    /// <include file='PUSHBUTTONSTATES.xml' path='doc/member[@name="PUSHBUTTONSTATES.PBS_DEFAULTED_ANIMATING"]/*'/>
    PBS_DEFAULTED_ANIMATING = 6,
}