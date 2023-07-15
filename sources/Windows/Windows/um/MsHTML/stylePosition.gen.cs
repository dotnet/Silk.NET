// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='stylePosition.xml' path='doc/member[@name="stylePosition"]/*'/>
public enum stylePosition
{
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePositionNotSet"]/*'/>
    stylePositionNotSet = 0,
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePositionstatic"]/*'/>
    stylePositionstatic = 1,
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePositionrelative"]/*'/>
    stylePositionrelative = 2,
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePositionabsolute"]/*'/>
    stylePositionabsolute = 3,
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePositionfixed"]/*'/>
    stylePositionfixed = 4,
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePositionMsPage"]/*'/>
    stylePositionMsPage = 5,
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePositionMsDeviceFixed"]/*'/>
    stylePositionMsDeviceFixed = 6,
    /// <include file='stylePosition.xml' path='doc/member[@name="stylePosition.stylePosition_Max"]/*'/>
    stylePosition_Max = 2147483647,
}