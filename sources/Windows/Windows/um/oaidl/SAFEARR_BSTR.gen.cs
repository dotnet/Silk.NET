// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SAFEARR_BSTR.xml' path='doc/member[@name="SAFEARR_BSTR"]/*'/>
public unsafe partial struct SAFEARR_BSTR
{
    /// <include file='SAFEARR_BSTR.xml' path='doc/member[@name="SAFEARR_BSTR.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='SAFEARR_BSTR.xml' path='doc/member[@name="SAFEARR_BSTR.aBstr"]/*'/>
    [NativeTypeName("wireBSTR *")]
    public FLAGGED_WORD_BLOB** aBstr;
}