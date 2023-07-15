// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.VARENUM;

namespace TerraFX.Interop.Windows;
/// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE"]/*'/>
public enum SF_TYPE
{
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_ERROR"]/*'/>
    SF_ERROR = VT_ERROR,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_I1"]/*'/>
    SF_I1 = VT_I1,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_I2"]/*'/>
    SF_I2 = VT_I2,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_I4"]/*'/>
    SF_I4 = VT_I4,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_I8"]/*'/>
    SF_I8 = VT_I8,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_BSTR"]/*'/>
    SF_BSTR = VT_BSTR,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_UNKNOWN"]/*'/>
    SF_UNKNOWN = VT_UNKNOWN,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_DISPATCH"]/*'/>
    SF_DISPATCH = VT_DISPATCH,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_VARIANT"]/*'/>
    SF_VARIANT = VT_VARIANT,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_RECORD"]/*'/>
    SF_RECORD = VT_RECORD,
    /// <include file='SF_TYPE.xml' path='doc/member[@name="SF_TYPE.SF_HAVEIID"]/*'/>
    SF_HAVEIID = (VT_UNKNOWN | VT_RESERVED),
}