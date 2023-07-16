// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='KTMOBJECT_CURSOR.xml' path='doc/member[@name="KTMOBJECT_CURSOR"]/*'/>
public partial struct KTMOBJECT_CURSOR
{
    /// <include file='KTMOBJECT_CURSOR.xml' path='doc/member[@name="KTMOBJECT_CURSOR.LastQuery"]/*'/>
    public Guid LastQuery;
    /// <include file='KTMOBJECT_CURSOR.xml' path='doc/member[@name="KTMOBJECT_CURSOR.ObjectIdCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ObjectIdCount;
    /// <include file='KTMOBJECT_CURSOR.xml' path='doc/member[@name="KTMOBJECT_CURSOR.ObjectIds"]/*'/>
    [NativeTypeName("GUID[1]")]
    public _ObjectIds_e__FixedBuffer ObjectIds;
    /// <include file='_ObjectIds_e__FixedBuffer.xml' path='doc/member[@name="_ObjectIds_e__FixedBuffer"]/*'/>
    public partial struct _ObjectIds_e__FixedBuffer
    {
        public Guid e0;
        [UnscopedRef]
        public ref Guid this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}