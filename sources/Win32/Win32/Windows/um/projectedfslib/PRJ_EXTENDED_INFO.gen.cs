// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct PRJ_EXTENDED_INFO
{
    public PRJ_EXT_INFO_TYPE InfoType;

    [NativeTypeName("ULONG")]
    public uint NextInfoOffset;

    [NativeTypeName("__AnonymousRecord_projectedfslib_L102_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._Symlink_e__Struct Symlink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Symlink; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_projectedfslib_L103_C9")]
        public _Symlink_e__Struct Symlink;

        public unsafe partial struct _Symlink_e__Struct
        {
            [NativeTypeName("PCWSTR")]
            public ushort* TargetName;
        }
    }
}
