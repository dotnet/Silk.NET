// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CERT_KEY_CONTEXT.xml' path='doc/member[@name="CERT_KEY_CONTEXT"]/*'/>
public partial struct CERT_KEY_CONTEXT
{
    /// <include file='CERT_KEY_CONTEXT.xml' path='doc/member[@name="CERT_KEY_CONTEXT.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_KEY_CONTEXT.xml' path='doc/member[@name="CERT_KEY_CONTEXT.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L9373_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CERT_KEY_CONTEXT.xml' path='doc/member[@name="CERT_KEY_CONTEXT.dwKeySpec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCryptProv"]/*'/>
    [UnscopedRef]
    public ref HCRYPTPROV hCryptProv
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hCryptProv;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hNCryptKey"]/*'/>
    [UnscopedRef]
    public ref nuint hNCryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hNCryptKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCryptProv"]/*'/>
        [FieldOffset(0)]
        public HCRYPTPROV hCryptProv;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hNCryptKey"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("NCRYPT_KEY_HANDLE")]
        public nuint hNCryptKey;
    }
}