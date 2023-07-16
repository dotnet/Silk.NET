// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PROPSPEC.xml' path='doc/member[@name="PROPSPEC"]/*'/>
public unsafe partial struct PROPSPEC
{
    /// <include file='PROPSPEC.xml' path='doc/member[@name="PROPSPEC.ulKind"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulKind;
    /// <include file='PROPSPEC.xml' path='doc/member[@name="PROPSPEC.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_PropIdlBase_L452_C43")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.propid"]/*'/>
    [UnscopedRef]
    public ref uint propid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.propid;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpwstr"]/*'/>
    [UnscopedRef]
    public ref ushort* lpwstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.lpwstr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.propid"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PROPID")]
        public uint propid;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpwstr"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* lpwstr;
    }
}