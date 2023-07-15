// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE"]/*'/>
public enum PROPBAG2_TYPE
{
    /// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE.PROPBAG2_TYPE_UNDEFINED"]/*'/>
    PROPBAG2_TYPE_UNDEFINED = 0,
    /// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE.PROPBAG2_TYPE_DATA"]/*'/>
    PROPBAG2_TYPE_DATA = 1,
    /// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE.PROPBAG2_TYPE_URL"]/*'/>
    PROPBAG2_TYPE_URL = 2,
    /// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE.PROPBAG2_TYPE_OBJECT"]/*'/>
    PROPBAG2_TYPE_OBJECT = 3,
    /// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE.PROPBAG2_TYPE_STREAM"]/*'/>
    PROPBAG2_TYPE_STREAM = 4,
    /// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE.PROPBAG2_TYPE_STORAGE"]/*'/>
    PROPBAG2_TYPE_STORAGE = 5,
    /// <include file='PROPBAG2_TYPE.xml' path='doc/member[@name="PROPBAG2_TYPE.PROPBAG2_TYPE_MONIKER"]/*'/>
    PROPBAG2_TYPE_MONIKER = 6,
}