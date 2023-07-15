// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='REGPINMEDIUM.xml' path='doc/member[@name="REGPINMEDIUM"]/*'/>
public partial struct REGPINMEDIUM
{
    /// <include file='REGPINMEDIUM.xml' path='doc/member[@name="REGPINMEDIUM.clsMedium"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsMedium;
    /// <include file='REGPINMEDIUM.xml' path='doc/member[@name="REGPINMEDIUM.dw1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dw1;
    /// <include file='REGPINMEDIUM.xml' path='doc/member[@name="REGPINMEDIUM.dw2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dw2;
}