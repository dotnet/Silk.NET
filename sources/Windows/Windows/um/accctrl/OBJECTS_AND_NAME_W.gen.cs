// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OBJECTS_AND_NAME_W.xml' path='doc/member[@name="OBJECTS_AND_NAME_W"]/*'/>
public unsafe partial struct OBJECTS_AND_NAME_W
{
    /// <include file='OBJECTS_AND_NAME_W.xml' path='doc/member[@name="OBJECTS_AND_NAME_W.ObjectsPresent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ObjectsPresent;
    /// <include file='OBJECTS_AND_NAME_W.xml' path='doc/member[@name="OBJECTS_AND_NAME_W.ObjectType"]/*'/>
    public SE_OBJECT_TYPE ObjectType;
    /// <include file='OBJECTS_AND_NAME_W.xml' path='doc/member[@name="OBJECTS_AND_NAME_W.ObjectTypeName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* ObjectTypeName;
    /// <include file='OBJECTS_AND_NAME_W.xml' path='doc/member[@name="OBJECTS_AND_NAME_W.InheritedObjectTypeName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* InheritedObjectTypeName;
    /// <include file='OBJECTS_AND_NAME_W.xml' path='doc/member[@name="OBJECTS_AND_NAME_W.ptstrName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* ptstrName;
}