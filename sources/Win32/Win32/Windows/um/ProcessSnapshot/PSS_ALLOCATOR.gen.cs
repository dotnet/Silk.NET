// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_ALLOCATOR
{
    public void* Context;

    [NativeTypeName("void *(*)(void *, DWORD) __attribute__((stdcall))")]
    public delegate* unmanaged<void*, uint, void*> AllocRoutine;

    [NativeTypeName("void (*)(void *, void *) __attribute__((stdcall))")]
    public delegate* unmanaged<void*, void*, void> FreeRoutine;
}
