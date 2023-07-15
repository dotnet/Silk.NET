// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH"]/*'/>
public unsafe partial struct EXTRASEARCH
{
    /// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH.guidSearch"]/*'/>
    public Guid guidSearch;
    /// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH.wszFriendlyName"]/*'/>
    [NativeTypeName("WCHAR[80]")]
    public fixed ushort wszFriendlyName[80];
    /// <include file='EXTRASEARCH.xml' path='doc/member[@name="EXTRASEARCH.wszUrl"]/*'/>
    [NativeTypeName("WCHAR[2084]")]
    public fixed ushort wszUrl[2084];
}