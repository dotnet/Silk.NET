// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG"]/*'/>
[Flags]
public enum DXGI_SWAP_CHAIN_FLAG
{
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_NONPREROTATED"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_NONPREROTATED = 1,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH = 2,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE = 4,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT = 8,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER = 16,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY = 32,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT = 64,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER = 128,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO = 256,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO = 512,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED = 1024,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING = 2048,
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS"]/*'/>
    DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS = 4096,
}