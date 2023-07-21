// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BUTTON_IMAGELIST.xml' path='doc/member[@name="BUTTON_IMAGELIST"]/*' />
public partial struct BUTTON_IMAGELIST
{
    /// <include file='BUTTON_IMAGELIST.xml' path='doc/member[@name="BUTTON_IMAGELIST.himl"]/*' />
    public HIMAGELIST himl;

    /// <include file='BUTTON_IMAGELIST.xml' path='doc/member[@name="BUTTON_IMAGELIST.margin"]/*' />
    public RECT margin;

    /// <include file='BUTTON_IMAGELIST.xml' path='doc/member[@name="BUTTON_IMAGELIST.uAlign"]/*' />
    public uint uAlign;
}
