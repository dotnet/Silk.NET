// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType"]/*'/>
public enum RotateFlipType
{
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.RotateNoneFlipNone"]/*'/>
    RotateNoneFlipNone = 0,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate90FlipNone"]/*'/>
    Rotate90FlipNone = 1,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate180FlipNone"]/*'/>
    Rotate180FlipNone = 2,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate270FlipNone"]/*'/>
    Rotate270FlipNone = 3,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.RotateNoneFlipX"]/*'/>
    RotateNoneFlipX = 4,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate90FlipX"]/*'/>
    Rotate90FlipX = 5,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate180FlipX"]/*'/>
    Rotate180FlipX = 6,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate270FlipX"]/*'/>
    Rotate270FlipX = 7,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.RotateNoneFlipY"]/*'/>
    RotateNoneFlipY = Rotate180FlipX,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate90FlipY"]/*'/>
    Rotate90FlipY = Rotate270FlipX,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate180FlipY"]/*'/>
    Rotate180FlipY = RotateNoneFlipX,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate270FlipY"]/*'/>
    Rotate270FlipY = Rotate90FlipX,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.RotateNoneFlipXY"]/*'/>
    RotateNoneFlipXY = Rotate180FlipNone,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate90FlipXY"]/*'/>
    Rotate90FlipXY = Rotate270FlipNone,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate180FlipXY"]/*'/>
    Rotate180FlipXY = RotateNoneFlipNone,
    /// <include file='RotateFlipType.xml' path='doc/member[@name="RotateFlipType.Rotate270FlipXY"]/*'/>
    Rotate270FlipXY = Rotate90FlipNone,
}