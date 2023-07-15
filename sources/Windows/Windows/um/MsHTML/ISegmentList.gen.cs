// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISegmentList.xml' path='doc/member[@name="ISegmentList"]/*'/>
[Guid("3050F605-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISegmentList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISegmentList : ISegmentList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISegmentList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISegmentList*, Guid*, void**, int> )(lpVtbl[0]))((ISegmentList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISegmentList*, uint> )(lpVtbl[1]))((ISegmentList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISegmentList*, uint> )(lpVtbl[2]))((ISegmentList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISegmentList.xml' path='doc/member[@name="ISegmentList.CreateIterator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateIterator(ISegmentListIterator** ppIIter)
    {
        return ((delegate* unmanaged<ISegmentList*, ISegmentListIterator**, int> )(lpVtbl[3]))((ISegmentList*)Unsafe.AsPointer(ref this), ppIIter);
    }

    /// <include file='ISegmentList.xml' path='doc/member[@name="ISegmentList.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetType(SELECTION_TYPE* peType)
    {
        return ((delegate* unmanaged<ISegmentList*, SELECTION_TYPE*, int> )(lpVtbl[4]))((ISegmentList*)Unsafe.AsPointer(ref this), peType);
    }

    /// <include file='ISegmentList.xml' path='doc/member[@name="ISegmentList.IsEmpty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsEmpty(BOOL* pfEmpty)
    {
        return ((delegate* unmanaged<ISegmentList*, BOOL*, int> )(lpVtbl[5]))((ISegmentList*)Unsafe.AsPointer(ref this), pfEmpty);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateIterator(ISegmentListIterator** ppIIter);
        [VtblIndex(4)]
        HRESULT GetType(SELECTION_TYPE* peType);
        [VtblIndex(5)]
        HRESULT IsEmpty(BOOL* pfEmpty);
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
        [NativeTypeName("HRESULT (ISegmentListIterator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISegmentListIterator**, int> CreateIterator;
        [NativeTypeName("HRESULT (SELECTION_TYPE *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, SELECTION_TYPE*, int> GetType;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsEmpty;
    }
}