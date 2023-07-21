// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHDRAGIMAGE.xml' path='doc/member[@name="SHDRAGIMAGE"]/*' />
public partial struct SHDRAGIMAGE
{
    /// <include file='SHDRAGIMAGE.xml' path='doc/member[@name="SHDRAGIMAGE.sizeDragImage"]/*' />
    public SIZE sizeDragImage;

    /// <include file='SHDRAGIMAGE.xml' path='doc/member[@name="SHDRAGIMAGE.ptOffset"]/*' />
    public POINT ptOffset;

    /// <include file='SHDRAGIMAGE.xml' path='doc/member[@name="SHDRAGIMAGE.hbmpDragImage"]/*' />
    public HBITMAP hbmpDragImage;

    /// <include file='SHDRAGIMAGE.xml' path='doc/member[@name="SHDRAGIMAGE.crColorKey"]/*' />
    public COLORREF crColorKey;
}
