// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DXGI_OUTDUPL_POINTER_POSITION.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_POSITION"]/*' />
public partial struct DXGI_OUTDUPL_POINTER_POSITION
{
    /// <include file='DXGI_OUTDUPL_POINTER_POSITION.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_POSITION.Position"]/*' />
    public POINT Position;

    /// <include file='DXGI_OUTDUPL_POINTER_POSITION.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_POSITION.Visible"]/*' />
    public BOOL Visible;
}
