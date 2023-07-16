// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CMC_TAGGED_REQUEST.xml' path='doc/member[@name="CMC_TAGGED_REQUEST"]/*'/>
public unsafe partial struct CMC_TAGGED_REQUEST
{
    /// <include file='CMC_TAGGED_REQUEST.xml' path='doc/member[@name="CMC_TAGGED_REQUEST.dwTaggedRequestChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTaggedRequestChoice;
    /// <include file='CMC_TAGGED_REQUEST.xml' path='doc/member[@name="CMC_TAGGED_REQUEST.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L5242_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pTaggedCertRequest"]/*'/>
    [UnscopedRef]
    public ref CMC_TAGGED_CERT_REQUEST* pTaggedCertRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pTaggedCertRequest;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pTaggedCertRequest"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCMC_TAGGED_CERT_REQUEST")]
        public CMC_TAGGED_CERT_REQUEST* pTaggedCertRequest;
    }
}