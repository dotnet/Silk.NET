// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IOleDocument.xml' path='doc/member[@name="IOleDocument"]/*' />
[Guid("B722BCC5-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IOleDocument : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleDocument : IOleDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleDocument));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleDocument*, Guid*, void**, int>)(lpVtbl[0]))((IOleDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleDocument*, uint>)(lpVtbl[1]))((IOleDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleDocument*, uint>)(lpVtbl[2]))((IOleDocument*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleDocument.xml' path='doc/member[@name="IOleDocument.CreateView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateView(IOleInPlaceSite* pIPSite, IStream* pstm, [NativeTypeName("DWORD")] uint dwReserved, IOleDocumentView** ppView)
    {
        return ((delegate* unmanaged<IOleDocument*, IOleInPlaceSite*, IStream*, uint, IOleDocumentView**, int>)(lpVtbl[3]))((IOleDocument*)Unsafe.AsPointer(ref this), pIPSite, pstm, dwReserved, ppView);
    }

    /// <include file='IOleDocument.xml' path='doc/member[@name="IOleDocument.GetDocMiscStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDocMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<IOleDocument*, uint*, int>)(lpVtbl[4]))((IOleDocument*)Unsafe.AsPointer(ref this), pdwStatus);
    }

    /// <include file='IOleDocument.xml' path='doc/member[@name="IOleDocument.EnumViews"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumViews(IEnumOleDocumentViews** ppEnum, IOleDocumentView** ppView)
    {
        return ((delegate* unmanaged<IOleDocument*, IEnumOleDocumentViews**, IOleDocumentView**, int>)(lpVtbl[5]))((IOleDocument*)Unsafe.AsPointer(ref this), ppEnum, ppView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateView(IOleInPlaceSite* pIPSite, IStream* pstm, [NativeTypeName("DWORD")] uint dwReserved, IOleDocumentView** ppView);

        [VtblIndex(4)]
        HRESULT GetDocMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus);

        [VtblIndex(5)]
        HRESULT EnumViews(IEnumOleDocumentViews** ppEnum, IOleDocumentView** ppView);
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

        [NativeTypeName("HRESULT (IOleInPlaceSite *, IStream *, DWORD, IOleDocumentView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleInPlaceSite*, IStream*, uint, IOleDocumentView**, int> CreateView;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDocMiscStatus;

        [NativeTypeName("HRESULT (IEnumOleDocumentViews **, IOleDocumentView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumOleDocumentViews**, IOleDocumentView**, int> EnumViews;
    }
}
