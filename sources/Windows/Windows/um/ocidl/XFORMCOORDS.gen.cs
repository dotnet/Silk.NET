// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='XFORMCOORDS.xml' path='doc/member[@name="XFORMCOORDS"]/*'/>
public enum XFORMCOORDS
{
    /// <include file='XFORMCOORDS.xml' path='doc/member[@name="XFORMCOORDS.XFORMCOORDS_POSITION"]/*'/>
    XFORMCOORDS_POSITION = 0x1,
    /// <include file='XFORMCOORDS.xml' path='doc/member[@name="XFORMCOORDS.XFORMCOORDS_SIZE"]/*'/>
    XFORMCOORDS_SIZE = 0x2,
    /// <include file='XFORMCOORDS.xml' path='doc/member[@name="XFORMCOORDS.XFORMCOORDS_HIMETRICTOCONTAINER"]/*'/>
    XFORMCOORDS_HIMETRICTOCONTAINER = 0x4,
    /// <include file='XFORMCOORDS.xml' path='doc/member[@name="XFORMCOORDS.XFORMCOORDS_CONTAINERTOHIMETRIC"]/*'/>
    XFORMCOORDS_CONTAINERTOHIMETRIC = 0x8,
    /// <include file='XFORMCOORDS.xml' path='doc/member[@name="XFORMCOORDS.XFORMCOORDS_EVENTCOMPAT"]/*'/>
    XFORMCOORDS_EVENTCOMPAT = 0x10,
}