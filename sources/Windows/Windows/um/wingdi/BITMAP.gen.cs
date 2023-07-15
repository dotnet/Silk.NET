// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BITMAP.xml' path='doc/member[@name="BITMAP"]/*'/>
public unsafe partial struct BITMAP
{
    /// <include file='BITMAP.xml' path='doc/member[@name="BITMAP.bmType"]/*'/>
    [NativeTypeName("LONG")]
    public int bmType;
    /// <include file='BITMAP.xml' path='doc/member[@name="BITMAP.bmWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int bmWidth;
    /// <include file='BITMAP.xml' path='doc/member[@name="BITMAP.bmHeight"]/*'/>
    [NativeTypeName("LONG")]
    public int bmHeight;
    /// <include file='BITMAP.xml' path='doc/member[@name="BITMAP.bmWidthBytes"]/*'/>
    [NativeTypeName("LONG")]
    public int bmWidthBytes;
    /// <include file='BITMAP.xml' path='doc/member[@name="BITMAP.bmPlanes"]/*'/>
    [NativeTypeName("WORD")]
    public ushort bmPlanes;
    /// <include file='BITMAP.xml' path='doc/member[@name="BITMAP.bmBitsPixel"]/*'/>
    [NativeTypeName("WORD")]
    public ushort bmBitsPixel;
    /// <include file='BITMAP.xml' path='doc/member[@name="BITMAP.bmBits"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* bmBits;
}