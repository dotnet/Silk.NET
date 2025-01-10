// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct VALENTA
{
    [NativeTypeName("LPSTR")]
    public sbyte* ve_valuename;

    [NativeTypeName("DWORD")]
    public uint ve_valuelen;

    [NativeTypeName("DWORD_PTR")]
    public nuint ve_valueptr;

    [NativeTypeName("DWORD")]
    public uint ve_type;
}
