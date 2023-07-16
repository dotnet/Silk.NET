// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT"]/*'/>
public partial struct DEBUG_EVENT
{
    /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.dwDebugEventCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDebugEventCode;
    /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.dwProcessId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProcessId;
    /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.dwThreadId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwThreadId;
    /// <include file='DEBUG_EVENT.xml' path='doc/member[@name="DEBUG_EVENT.u"]/*'/>
    [NativeTypeName("__AnonymousRecord_minwinbase_L370_C5")]
    public _u_e__Union u;
    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Exception"]/*'/>
        [FieldOffset(0)]
        public EXCEPTION_DEBUG_INFO Exception;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.CreateThread"]/*'/>
        [FieldOffset(0)]
        public CREATE_THREAD_DEBUG_INFO CreateThread;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.CreateProcessInfo"]/*'/>
        [FieldOffset(0)]
        public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.ExitThread"]/*'/>
        [FieldOffset(0)]
        public EXIT_THREAD_DEBUG_INFO ExitThread;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.ExitProcess"]/*'/>
        [FieldOffset(0)]
        public EXIT_PROCESS_DEBUG_INFO ExitProcess;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.LoadDll"]/*'/>
        [FieldOffset(0)]
        public LOAD_DLL_DEBUG_INFO LoadDll;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UnloadDll"]/*'/>
        [FieldOffset(0)]
        public UNLOAD_DLL_DEBUG_INFO UnloadDll;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.DebugString"]/*'/>
        [FieldOffset(0)]
        public OUTPUT_DEBUG_STRING_INFO DebugString;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.RipInfo"]/*'/>
        [FieldOffset(0)]
        public RIP_INFO RipInfo;
    }
}