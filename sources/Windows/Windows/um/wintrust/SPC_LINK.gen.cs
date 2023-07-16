// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SPC_LINK.xml' path='doc/member[@name="SPC_LINK"]/*'/>
public unsafe partial struct SPC_LINK
{
    /// <include file='SPC_LINK.xml' path='doc/member[@name="SPC_LINK.dwLinkChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLinkChoice;
    /// <include file='SPC_LINK.xml' path='doc/member[@name="SPC_LINK.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_WinTrust_L1275_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszUrl"]/*'/>
    [UnscopedRef]
    public ref ushort* pwszUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pwszUrl;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Moniker"]/*'/>
    [UnscopedRef]
    public ref SPC_SERIALIZED_OBJECT Moniker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Moniker;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszFile"]/*'/>
    [UnscopedRef]
    public ref ushort* pwszFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pwszFile;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszUrl"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszUrl;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Moniker"]/*'/>
        [FieldOffset(0)]
        public SPC_SERIALIZED_OBJECT Moniker;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszFile"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszFile;
    }
}