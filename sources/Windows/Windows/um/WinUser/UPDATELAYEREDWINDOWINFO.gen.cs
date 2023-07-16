// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO"]/*'/>
public unsafe partial struct UPDATELAYEREDWINDOWINFO
{
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.hdcDst"]/*'/>
    public HDC hdcDst;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.pptDst"]/*'/>
    [NativeTypeName("const POINT *")]
    public POINT* pptDst;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.psize"]/*'/>
    [NativeTypeName("const SIZE *")]
    public SIZE* psize;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.hdcSrc"]/*'/>
    public HDC hdcSrc;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.pptSrc"]/*'/>
    [NativeTypeName("const POINT *")]
    public POINT* pptSrc;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.crKey"]/*'/>
    public COLORREF crKey;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.pblend"]/*'/>
    [NativeTypeName("const BLENDFUNCTION *")]
    public BLENDFUNCTION* pblend;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='UPDATELAYEREDWINDOWINFO.xml' path='doc/member[@name="UPDATELAYEREDWINDOWINFO.prcDirty"]/*'/>
    [NativeTypeName("const RECT *")]
    public RECT* prcDirty;
}