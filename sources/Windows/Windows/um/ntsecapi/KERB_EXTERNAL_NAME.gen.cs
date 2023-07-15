// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='KERB_EXTERNAL_NAME.xml' path='doc/member[@name="KERB_EXTERNAL_NAME"]/*'/>
public partial struct KERB_EXTERNAL_NAME
{
    /// <include file='KERB_EXTERNAL_NAME.xml' path='doc/member[@name="KERB_EXTERNAL_NAME.NameType"]/*'/>
    public short NameType;
    /// <include file='KERB_EXTERNAL_NAME.xml' path='doc/member[@name="KERB_EXTERNAL_NAME.NameCount"]/*'/>
    public ushort NameCount;
    /// <include file='KERB_EXTERNAL_NAME.xml' path='doc/member[@name="KERB_EXTERNAL_NAME.Names"]/*'/>
    [NativeTypeName("UNICODE_STRING[1]")]
    public _Names_e__FixedBuffer Names;
    /// <include file='_Names_e__FixedBuffer.xml' path='doc/member[@name="_Names_e__FixedBuffer"]/*'/>
    public partial struct _Names_e__FixedBuffer
    {
        public LSA_UNICODE_STRING e0;
        [UnscopedRef]
        public ref LSA_UNICODE_STRING this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LSA_UNICODE_STRING> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}