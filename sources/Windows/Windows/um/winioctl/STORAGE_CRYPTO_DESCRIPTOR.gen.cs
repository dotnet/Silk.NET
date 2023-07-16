// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STORAGE_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR"]/*'/>
public partial struct STORAGE_CRYPTO_DESCRIPTOR
{
    /// <include file='STORAGE_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR.NumKeysSupported"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumKeysSupported;
    /// <include file='STORAGE_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR.NumCryptoCapabilities"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumCryptoCapabilities;
    /// <include file='STORAGE_CRYPTO_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_CRYPTO_DESCRIPTOR.CryptoCapabilities"]/*'/>
    [NativeTypeName("STORAGE_CRYPTO_CAPABILITY[1]")]
    public _CryptoCapabilities_e__FixedBuffer CryptoCapabilities;
    /// <include file='_CryptoCapabilities_e__FixedBuffer.xml' path='doc/member[@name="_CryptoCapabilities_e__FixedBuffer"]/*'/>
    public partial struct _CryptoCapabilities_e__FixedBuffer
    {
        public STORAGE_CRYPTO_CAPABILITY e0;
        [UnscopedRef]
        public ref STORAGE_CRYPTO_CAPABILITY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_CRYPTO_CAPABILITY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}