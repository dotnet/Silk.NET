// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssCaptureSnapshot"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssCaptureSnapshot(HANDLE ProcessHandle, PSS_CAPTURE_FLAGS CaptureFlags, [NativeTypeName("DWORD")] uint ThreadContextFlags, HPSS* SnapshotHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssFreeSnapshot"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssFreeSnapshot(HANDLE ProcessHandle, HPSS SnapshotHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssQuerySnapshot"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssQuerySnapshot(HPSS SnapshotHandle, PSS_QUERY_INFORMATION_CLASS InformationClass, void* Buffer, [NativeTypeName("DWORD")] uint BufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssWalkSnapshot"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssWalkSnapshot(HPSS SnapshotHandle, PSS_WALK_INFORMATION_CLASS InformationClass, HPSSWALK WalkMarkerHandle, void* Buffer, [NativeTypeName("DWORD")] uint BufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssDuplicateSnapshot"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssDuplicateSnapshot(HANDLE SourceProcessHandle, HPSS SnapshotHandle, HANDLE TargetProcessHandle, HPSS* TargetSnapshotHandle, PSS_DUPLICATE_FLAGS Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssWalkMarkerCreate"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssWalkMarkerCreate([NativeTypeName("const PSS_ALLOCATOR *")] PSS_ALLOCATOR* Allocator, HPSSWALK* WalkMarkerHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssWalkMarkerFree"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssWalkMarkerFree(HPSSWALK WalkMarkerHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssWalkMarkerGetPosition"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssWalkMarkerGetPosition(HPSSWALK WalkMarkerHandle, [NativeTypeName("ULONG_PTR *")] nuint* Position);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssWalkMarkerSetPosition"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssWalkMarkerSetPosition(HPSSWALK WalkMarkerHandle, [NativeTypeName("ULONG_PTR")] nuint Position);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PssWalkMarkerSeekToBeginning"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint PssWalkMarkerSeekToBeginning(HPSSWALK WalkMarkerHandle);

    [NativeTypeName("#define PSS_PERF_RESOLUTION 1000000")]
    public const int PSS_PERF_RESOLUTION = 1000000;
}
