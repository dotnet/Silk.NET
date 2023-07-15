// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_LAYER_OPTIONS1.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS1"]/*'/>
[Flags]
public enum D2D1_LAYER_OPTIONS1
{
    /// <include file='D2D1_LAYER_OPTIONS1.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS1.D2D1_LAYER_OPTIONS1_NONE"]/*'/>
    D2D1_LAYER_OPTIONS1_NONE = 0,
    /// <include file='D2D1_LAYER_OPTIONS1.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS1.D2D1_LAYER_OPTIONS1_INITIALIZE_FROM_BACKGROUND"]/*'/>
    D2D1_LAYER_OPTIONS1_INITIALIZE_FROM_BACKGROUND = 1,
    /// <include file='D2D1_LAYER_OPTIONS1.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS1.D2D1_LAYER_OPTIONS1_IGNORE_ALPHA"]/*'/>
    D2D1_LAYER_OPTIONS1_IGNORE_ALPHA = 2,
    /// <include file='D2D1_LAYER_OPTIONS1.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS1.D2D1_LAYER_OPTIONS1_FORCE_DWORD"]/*'/>
    D2D1_LAYER_OPTIONS1_FORCE_DWORD = unchecked((int)(0xffffffff)),
}