// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DXGI_OUTDUPL_POINTER_SHAPE_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO"]/*'/>
public partial struct DXGI_OUTDUPL_POINTER_SHAPE_INFO
{
    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO.Type"]/*'/>
    public uint Type;
    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO.Width"]/*'/>
    public uint Width;
    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO.Height"]/*'/>
    public uint Height;
    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO.Pitch"]/*'/>
    public uint Pitch;
    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO.HotSpot"]/*'/>
    public POINT HotSpot;
}