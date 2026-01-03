// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO"]/*'/>
public unsafe partial struct SignerSubjectInfo
{
    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint CbSize;

    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.pdwIndex"]/*'/>

    [NativeTypeName("DWORD *")]
    public uint* PdwIndex;

    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.dwSubjectChoice"]/*'/>

    [NativeTypeName("DWORD")]
    public uint DwSubjectChoice;

    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_mssign32_L30_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerFileInfo"]/*'/>

    [UnscopedRef]
    public ref SignerFileInfo* pSignerFileInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSignerFileInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerBlobInfo"]/*'/>

    [UnscopedRef]
    public ref SignerBlobInfo* pSignerBlobInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSignerBlobInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerFileInfo"]/*'/>

        [FieldOffset(0)]
        public SignerFileInfo* pSignerFileInfo;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerBlobInfo"]/*'/>

        [FieldOffset(0)]
        public SignerBlobInfo* pSignerBlobInfo;
    }
}
