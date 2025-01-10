// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_FUNCTION_OVERRIDE_DYNAMIC_RELOCATION
{
    [NativeTypeName("DWORD")]
    public uint OriginalRva;

    [NativeTypeName("DWORD")]
    public uint BDDOffset;

    [NativeTypeName("DWORD")]
    public uint RvaSize;

    [NativeTypeName("DWORD")]
    public uint BaseRelocSize;
}
