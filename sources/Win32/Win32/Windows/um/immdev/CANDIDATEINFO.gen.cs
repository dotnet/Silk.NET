// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CANDIDATEINFO
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwCount;

    [NativeTypeName("DWORD[32]")]
    public _dwOffset_e__FixedBuffer dwOffset;

    [NativeTypeName("DWORD")]
    public uint dwPrivateSize;

    [NativeTypeName("DWORD")]
    public uint dwPrivateOffset;

    [InlineArray(32)]
    public partial struct _dwOffset_e__FixedBuffer
    {
        public uint e0;
    }
}
