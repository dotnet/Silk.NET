// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DWRITE_FONT_AXIS_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_FONT_AXIS_ATTRIBUTES"]/*'/>
[Flags]
public enum DWRITE_FONT_AXIS_ATTRIBUTES
{
    /// <include file='DWRITE_FONT_AXIS_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_FONT_AXIS_ATTRIBUTES.DWRITE_FONT_AXIS_ATTRIBUTES_NONE"]/*'/>
    DWRITE_FONT_AXIS_ATTRIBUTES_NONE = 0x0000,
    /// <include file='DWRITE_FONT_AXIS_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_FONT_AXIS_ATTRIBUTES.DWRITE_FONT_AXIS_ATTRIBUTES_VARIABLE"]/*'/>
    DWRITE_FONT_AXIS_ATTRIBUTES_VARIABLE = 0x0001,
    /// <include file='DWRITE_FONT_AXIS_ATTRIBUTES.xml' path='doc/member[@name="DWRITE_FONT_AXIS_ATTRIBUTES.DWRITE_FONT_AXIS_ATTRIBUTES_HIDDEN"]/*'/>
    DWRITE_FONT_AXIS_ATTRIBUTES_HIDDEN = 0x0002,
}