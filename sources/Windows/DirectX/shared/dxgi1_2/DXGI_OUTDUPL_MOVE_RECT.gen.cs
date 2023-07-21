// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DXGI_OUTDUPL_MOVE_RECT.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT"]/*' />
public partial struct DXGI_OUTDUPL_MOVE_RECT
{
    /// <include file='DXGI_OUTDUPL_MOVE_RECT.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT.SourcePoint"]/*' />
    public POINT SourcePoint;

    /// <include file='DXGI_OUTDUPL_MOVE_RECT.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT.DestinationRect"]/*' />
    public RECT DestinationRect;
}
