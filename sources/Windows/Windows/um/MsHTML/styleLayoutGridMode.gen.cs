// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleLayoutGridMode.xml' path='doc/member[@name="styleLayoutGridMode"]/*'/>
public enum styleLayoutGridMode
{
    /// <include file='styleLayoutGridMode.xml' path='doc/member[@name="styleLayoutGridMode.styleLayoutGridModeNotSet"]/*'/>
    styleLayoutGridModeNotSet = 0,
    /// <include file='styleLayoutGridMode.xml' path='doc/member[@name="styleLayoutGridMode.styleLayoutGridModeChar"]/*'/>
    styleLayoutGridModeChar = 1,
    /// <include file='styleLayoutGridMode.xml' path='doc/member[@name="styleLayoutGridMode.styleLayoutGridModeLine"]/*'/>
    styleLayoutGridModeLine = 2,
    /// <include file='styleLayoutGridMode.xml' path='doc/member[@name="styleLayoutGridMode.styleLayoutGridModeBoth"]/*'/>
    styleLayoutGridModeBoth = 3,
    /// <include file='styleLayoutGridMode.xml' path='doc/member[@name="styleLayoutGridMode.styleLayoutGridModeNone"]/*'/>
    styleLayoutGridModeNone = 4,
    /// <include file='styleLayoutGridMode.xml' path='doc/member[@name="styleLayoutGridMode.styleLayoutGridMode_Max"]/*'/>
    styleLayoutGridMode_Max = 2147483647,
}