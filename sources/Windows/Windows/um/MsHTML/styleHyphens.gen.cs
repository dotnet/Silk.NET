// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleHyphens.xml' path='doc/member[@name="styleHyphens"]/*'/>
public enum styleHyphens
{
    /// <include file='styleHyphens.xml' path='doc/member[@name="styleHyphens.styleHyphensNone"]/*'/>
    styleHyphensNone = 0,
    /// <include file='styleHyphens.xml' path='doc/member[@name="styleHyphens.styleHyphensManual"]/*'/>
    styleHyphensManual = 1,
    /// <include file='styleHyphens.xml' path='doc/member[@name="styleHyphens.styleHyphensAuto"]/*'/>
    styleHyphensAuto = 2,
    /// <include file='styleHyphens.xml' path='doc/member[@name="styleHyphens.styleHyphensNotSet"]/*'/>
    styleHyphensNotSet = 3,
    /// <include file='styleHyphens.xml' path='doc/member[@name="styleHyphens.styleHyphens_Max"]/*'/>
    styleHyphens_Max = 2147483647,
}