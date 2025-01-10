// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F680-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEventObj3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLEventObj3 : IHTMLEventObj3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEventObj3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLEventObj3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEventObj3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IHTMLEventObj3, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLEventObj3,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_contentOverflow([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, short*, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_shiftLeft([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, short, int>)((*lpVtbl)[8]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_shiftLeft([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, short*, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_altLeft([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, short, int>)((*lpVtbl)[10]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_altLeft([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, short*, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ctrlLeft([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, short, int>)((*lpVtbl)[12]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ctrlLeft([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, short*, int>)((*lpVtbl)[13]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_imeCompositionChange([NativeTypeName("LONG_PTR *")] nint* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, nint*, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_imeNotifyCommand([NativeTypeName("LONG_PTR *")] nint* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, nint*, int>)((*lpVtbl)[15]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_imeNotifyData([NativeTypeName("LONG_PTR *")] nint* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, nint*, int>)((*lpVtbl)[16]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_imeRequest([NativeTypeName("LONG_PTR *")] nint* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, nint*, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_imeRequestData([NativeTypeName("LONG_PTR *")] nint* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, nint*, int>)((*lpVtbl)[18]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_keyboardLayout([NativeTypeName("LONG_PTR *")] nint* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, nint*, int>)((*lpVtbl)[19]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_behaviorCookie([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, int*, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_behaviorPart([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, int*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_nextPage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj3, ushort**, int>)((*lpVtbl)[22]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_contentOverflow([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(8)]
        HRESULT put_shiftLeft([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(9)]
        HRESULT get_shiftLeft([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(10)]
        HRESULT put_altLeft([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(11)]
        HRESULT get_altLeft([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(12)]
        HRESULT put_ctrlLeft([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(13)]
        HRESULT get_ctrlLeft([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(14)]
        HRESULT get_imeCompositionChange([NativeTypeName("LONG_PTR *")] nint* p);

        [VtblIndex(15)]
        HRESULT get_imeNotifyCommand([NativeTypeName("LONG_PTR *")] nint* p);

        [VtblIndex(16)]
        HRESULT get_imeNotifyData([NativeTypeName("LONG_PTR *")] nint* p);

        [VtblIndex(17)]
        HRESULT get_imeRequest([NativeTypeName("LONG_PTR *")] nint* p);

        [VtblIndex(18)]
        HRESULT get_imeRequestData([NativeTypeName("LONG_PTR *")] nint* p);

        [VtblIndex(19)]
        HRESULT get_keyboardLayout([NativeTypeName("LONG_PTR *")] nint* p);

        [VtblIndex(20)]
        HRESULT get_behaviorCookie([NativeTypeName("long *")] int* p);

        [VtblIndex(21)]
        HRESULT get_behaviorPart([NativeTypeName("long *")] int* p);

        [VtblIndex(22)]
        HRESULT get_nextPage([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_contentOverflow;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_shiftLeft;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_shiftLeft;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_altLeft;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_altLeft;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_ctrlLeft;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ctrlLeft;

        [NativeTypeName("HRESULT (LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> get_imeCompositionChange;

        [NativeTypeName("HRESULT (LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> get_imeNotifyCommand;

        [NativeTypeName("HRESULT (LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> get_imeNotifyData;

        [NativeTypeName("HRESULT (LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> get_imeRequest;

        [NativeTypeName("HRESULT (LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> get_imeRequestData;

        [NativeTypeName("HRESULT (LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> get_keyboardLayout;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_behaviorCookie;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_behaviorPart;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nextPage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLEventObj3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLEventObj3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLEventObj3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLEventObj3(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLEventObj3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEventObj3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEventObj3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLEventObj3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLEventObj3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLEventObj3(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLEventObj3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEventObj3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEventObj3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLEventObj3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
