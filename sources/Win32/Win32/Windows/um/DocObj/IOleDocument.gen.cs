// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B722BCC5-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IOleDocument : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleDocument : IOleDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleDocument));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleDocument, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleDocument, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleDocument, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateView(
        IOleInPlaceSite pIPSite,
        IStream pstm,
        [NativeTypeName("DWORD")] uint dwReserved,
        IOleDocumentView* ppView
    )
    {
        return (
            (delegate* unmanaged<
                IOleDocument,
                IOleInPlaceSite,
                IStream,
                uint,
                IOleDocumentView*,
                int>)((*lpVtbl)[3])
        )(this, pIPSite, pstm, dwReserved, ppView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDocMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<IOleDocument, uint*, int>)((*lpVtbl)[4]))(this, pdwStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumViews(IEnumOleDocumentViews* ppEnum, IOleDocumentView* ppView)
    {
        return (
            (delegate* unmanaged<IOleDocument, IEnumOleDocumentViews*, IOleDocumentView*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ppEnum, ppView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateView(
            IOleInPlaceSite pIPSite,
            IStream pstm,
            [NativeTypeName("DWORD")] uint dwReserved,
            IOleDocumentView* ppView
        );

        [VtblIndex(4)]
        HRESULT GetDocMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus);

        [VtblIndex(5)]
        HRESULT EnumViews(IEnumOleDocumentViews* ppEnum, IOleDocumentView* ppView);
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

        [NativeTypeName(
            "HRESULT (IOleInPlaceSite *, IStream *, DWORD, IOleDocumentView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IOleInPlaceSite,
            IStream,
            uint,
            IOleDocumentView*,
            int> CreateView;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDocMiscStatus;

        [NativeTypeName(
            "HRESULT (IEnumOleDocumentViews **, IOleDocumentView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEnumOleDocumentViews*,
            IOleDocumentView*,
            int> EnumViews;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleDocument"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleDocument(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleDocument"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleDocument(Silk.NET.Windows.IUnknown value)
    {
        return new IOleDocument(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleDocument"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleDocument"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleDocument value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
