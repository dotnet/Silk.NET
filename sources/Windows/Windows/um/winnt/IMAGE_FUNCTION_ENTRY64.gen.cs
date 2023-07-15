// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_FUNCTION_ENTRY64.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY64"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_FUNCTION_ENTRY64
{
    /// <include file='IMAGE_FUNCTION_ENTRY64.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY64.StartingAddress"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong StartingAddress;
    /// <include file='IMAGE_FUNCTION_ENTRY64.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY64.EndingAddress"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong EndingAddress;
    /// <include file='IMAGE_FUNCTION_ENTRY64.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY64.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L20470_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EndOfPrologue"]/*'/>
    [UnscopedRef]
    public ref ulong EndOfPrologue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.EndOfPrologue;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UnwindInfoAddress"]/*'/>
    [UnscopedRef]
    public ref ulong UnwindInfoAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.UnwindInfoAddress;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EndOfPrologue"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong EndOfPrologue;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UnwindInfoAddress"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong UnwindInfoAddress;
    }
}