// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D2D1_HWND_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES"]/*'/>
public partial struct D2D1_HWND_RENDER_TARGET_PROPERTIES
{
    /// <include file='D2D1_HWND_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='D2D1_HWND_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES.pixelSize"]/*'/>
    [NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U pixelSize;
    /// <include file='D2D1_HWND_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES.presentOptions"]/*'/>
    public D2D1_PRESENT_OPTIONS presentOptions;
}