// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum POINTER_BUTTON_CHANGE_TYPE
{
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_NONE"]/*'/>
    POINTER_CHANGE_NONE,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIRSTBUTTON_DOWN"]/*'/>
    POINTER_CHANGE_FIRSTBUTTON_DOWN,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIRSTBUTTON_UP"]/*'/>
    POINTER_CHANGE_FIRSTBUTTON_UP,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_SECONDBUTTON_DOWN"]/*'/>
    POINTER_CHANGE_SECONDBUTTON_DOWN,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_SECONDBUTTON_UP"]/*'/>
    POINTER_CHANGE_SECONDBUTTON_UP,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_THIRDBUTTON_DOWN"]/*'/>
    POINTER_CHANGE_THIRDBUTTON_DOWN,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_THIRDBUTTON_UP"]/*'/>
    POINTER_CHANGE_THIRDBUTTON_UP,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FOURTHBUTTON_DOWN"]/*'/>
    POINTER_CHANGE_FOURTHBUTTON_DOWN,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FOURTHBUTTON_UP"]/*'/>
    POINTER_CHANGE_FOURTHBUTTON_UP,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIFTHBUTTON_DOWN"]/*'/>
    POINTER_CHANGE_FIFTHBUTTON_DOWN,
    /// <include file='POINTER_BUTTON_CHANGE_TYPE.xml' path='doc/member[@name="POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIFTHBUTTON_UP"]/*'/>
    POINTER_CHANGE_FIFTHBUTTON_UP,
}