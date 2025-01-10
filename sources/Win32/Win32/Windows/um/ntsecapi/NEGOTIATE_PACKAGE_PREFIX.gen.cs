// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct NEGOTIATE_PACKAGE_PREFIX
{
    [NativeTypeName("ULONG_PTR")]
    public nuint PackageId;

    [NativeTypeName("PVOID")]
    public void* PackageDataA;

    [NativeTypeName("PVOID")]
    public void* PackageDataW;

    [NativeTypeName("ULONG_PTR")]
    public nuint PrefixLen;

    [NativeTypeName("UCHAR[32]")]
    public _Prefix_e__FixedBuffer Prefix;

    [InlineArray(32)]
    public partial struct _Prefix_e__FixedBuffer
    {
        public byte e0;
    }
}
