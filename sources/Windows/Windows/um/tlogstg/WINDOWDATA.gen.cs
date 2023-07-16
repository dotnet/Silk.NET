// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINDOWDATA.xml' path='doc/member[@name="WINDOWDATA"]/*'/>
public unsafe partial struct WINDOWDATA
{
    /// <include file='WINDOWDATA.xml' path='doc/member[@name="WINDOWDATA.dwWindowID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwWindowID;
    /// <include file='WINDOWDATA.xml' path='doc/member[@name="WINDOWDATA.uiCP"]/*'/>
    public uint uiCP;
    /// <include file='WINDOWDATA.xml' path='doc/member[@name="WINDOWDATA.pidl"]/*'/>
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidl;
    /// <include file='WINDOWDATA.xml' path='doc/member[@name="WINDOWDATA.lpszUrl"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszUrl;
    /// <include file='WINDOWDATA.xml' path='doc/member[@name="WINDOWDATA.lpszUrlLocation"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszUrlLocation;
    /// <include file='WINDOWDATA.xml' path='doc/member[@name="WINDOWDATA.lpszTitle"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszTitle;
}