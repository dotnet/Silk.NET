// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS"]/*' />
public partial struct MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS
{
    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.dwVer"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVer;

    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.cbSignatureOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSignatureOffset;

    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.cbSignatureSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSignatureSize;

    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.cbExtensionOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbExtensionOffset;

    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.cbExtensionSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbExtensionSize;

    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.cActions"]/*' />
    [NativeTypeName("DWORD")]
    public uint cActions;

    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS.rgOutputActions"]/*' />
    [NativeTypeName("MFINPUTTRUSTAUTHORITY_ACCESS_ACTION[1]")]
    public _rgOutputActions_e__FixedBuffer rgOutputActions;

    /// <include file='_rgOutputActions_e__FixedBuffer.xml' path='doc/member[@name="_rgOutputActions_e__FixedBuffer"]/*' />
    public partial struct _rgOutputActions_e__FixedBuffer
    {
        public MFINPUTTRUSTAUTHORITY_ACCESS_ACTION e0;

        [UnscopedRef]
        public ref MFINPUTTRUSTAUTHORITY_ACCESS_ACTION this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MFINPUTTRUSTAUTHORITY_ACCESS_ACTION> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
