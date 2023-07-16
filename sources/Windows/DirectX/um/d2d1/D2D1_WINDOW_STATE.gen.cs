// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='D2D1_WINDOW_STATE.xml' path='doc/member[@name="D2D1_WINDOW_STATE"]/*'/>
[Flags]
public enum D2D1_WINDOW_STATE
{
    /// <include file='D2D1_WINDOW_STATE.xml' path='doc/member[@name="D2D1_WINDOW_STATE.D2D1_WINDOW_STATE_NONE"]/*'/>
    D2D1_WINDOW_STATE_NONE = 0x0000000,
    /// <include file='D2D1_WINDOW_STATE.xml' path='doc/member[@name="D2D1_WINDOW_STATE.D2D1_WINDOW_STATE_OCCLUDED"]/*'/>
    D2D1_WINDOW_STATE_OCCLUDED = 0x0000001,
    /// <include file='D2D1_WINDOW_STATE.xml' path='doc/member[@name="D2D1_WINDOW_STATE.D2D1_WINDOW_STATE_FORCE_DWORD"]/*'/>
    D2D1_WINDOW_STATE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}