// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Gdiplus;
/// <include file='DriverStringOptions.xml' path='doc/member[@name="DriverStringOptions"]/*'/>
[Flags]
public enum DriverStringOptions
{
    /// <include file='DriverStringOptions.xml' path='doc/member[@name="DriverStringOptions.DriverStringOptionsCmapLookup"]/*'/>
    DriverStringOptionsCmapLookup = 1,
    /// <include file='DriverStringOptions.xml' path='doc/member[@name="DriverStringOptions.DriverStringOptionsVertical"]/*'/>
    DriverStringOptionsVertical = 2,
    /// <include file='DriverStringOptions.xml' path='doc/member[@name="DriverStringOptions.DriverStringOptionsRealizedAdvance"]/*'/>
    DriverStringOptionsRealizedAdvance = 4,
    /// <include file='DriverStringOptions.xml' path='doc/member[@name="DriverStringOptions.DriverStringOptionsLimitSubpixel"]/*'/>
    DriverStringOptionsLimitSubpixel = 8,
}