// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA"]/*'/>
public unsafe partial struct FINDREPLACEA
{
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.lpstrFindWhat"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFindWhat;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.lpstrReplaceWith"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrReplaceWith;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.wFindWhatLen"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wFindWhatLen;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.wReplaceWithLen"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReplaceWithLen;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.lpfnHook"]/*'/>
    [NativeTypeName("LPFRHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;
    /// <include file='FINDREPLACEA.xml' path='doc/member[@name="FINDREPLACEA.lpTemplateName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
}