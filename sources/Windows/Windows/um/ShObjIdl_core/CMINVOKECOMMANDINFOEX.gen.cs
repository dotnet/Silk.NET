// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX"]/*'/>
public unsafe partial struct CMINVOKECOMMANDINFOEX
{
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.fMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fMask;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpVerb"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpVerb;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpParameters"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpParameters;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpDirectory"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpDirectory;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.nShow"]/*'/>
    public int nShow;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.dwHotKey"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHotKey;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.hIcon"]/*'/>
    public HANDLE hIcon;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpTitle"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpTitle;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpVerbW"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpVerbW;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpParametersW"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpParametersW;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpDirectoryW"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpDirectoryW;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.lpTitleW"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpTitleW;
    /// <include file='CMINVOKECOMMANDINFOEX.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX.ptInvoke"]/*'/>
    public POINT ptInvoke;
}