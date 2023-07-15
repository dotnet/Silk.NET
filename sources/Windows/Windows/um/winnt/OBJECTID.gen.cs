// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='OBJECTID.xml' path='doc/member[@name="OBJECTID"]/*'/>
public partial struct OBJECTID
{
    /// <include file='OBJECTID.xml' path='doc/member[@name="OBJECTID.Lineage"]/*'/>
    public Guid Lineage;
    /// <include file='OBJECTID.xml' path='doc/member[@name="OBJECTID.Uniquifier"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Uniquifier;
}