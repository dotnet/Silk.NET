// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='PROPERTYKEY.xml' path='doc/member[@name="PROPERTYKEY"]/*'/>
public partial struct PROPERTYKEY
{
    /// <include file='PROPERTYKEY.xml' path='doc/member[@name="PROPERTYKEY.fmtid"]/*'/>
    public Guid fmtid;
    /// <include file='PROPERTYKEY.xml' path='doc/member[@name="PROPERTYKEY.pid"]/*'/>
    [NativeTypeName("DWORD")]
    public uint pid;
}