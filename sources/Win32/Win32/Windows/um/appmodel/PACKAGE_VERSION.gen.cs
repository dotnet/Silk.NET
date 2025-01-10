// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct PACKAGE_VERSION
{
    [NativeTypeName("__AnonymousRecord_appmodel_L57_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ulong Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Version; }
    }

    [UnscopedRef]
    public ref ushort Revision
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Revision; }
    }

    [UnscopedRef]
    public ref ushort Build
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Build; }
    }

    [UnscopedRef]
    public ref ushort Minor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Minor; }
    }

    [UnscopedRef]
    public ref ushort Major
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Major; }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong Version;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_appmodel_L59_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public ushort Revision;
            public ushort Build;
            public ushort Minor;
            public ushort Major;
        }
    }
}
