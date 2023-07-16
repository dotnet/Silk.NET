// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISegmentListIterator.xml' path='doc/member[@name="ISegmentListIterator"]/*'/>
[Guid("3050F692-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISegmentListIterator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISegmentListIterator : ISegmentListIterator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISegmentListIterator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISegmentListIterator*, Guid*, void**, int> )(lpVtbl[0]))((ISegmentListIterator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISegmentListIterator*, uint> )(lpVtbl[1]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISegmentListIterator*, uint> )(lpVtbl[2]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISegmentListIterator.xml' path='doc/member[@name="ISegmentListIterator.Current"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Current(ISegment** ppISegment)
    {
        return ((delegate* unmanaged<ISegmentListIterator*, ISegment**, int> )(lpVtbl[3]))((ISegmentListIterator*)Unsafe.AsPointer(ref this), ppISegment);
    }

    /// <include file='ISegmentListIterator.xml' path='doc/member[@name="ISegmentListIterator.First"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT First()
    {
        return ((delegate* unmanaged<ISegmentListIterator*, int> )(lpVtbl[4]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISegmentListIterator.xml' path='doc/member[@name="ISegmentListIterator.IsDone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsDone()
    {
        return ((delegate* unmanaged<ISegmentListIterator*, int> )(lpVtbl[5]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISegmentListIterator.xml' path='doc/member[@name="ISegmentListIterator.Advance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Advance()
    {
        return ((delegate* unmanaged<ISegmentListIterator*, int> )(lpVtbl[6]))((ISegmentListIterator*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Current(ISegment** ppISegment);
        [VtblIndex(4)]
        HRESULT First();
        [VtblIndex(5)]
        HRESULT IsDone();
        [VtblIndex(6)]
        HRESULT Advance();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (ISegment **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISegment**, int> Current;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> First;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDone;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Advance;
    }
}