// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO"]/*'/>
public unsafe partial struct CERT_LOGOTYPE_IMAGE_INFO
{
    /// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO.dwLogotypeImageInfoChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLogotypeImageInfoChoice;
    /// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO.dwFileSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileSize;
    /// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO.dwXSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwXSize;
    /// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO.dwYSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwYSize;
    /// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO.dwLogotypeImageResolutionChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLogotypeImageResolutionChoice;
    /// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L5467_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='CERT_LOGOTYPE_IMAGE_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_IMAGE_INFO.pwszLanguage"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszLanguage;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwNumBits"]/*'/>
    [UnscopedRef]
    public ref uint dwNumBits
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwNumBits;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwTableSize"]/*'/>
    [UnscopedRef]
    public ref uint dwTableSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwTableSize;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwNumBits"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwNumBits;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwTableSize"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwTableSize;
    }
}