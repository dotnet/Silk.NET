// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='DESKTOP_SLIDESHOW_OPTIONS.xml' path='doc/member[@name="DESKTOP_SLIDESHOW_OPTIONS"]/*' />
[Flags]
public enum DESKTOP_SLIDESHOW_OPTIONS
{
    /// <include file='DESKTOP_SLIDESHOW_OPTIONS.xml' path='doc/member[@name="DESKTOP_SLIDESHOW_OPTIONS.DSO_SHUFFLEIMAGES"]/*' />
    DSO_SHUFFLEIMAGES = 0x1,
}
