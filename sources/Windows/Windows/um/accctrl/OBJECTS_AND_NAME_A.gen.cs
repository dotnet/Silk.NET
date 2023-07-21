// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OBJECTS_AND_NAME_A.xml' path='doc/member[@name="OBJECTS_AND_NAME_A"]/*' />
public unsafe partial struct OBJECTS_AND_NAME_A
{
    /// <include file='OBJECTS_AND_NAME_A.xml' path='doc/member[@name="OBJECTS_AND_NAME_A.ObjectsPresent"]/*' />
    [NativeTypeName("DWORD")]
    public uint ObjectsPresent;

    /// <include file='OBJECTS_AND_NAME_A.xml' path='doc/member[@name="OBJECTS_AND_NAME_A.ObjectType"]/*' />
    public SE_OBJECT_TYPE ObjectType;

    /// <include file='OBJECTS_AND_NAME_A.xml' path='doc/member[@name="OBJECTS_AND_NAME_A.ObjectTypeName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* ObjectTypeName;

    /// <include file='OBJECTS_AND_NAME_A.xml' path='doc/member[@name="OBJECTS_AND_NAME_A.InheritedObjectTypeName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* InheritedObjectTypeName;

    /// <include file='OBJECTS_AND_NAME_A.xml' path='doc/member[@name="OBJECTS_AND_NAME_A.ptstrName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* ptstrName;
}
