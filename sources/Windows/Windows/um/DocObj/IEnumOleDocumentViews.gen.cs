// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumOleDocumentViews.xml' path='doc/member[@name="IEnumOleDocumentViews"]/*'/>
[Guid("B722BCC8-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IEnumOleDocumentViews : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumOleDocumentViews : IEnumOleDocumentViews.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumOleDocumentViews));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumOleDocumentViews*, Guid*, void**, int> )(lpVtbl[0]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumOleDocumentViews*, uint> )(lpVtbl[1]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumOleDocumentViews*, uint> )(lpVtbl[2]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumOleDocumentViews.xml' path='doc/member[@name="IEnumOleDocumentViews.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cViews, IOleDocumentView** rgpView, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumOleDocumentViews*, uint, IOleDocumentView**, uint*, int> )(lpVtbl[3]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), cViews, rgpView, pcFetched);
    }

    /// <include file='IEnumOleDocumentViews.xml' path='doc/member[@name="IEnumOleDocumentViews.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cViews)
    {
        return ((delegate* unmanaged<IEnumOleDocumentViews*, uint, int> )(lpVtbl[4]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), cViews);
    }

    /// <include file='IEnumOleDocumentViews.xml' path='doc/member[@name="IEnumOleDocumentViews.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumOleDocumentViews*, int> )(lpVtbl[5]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumOleDocumentViews.xml' path='doc/member[@name="IEnumOleDocumentViews.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumOleDocumentViews** ppEnum)
    {
        return ((delegate* unmanaged<IEnumOleDocumentViews*, IEnumOleDocumentViews**, int> )(lpVtbl[6]))((IEnumOleDocumentViews*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cViews, IOleDocumentView** rgpView, [NativeTypeName("ULONG *")] uint* pcFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cViews);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumOleDocumentViews** ppEnum);
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
        [NativeTypeName("HRESULT (ULONG, IOleDocumentView **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IOleDocumentView**, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumOleDocumentViews **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumOleDocumentViews**, int> Clone;
    }
}