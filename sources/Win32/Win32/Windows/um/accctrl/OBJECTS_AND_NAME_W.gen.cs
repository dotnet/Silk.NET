// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OBJECTS_AND_NAME_W
{
    [NativeTypeName("DWORD")]
    public uint ObjectsPresent;
    public SE_OBJECT_TYPE ObjectType;

    [NativeTypeName("LPWSTR")]
    public ushort* ObjectTypeName;

    [NativeTypeName("LPWSTR")]
    public ushort* InheritedObjectTypeName;

    [NativeTypeName("LPWSTR")]
    public ushort* ptstrName;
}
