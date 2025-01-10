// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_COR20_HEADER
{
    [NativeTypeName("DWORD")]
    public uint cb;

    [NativeTypeName("WORD")]
    public ushort MajorRuntimeVersion;

    [NativeTypeName("WORD")]
    public ushort MinorRuntimeVersion;
    public IMAGE_DATA_DIRECTORY MetaData;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("__AnonymousRecord_winnt_L21707_C5")]
    public _Anonymous_e__Union Anonymous;
    public IMAGE_DATA_DIRECTORY Resources;
    public IMAGE_DATA_DIRECTORY StrongNameSignature;
    public IMAGE_DATA_DIRECTORY CodeManagerTable;
    public IMAGE_DATA_DIRECTORY VTableFixups;
    public IMAGE_DATA_DIRECTORY ExportAddressTableJumps;
    public IMAGE_DATA_DIRECTORY ManagedNativeHeader;

    [UnscopedRef]
    public ref uint EntryPointToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.EntryPointToken; }
    }

    [UnscopedRef]
    public ref uint EntryPointRVA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.EntryPointRVA; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint EntryPointToken;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint EntryPointRVA;
    }
}
