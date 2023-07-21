// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData"]/*' />
public unsafe partial struct ImageItemData
{
    /// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData.Size"]/*' />
    public uint Size;

    /// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData.Position"]/*' />
    public uint Position;

    /// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData.Desc"]/*' />
    public void* Desc;

    /// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData.DescSize"]/*' />
    public uint DescSize;

    /// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData.Data"]/*' />
    public void* Data;

    /// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData.DataSize"]/*' />
    public uint DataSize;

    /// <include file='ImageItemData.xml' path='doc/member[@name="ImageItemData.Cookie"]/*' />
    public uint Cookie;
}
