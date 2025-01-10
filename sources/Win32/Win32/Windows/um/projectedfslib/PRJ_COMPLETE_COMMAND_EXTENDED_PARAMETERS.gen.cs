// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS
{
    public PRJ_COMPLETE_COMMAND_TYPE CommandType;

    [NativeTypeName("__AnonymousRecord_projectedfslib_L460_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._Notification_e__Struct Notification
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Notification; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._Enumeration_e__Struct Enumeration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Enumeration; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_projectedfslib_L461_C9")]
        public _Notification_e__Struct Notification;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_projectedfslib_L465_C9")]
        public _Enumeration_e__Struct Enumeration;

        public partial struct _Notification_e__Struct
        {
            public PRJ_NOTIFY_TYPES NotificationMask;
        }

        public partial struct _Enumeration_e__Struct
        {
            public PRJ_DIR_ENTRY_BUFFER_HANDLE DirEntryBufferHandle;
        }
    }
}
