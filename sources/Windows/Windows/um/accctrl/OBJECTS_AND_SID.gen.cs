// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='OBJECTS_AND_SID.xml' path='doc/member[@name="OBJECTS_AND_SID"]/*'/>
public unsafe partial struct OBJECTS_AND_SID
{
    /// <include file='OBJECTS_AND_SID.xml' path='doc/member[@name="OBJECTS_AND_SID.ObjectsPresent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ObjectsPresent;
    /// <include file='OBJECTS_AND_SID.xml' path='doc/member[@name="OBJECTS_AND_SID.ObjectTypeGuid"]/*'/>
    public Guid ObjectTypeGuid;
    /// <include file='OBJECTS_AND_SID.xml' path='doc/member[@name="OBJECTS_AND_SID.InheritedObjectTypeGuid"]/*'/>
    public Guid InheritedObjectTypeGuid;
    /// <include file='OBJECTS_AND_SID.xml' path='doc/member[@name="OBJECTS_AND_SID.pSid"]/*'/>
    public SID* pSid;
}