// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='REGFILTER.xml' path='doc/member[@name="REGFILTER"]/*'/>
public unsafe partial struct REGFILTER
{
    /// <include file='REGFILTER.xml' path='doc/member[@name="REGFILTER.Clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid Clsid;
    /// <include file='REGFILTER.xml' path='doc/member[@name="REGFILTER.Name"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* Name;
}