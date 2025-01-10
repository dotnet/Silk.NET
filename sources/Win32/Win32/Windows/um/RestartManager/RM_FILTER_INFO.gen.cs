// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct RM_FILTER_INFO
{
    public RM_FILTER_ACTION FilterAction;
    public RM_FILTER_TRIGGER FilterTrigger;

    [NativeTypeName("DWORD")]
    public uint cbNextOffset;

    [NativeTypeName("__AnonymousRecord_RestartManager_L124_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ushort* strFilename
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.strFilename; }
    }

    [UnscopedRef]
    public ref RM_UNIQUE_PROCESS Process
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Process; }
    }

    [UnscopedRef]
    public ref ushort* strServiceShortName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.strServiceShortName; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* strFilename;

        [FieldOffset(0)]
        public RM_UNIQUE_PROCESS Process;

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* strServiceShortName;
    }
}
