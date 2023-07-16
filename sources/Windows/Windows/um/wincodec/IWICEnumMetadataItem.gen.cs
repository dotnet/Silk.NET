// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICEnumMetadataItem.xml' path='doc/member[@name="IWICEnumMetadataItem"]/*'/>
[Guid("DC2BB46D-3F07-481E-8625-220C4AEDBB33")]
[NativeTypeName("struct IWICEnumMetadataItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICEnumMetadataItem : IWICEnumMetadataItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICEnumMetadataItem));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICEnumMetadataItem*, Guid*, void**, int> )(lpVtbl[0]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICEnumMetadataItem*, uint> )(lpVtbl[1]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICEnumMetadataItem*, uint> )(lpVtbl[2]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICEnumMetadataItem.xml' path='doc/member[@name="IWICEnumMetadataItem.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IWICEnumMetadataItem*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, uint*, int> )(lpVtbl[3]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
    }

    /// <include file='IWICEnumMetadataItem.xml' path='doc/member[@name="IWICEnumMetadataItem.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IWICEnumMetadataItem*, uint, int> )(lpVtbl[4]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IWICEnumMetadataItem.xml' path='doc/member[@name="IWICEnumMetadataItem.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IWICEnumMetadataItem*, int> )(lpVtbl[5]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICEnumMetadataItem.xml' path='doc/member[@name="IWICEnumMetadataItem.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IWICEnumMetadataItem** ppIEnumMetadataItem)
    {
        return ((delegate* unmanaged<IWICEnumMetadataItem*, IWICEnumMetadataItem**, int> )(lpVtbl[6]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), ppIEnumMetadataItem);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IWICEnumMetadataItem** ppIEnumMetadataItem);
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
        [NativeTypeName("HRESULT (ULONG, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICEnumMetadataItem**, int> Clone;
    }
}