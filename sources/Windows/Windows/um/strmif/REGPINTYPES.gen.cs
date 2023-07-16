// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='REGPINTYPES.xml' path='doc/member[@name="REGPINTYPES"]/*'/>
public unsafe partial struct REGPINTYPES
{
    /// <include file='REGPINTYPES.xml' path='doc/member[@name="REGPINTYPES.clsMajorType"]/*'/>
    [NativeTypeName("const CLSID *")]
    public Guid* clsMajorType;
    /// <include file='REGPINTYPES.xml' path='doc/member[@name="REGPINTYPES.clsMinorType"]/*'/>
    [NativeTypeName("const CLSID *")]
    public Guid* clsMinorType;
}