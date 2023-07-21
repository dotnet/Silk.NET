// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY"]/*' />
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_HANDLE_ENTRY
{
    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.Handle"]/*' />
    public HANDLE Handle;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.Flags"]/*' />
    public PSS_HANDLE_FLAGS Flags;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.ObjectType"]/*' />
    public PSS_OBJECT_TYPE ObjectType;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.CaptureTime"]/*' />
    public FILETIME CaptureTime;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.Attributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint Attributes;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.GrantedAccess"]/*' />
    [NativeTypeName("DWORD")]
    public uint GrantedAccess;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.HandleCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint HandleCount;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.PointerCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint PointerCount;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.PagedPoolCharge"]/*' />
    [NativeTypeName("DWORD")]
    public uint PagedPoolCharge;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.NonPagedPoolCharge"]/*' />
    [NativeTypeName("DWORD")]
    public uint NonPagedPoolCharge;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.CreationTime"]/*' />
    public FILETIME CreationTime;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.TypeNameLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort TypeNameLength;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.TypeName"]/*' />
    [NativeTypeName("const wchar_t *")]
    public ushort* TypeName;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.ObjectNameLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort ObjectNameLength;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.ObjectName"]/*' />
    [NativeTypeName("const wchar_t *")]
    public ushort* ObjectName;

    /// <include file='PSS_HANDLE_ENTRY.xml' path='doc/member[@name="PSS_HANDLE_ENTRY.TypeSpecificInformation"]/*' />
    [NativeTypeName("__AnonymousRecord_ProcessSnapshot_L258_C5")]
    public _TypeSpecificInformation_e__Union TypeSpecificInformation;

    /// <include file='_TypeSpecificInformation_e__Union.xml' path='doc/member[@name="_TypeSpecificInformation_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _TypeSpecificInformation_e__Union
    {
        /// <include file='_TypeSpecificInformation_e__Union.xml' path='doc/member[@name="_TypeSpecificInformation_e__Union.Process"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ProcessSnapshot_L261_C9")]
        public _Process_e__Struct Process;

        /// <include file='_TypeSpecificInformation_e__Union.xml' path='doc/member[@name="_TypeSpecificInformation_e__Union.Thread"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ProcessSnapshot_L272_C9")]
        public _Thread_e__Struct Thread;

        /// <include file='_TypeSpecificInformation_e__Union.xml' path='doc/member[@name="_TypeSpecificInformation_e__Union.Mutant"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ProcessSnapshot_L284_C9")]
        public _Mutant_e__Struct Mutant;

        /// <include file='_TypeSpecificInformation_e__Union.xml' path='doc/member[@name="_TypeSpecificInformation_e__Union.Event"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ProcessSnapshot_L292_C9")]
        public _Event_e__Struct Event;

        /// <include file='_TypeSpecificInformation_e__Union.xml' path='doc/member[@name="_TypeSpecificInformation_e__Union.Section"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ProcessSnapshot_L298_C9")]
        public _Section_e__Struct Section;

        /// <include file='_TypeSpecificInformation_e__Union.xml' path='doc/member[@name="_TypeSpecificInformation_e__Union.Semaphore"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ProcessSnapshot_L306_C9")]
        public _Semaphore_e__Struct Semaphore;

        /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct"]/*' />
        public unsafe partial struct _Process_e__Struct
        {
            /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct.ExitStatus"]/*' />
            [NativeTypeName("DWORD")]
            public uint ExitStatus;

            /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct.PebBaseAddress"]/*' />
            public void* PebBaseAddress;

            /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct.AffinityMask"]/*' />
            [NativeTypeName("ULONG_PTR")]
            public nuint AffinityMask;

            /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct.BasePriority"]/*' />
            [NativeTypeName("LONG")]
            public int BasePriority;

            /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct.ProcessId"]/*' />
            [NativeTypeName("DWORD")]
            public uint ProcessId;

            /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct.ParentProcessId"]/*' />
            [NativeTypeName("DWORD")]
            public uint ParentProcessId;

            /// <include file='_Process_e__Struct.xml' path='doc/member[@name="_Process_e__Struct.Flags"]/*' />
            [NativeTypeName("DWORD")]
            public uint Flags;
        }

        /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct"]/*' />
        public unsafe partial struct _Thread_e__Struct
        {
            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.ExitStatus"]/*' />
            [NativeTypeName("DWORD")]
            public uint ExitStatus;

            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.TebBaseAddress"]/*' />
            public void* TebBaseAddress;

            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.ProcessId"]/*' />
            [NativeTypeName("DWORD")]
            public uint ProcessId;

            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.ThreadId"]/*' />
            [NativeTypeName("DWORD")]
            public uint ThreadId;

            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.AffinityMask"]/*' />
            [NativeTypeName("ULONG_PTR")]
            public nuint AffinityMask;

            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.Priority"]/*' />
            public int Priority;

            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.BasePriority"]/*' />
            public int BasePriority;

            /// <include file='_Thread_e__Struct.xml' path='doc/member[@name="_Thread_e__Struct.Win32StartAddress"]/*' />
            public void* Win32StartAddress;
        }

        /// <include file='_Mutant_e__Struct.xml' path='doc/member[@name="_Mutant_e__Struct"]/*' />
        public partial struct _Mutant_e__Struct
        {
            /// <include file='_Mutant_e__Struct.xml' path='doc/member[@name="_Mutant_e__Struct.CurrentCount"]/*' />
            [NativeTypeName("LONG")]
            public int CurrentCount;

            /// <include file='_Mutant_e__Struct.xml' path='doc/member[@name="_Mutant_e__Struct.Abandoned"]/*' />
            public BOOL Abandoned;

            /// <include file='_Mutant_e__Struct.xml' path='doc/member[@name="_Mutant_e__Struct.OwnerProcessId"]/*' />
            [NativeTypeName("DWORD")]
            public uint OwnerProcessId;

            /// <include file='_Mutant_e__Struct.xml' path='doc/member[@name="_Mutant_e__Struct.OwnerThreadId"]/*' />
            [NativeTypeName("DWORD")]
            public uint OwnerThreadId;
        }

        /// <include file='_Event_e__Struct.xml' path='doc/member[@name="_Event_e__Struct"]/*' />
        public partial struct _Event_e__Struct
        {
            /// <include file='_Event_e__Struct.xml' path='doc/member[@name="_Event_e__Struct.ManualReset"]/*' />
            public BOOL ManualReset;

            /// <include file='_Event_e__Struct.xml' path='doc/member[@name="_Event_e__Struct.Signaled"]/*' />
            public BOOL Signaled;
        }

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct"]/*' />
        public unsafe partial struct _Section_e__Struct
        {
            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.BaseAddress"]/*' />
            public void* BaseAddress;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.AllocationAttributes"]/*' />
            [NativeTypeName("DWORD")]
            public uint AllocationAttributes;

            /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.MaximumSize"]/*' />
            public LARGE_INTEGER MaximumSize;
        }

        /// <include file='_Semaphore_e__Struct.xml' path='doc/member[@name="_Semaphore_e__Struct"]/*' />
        public partial struct _Semaphore_e__Struct
        {
            /// <include file='_Semaphore_e__Struct.xml' path='doc/member[@name="_Semaphore_e__Struct.CurrentCount"]/*' />
            [NativeTypeName("LONG")]
            public int CurrentCount;

            /// <include file='_Semaphore_e__Struct.xml' path='doc/member[@name="_Semaphore_e__Struct.MaximumCount"]/*' />
            [NativeTypeName("LONG")]
            public int MaximumCount;
        }
    }
}
