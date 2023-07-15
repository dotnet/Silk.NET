// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE"]/*'/>
public partial struct CURSORSHAPE
{
    /// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE.xHotSpot"]/*'/>
    public int xHotSpot;
    /// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE.yHotSpot"]/*'/>
    public int yHotSpot;
    /// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE.cx"]/*'/>
    public int cx;
    /// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE.cy"]/*'/>
    public int cy;
    /// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE.cbWidth"]/*'/>
    public int cbWidth;
    /// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE.Planes"]/*'/>
    public byte Planes;
    /// <include file='CURSORSHAPE.xml' path='doc/member[@name="CURSORSHAPE.BitsPixel"]/*'/>
    public byte BitsPixel;
}