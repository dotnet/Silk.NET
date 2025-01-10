// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISK_DETECTION_INFO
{
    [NativeTypeName("DWORD")]
    public uint SizeOfDetectInfo;
    public DETECTION_TYPE DetectionType;

    [NativeTypeName("__AnonymousRecord_winioctl_L9420_C9")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref DISK_INT13_INFO Int13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Int13; }
    }

    [UnscopedRef]
    public ref DISK_EX_INT13_INFO ExInt13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.ExInt13; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L9421_C17")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public DISK_INT13_INFO Int13;
            public DISK_EX_INT13_INFO ExInt13;
        }
    }
}
