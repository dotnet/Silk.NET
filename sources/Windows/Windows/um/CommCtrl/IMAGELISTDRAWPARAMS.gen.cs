// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS"]/*'/>
public partial struct IMAGELISTDRAWPARAMS
{
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.himl"]/*'/>
    public HIMAGELIST himl;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.i"]/*'/>
    public int i;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.hdcDst"]/*'/>
    public HDC hdcDst;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.x"]/*'/>
    public int x;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.y"]/*'/>
    public int y;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.cx"]/*'/>
    public int cx;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.cy"]/*'/>
    public int cy;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.xBitmap"]/*'/>
    public int xBitmap;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.yBitmap"]/*'/>
    public int yBitmap;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.rgbBk"]/*'/>
    public COLORREF rgbBk;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.rgbFg"]/*'/>
    public COLORREF rgbFg;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.fStyle"]/*'/>
    public uint fStyle;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.dwRop"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRop;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.fState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fState;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.Frame"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Frame;
    /// <include file='IMAGELISTDRAWPARAMS.xml' path='doc/member[@name="IMAGELISTDRAWPARAMS.crEffect"]/*'/>
    public COLORREF crEffect;
}