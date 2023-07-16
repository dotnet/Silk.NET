// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='FILEGROUPDESCRIPTORW.xml' path='doc/member[@name="FILEGROUPDESCRIPTORW"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEGROUPDESCRIPTORW
{
    /// <include file='FILEGROUPDESCRIPTORW.xml' path='doc/member[@name="FILEGROUPDESCRIPTORW.cItems"]/*'/>
    public uint cItems;
    /// <include file='FILEGROUPDESCRIPTORW.xml' path='doc/member[@name="FILEGROUPDESCRIPTORW.fgd"]/*'/>
    [NativeTypeName("FILEDESCRIPTORW[1]")]
    public _fgd_e__FixedBuffer fgd;
    /// <include file='_fgd_e__FixedBuffer.xml' path='doc/member[@name="_fgd_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _fgd_e__FixedBuffer
    {
        public FILEDESCRIPTORW e0;
        [UnscopedRef]
        public ref FILEDESCRIPTORW this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<FILEDESCRIPTORW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}