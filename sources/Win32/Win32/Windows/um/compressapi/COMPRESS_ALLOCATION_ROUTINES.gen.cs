// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/compressapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct COMPRESS_ALLOCATION_ROUTINES
{
    [NativeTypeName("PFN_COMPRESS_ALLOCATE")]
    public delegate* unmanaged<void*, nuint, void*> Allocate;

    [NativeTypeName("PFN_COMPRESS_FREE")]
    public delegate* unmanaged<void*, void*, void> Free;

    [NativeTypeName("PVOID")]
    public void* UserContext;
}
