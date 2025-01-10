// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4C896039-7B6D-49E6-A8C1-45116A98292B")]
[NativeTypeName("struct IAccClientDocMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccClientDocMgr : IAccClientDocMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccClientDocMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccClientDocMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAccClientDocMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccClientDocMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDocuments(IEnumUnknown* enumUnknown)
    {
        return ((delegate* unmanaged<IAccClientDocMgr, IEnumUnknown*, int>)((*lpVtbl)[3]))(
            this,
            enumUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LookupByHWND(
        HWND hWnd,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown* ppunk
    )
    {
        return ((delegate* unmanaged<IAccClientDocMgr, HWND, Guid*, IUnknown*, int>)((*lpVtbl)[4]))(
            this,
            hWnd,
            riid,
            ppunk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LookupByPoint(
        POINT pt,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown* ppunk
    )
    {
        return (
            (delegate* unmanaged<IAccClientDocMgr, POINT, Guid*, IUnknown*, int>)((*lpVtbl)[5])
        )(this, pt, riid, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown* ppunk)
    {
        return ((delegate* unmanaged<IAccClientDocMgr, Guid*, IUnknown*, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppunk
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDocuments(IEnumUnknown* enumUnknown);

        [VtblIndex(4)]
        HRESULT LookupByHWND(
            HWND hWnd,
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown* ppunk
        );

        [VtblIndex(5)]
        HRESULT LookupByPoint(
            POINT pt,
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown* ppunk
        );

        [VtblIndex(6)]
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

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumUnknown*, int> GetDocuments;

        [NativeTypeName("HRESULT (HWND, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, IUnknown*, int> LookupByHWND;

        [NativeTypeName("HRESULT (POINT, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, Guid*, IUnknown*, int> LookupByPoint;

        [NativeTypeName("HRESULT (const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> GetFocused;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAccClientDocMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAccClientDocMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAccClientDocMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAccClientDocMgr(Silk.NET.Windows.IUnknown value)
    {
        return new IAccClientDocMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccClientDocMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAccClientDocMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAccClientDocMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
