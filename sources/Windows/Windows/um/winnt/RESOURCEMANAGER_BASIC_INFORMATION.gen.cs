// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='RESOURCEMANAGER_BASIC_INFORMATION.xml' path='doc/member[@name="RESOURCEMANAGER_BASIC_INFORMATION"]/*'/>
public unsafe partial struct RESOURCEMANAGER_BASIC_INFORMATION
{
    /// <include file='RESOURCEMANAGER_BASIC_INFORMATION.xml' path='doc/member[@name="RESOURCEMANAGER_BASIC_INFORMATION.ResourceManagerId"]/*'/>
    public Guid ResourceManagerId;
    /// <include file='RESOURCEMANAGER_BASIC_INFORMATION.xml' path='doc/member[@name="RESOURCEMANAGER_BASIC_INFORMATION.DescriptionLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DescriptionLength;
    /// <include file='RESOURCEMANAGER_BASIC_INFORMATION.xml' path='doc/member[@name="RESOURCEMANAGER_BASIC_INFORMATION.Description"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Description[1];
}