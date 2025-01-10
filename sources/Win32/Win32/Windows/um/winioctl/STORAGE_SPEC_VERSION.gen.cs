// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_SPEC_VERSION
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winioctl_L2620_C5")]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint AsUlong;

    [UnscopedRef]
    public ref _Anonymous_e__Struct._MinorVersion_e__Union MinorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.MinorVersion; }
    }

    [UnscopedRef]
    public ref ushort MajorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.MajorVersion; }
    }

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("__AnonymousRecord_winioctl_L2621_C9")]
        public _MinorVersion_e__Union MinorVersion;

        [NativeTypeName("WORD")]
        public ushort MajorVersion;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _MinorVersion_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winioctl_L2622_C13")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort AsUshort;

            [UnscopedRef]
            public ref byte SubMinor
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Anonymous.SubMinor; }
            }

            [UnscopedRef]
            public ref byte Minor
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Anonymous.Minor; }
            }

            public partial struct _Anonymous_e__Struct
            {
                public byte SubMinor;
                public byte Minor;
            }
        }
    }
}
