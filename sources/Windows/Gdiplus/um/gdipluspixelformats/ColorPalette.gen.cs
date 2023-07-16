// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette"]/*'/>
public unsafe partial struct ColorPalette
{
    /// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette.Flags"]/*'/>
    public uint Flags;
    /// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette.Count"]/*'/>
    public uint Count;
    /// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette.Entries"]/*'/>
    [NativeTypeName("ARGB[1]")]
    public fixed uint Entries[1];
}