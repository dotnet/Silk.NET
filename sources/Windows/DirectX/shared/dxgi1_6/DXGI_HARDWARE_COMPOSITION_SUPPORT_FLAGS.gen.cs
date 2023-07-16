// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS"]/*'/>
[Flags]
public enum DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS
{
    /// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN"]/*'/>
    DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN = 1,
    /// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED"]/*'/>
    DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED = 2,
    /// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED"]/*'/>
    DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED = 4,
}