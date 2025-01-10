// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E2CD4A63-2B72-4D48-B739-95E4765195BA")]
[NativeTypeName("struct IAccStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccStore : IAccStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAccStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Register([NativeTypeName("const IID &")] Guid* riid, IUnknown punk)
    {
        return ((delegate* unmanaged<IAccStore, Guid*, IUnknown, int>)((*lpVtbl)[3]))(
            this,
            riid,
            punk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unregister(IUnknown punk)
    {
        return ((delegate* unmanaged<IAccStore, IUnknown, int>)((*lpVtbl)[4]))(this, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDocuments(IEnumUnknown* enumUnknown)
    {
        return ((delegate* unmanaged<IAccStore, IEnumUnknown*, int>)((*lpVtbl)[5]))(
            this,
            enumUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LookupByHWND(
        HWND hWnd,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown* ppunk
    )
    {
        return ((delegate* unmanaged<IAccStore, HWND, Guid*, IUnknown*, int>)((*lpVtbl)[6]))(
            this,
            hWnd,
            riid,
            ppunk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LookupByPoint(
        POINT pt,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown* ppunk
    )
    {
        return ((delegate* unmanaged<IAccStore, POINT, Guid*, IUnknown*, int>)((*lpVtbl)[7]))(
            this,
            pt,
            riid,
            ppunk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnDocumentFocus(IUnknown punk)
    {
        return ((delegate* unmanaged<IAccStore, IUnknown, int>)((*lpVtbl)[8]))(this, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown* ppunk)
    {
        return ((delegate* unmanaged<IAccStore, Guid*, IUnknown*, int>)((*lpVtbl)[9]))(
            this,
            riid,
            ppunk
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Register([NativeTypeName("const IID &")] Guid* riid, IUnknown punk);

        [VtblIndex(4)]
        HRESULT Unregister(IUnknown punk);

        [VtblIndex(5)]
        HRESULT GetDocuments(IEnumUnknown* enumUnknown);

        [VtblIndex(6)]
        HRESULT LookupByHWND(
            HWND hWnd,
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown* ppunk
        );

        [VtblIndex(7)]
        HRESULT LookupByPoint(
            POINT pt,
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown* ppunk
        );

        [VtblIndex(8)]
        HRESULT OnDocumentFocus(IUnknown punk);

        [VtblIndex(9)]
        HRESULT GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown* ppunk);
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

        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> Register;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> Unregister;

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumUnknown*, int> GetDocuments;

        [NativeTypeName("HRESULT (HWND, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, IUnknown*, int> LookupByHWND;

        [NativeTypeName("HRESULT (POINT, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, Guid*, IUnknown*, int> LookupByPoint;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> OnDocumentFocus;

        [NativeTypeName("HRESULT (const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> GetFocused;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAccStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAccStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAccStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAccStore(Silk.NET.Windows.IUnknown value)
    {
        return new IAccStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAccStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAccStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
