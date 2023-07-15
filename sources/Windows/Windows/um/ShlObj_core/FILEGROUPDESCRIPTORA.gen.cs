// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='FILEGROUPDESCRIPTORA.xml' path='doc/member[@name="FILEGROUPDESCRIPTORA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEGROUPDESCRIPTORA
{
    /// <include file='FILEGROUPDESCRIPTORA.xml' path='doc/member[@name="FILEGROUPDESCRIPTORA.cItems"]/*'/>
    public uint cItems;
    /// <include file='FILEGROUPDESCRIPTORA.xml' path='doc/member[@name="FILEGROUPDESCRIPTORA.fgd"]/*'/>
    [NativeTypeName("FILEDESCRIPTORA[1]")]
    public _fgd_e__FixedBuffer fgd;
    /// <include file='_fgd_e__FixedBuffer.xml' path='doc/member[@name="_fgd_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _fgd_e__FixedBuffer
    {
        public FILEDESCRIPTORA e0;
        [UnscopedRef]
        public ref FILEDESCRIPTORA this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<FILEDESCRIPTORA> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}