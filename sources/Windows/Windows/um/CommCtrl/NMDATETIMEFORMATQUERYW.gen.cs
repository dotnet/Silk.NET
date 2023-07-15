// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMDATETIMEFORMATQUERYW.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYW"]/*'/>
public unsafe partial struct NMDATETIMEFORMATQUERYW
{
    /// <include file='NMDATETIMEFORMATQUERYW.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYW.nmhdr"]/*'/>
    public NMHDR nmhdr;
    /// <include file='NMDATETIMEFORMATQUERYW.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYW.pszFormat"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszFormat;
    /// <include file='NMDATETIMEFORMATQUERYW.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYW.szMax"]/*'/>
    public SIZE szMax;
}