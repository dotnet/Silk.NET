// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_ENCODE_PARA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("PFN_CRYPT_ALLOC")]
    public delegate* unmanaged<nuint, void*> pfnAlloc;

    [NativeTypeName("PFN_CRYPT_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;
}
