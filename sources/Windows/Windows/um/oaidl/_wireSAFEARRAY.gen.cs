// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='_wireSAFEARRAY.xml' path='doc/member[@name="_wireSAFEARRAY"]/*'/>
public partial struct _wireSAFEARRAY
{
    /// <include file='_wireSAFEARRAY.xml' path='doc/member[@name="_wireSAFEARRAY.cDims"]/*'/>
    public ushort cDims;
    /// <include file='_wireSAFEARRAY.xml' path='doc/member[@name="_wireSAFEARRAY.fFeatures"]/*'/>
    public ushort fFeatures;
    /// <include file='_wireSAFEARRAY.xml' path='doc/member[@name="_wireSAFEARRAY.cbElements"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbElements;
    /// <include file='_wireSAFEARRAY.xml' path='doc/member[@name="_wireSAFEARRAY.cLocks"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cLocks;
    /// <include file='_wireSAFEARRAY.xml' path='doc/member[@name="_wireSAFEARRAY.uArrayStructs"]/*'/>
    public SAFEARRAYUNION uArrayStructs;
    /// <include file='_wireSAFEARRAY.xml' path='doc/member[@name="_wireSAFEARRAY.rgsabound"]/*'/>
    [NativeTypeName("SAFEARRAYBOUND[1]")]
    public _rgsabound_e__FixedBuffer rgsabound;
    /// <include file='_rgsabound_e__FixedBuffer.xml' path='doc/member[@name="_rgsabound_e__FixedBuffer"]/*'/>
    public partial struct _rgsabound_e__FixedBuffer
    {
        public SAFEARRAYBOUND e0;
        [UnscopedRef]
        public ref SAFEARRAYBOUND this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SAFEARRAYBOUND> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}