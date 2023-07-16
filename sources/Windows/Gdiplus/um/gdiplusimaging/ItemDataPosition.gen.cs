// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='ItemDataPosition.xml' path='doc/member[@name="ItemDataPosition"]/*'/>
public enum ItemDataPosition
{
    /// <include file='ItemDataPosition.xml' path='doc/member[@name="ItemDataPosition.ItemDataPositionAfterHeader"]/*'/>
    ItemDataPositionAfterHeader = 0x0,
    /// <include file='ItemDataPosition.xml' path='doc/member[@name="ItemDataPosition.ItemDataPositionAfterPalette"]/*'/>
    ItemDataPositionAfterPalette = 0x1,
    /// <include file='ItemDataPosition.xml' path='doc/member[@name="ItemDataPosition.ItemDataPositionAfterBits"]/*'/>
    ItemDataPositionAfterBits = 0x2,
}