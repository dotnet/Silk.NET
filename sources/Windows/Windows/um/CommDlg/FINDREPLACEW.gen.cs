// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW"]/*'/>
public unsafe partial struct FINDREPLACEW
{
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.lpstrFindWhat"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrFindWhat;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.lpstrReplaceWith"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrReplaceWith;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.wFindWhatLen"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wFindWhatLen;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.wReplaceWithLen"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReplaceWithLen;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.lpfnHook"]/*'/>
    [NativeTypeName("LPFRHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;
    /// <include file='FINDREPLACEW.xml' path='doc/member[@name="FINDREPLACEW.lpTemplateName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpTemplateName;
}