// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/compressapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='COMPRESS_ALLOCATION_ROUTINES.xml' path='doc/member[@name="COMPRESS_ALLOCATION_ROUTINES"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct COMPRESS_ALLOCATION_ROUTINES
{
    /// <include file='COMPRESS_ALLOCATION_ROUTINES.xml' path='doc/member[@name="COMPRESS_ALLOCATION_ROUTINES.Allocate"]/*'/>
    [NativeTypeName("PFN_COMPRESS_ALLOCATE")]
    public delegate* unmanaged<void*, nuint, void*> Allocate;
    /// <include file='COMPRESS_ALLOCATION_ROUTINES.xml' path='doc/member[@name="COMPRESS_ALLOCATION_ROUTINES.Free"]/*'/>
    [NativeTypeName("PFN_COMPRESS_FREE")]
    public delegate* unmanaged<void*, void*, void> Free;
    /// <include file='COMPRESS_ALLOCATION_ROUTINES.xml' path='doc/member[@name="COMPRESS_ALLOCATION_ROUTINES.UserContext"]/*'/>
    [NativeTypeName("PVOID")]
    public void* UserContext;
}