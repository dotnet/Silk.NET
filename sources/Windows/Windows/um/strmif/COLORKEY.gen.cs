// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='COLORKEY.xml' path='doc/member[@name="COLORKEY"]/*'/>
public partial struct COLORKEY
{
    /// <include file='COLORKEY.xml' path='doc/member[@name="COLORKEY.KeyType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint KeyType;
    /// <include file='COLORKEY.xml' path='doc/member[@name="COLORKEY.PaletteIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PaletteIndex;
    /// <include file='COLORKEY.xml' path='doc/member[@name="COLORKEY.LowColorValue"]/*'/>
    public COLORREF LowColorValue;
    /// <include file='COLORKEY.xml' path='doc/member[@name="COLORKEY.HighColorValue"]/*'/>
    public COLORREF HighColorValue;
}