// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C6403497-7493-4F09-8016-54B03E9BDA69")]
[NativeTypeName("struct IPrintManagerTemplatePrinter2 : IPrintManagerTemplatePrinter")]
[NativeInheritance("IPrintManagerTemplatePrinter")]
public unsafe partial struct IPrintManagerTemplatePrinter2
    : IPrintManagerTemplatePrinter2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintManagerTemplatePrinter2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintManagerTemplatePrinter2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IPrintManagerTemplatePrinter2, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
        )(this, iTInfo, lcid, ppTInfo);
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
            (delegate* unmanaged<
                IPrintManagerTemplatePrinter2,
                Guid*,
                ushort**,
                uint,
                uint,
                int*,
                int>)((*lpVtbl)[5])
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
                IPrintManagerTemplatePrinter2,
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
    public HRESULT startPrint()
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT drawPreviewPage(IDispatch pElemDisp, [NativeTypeName("long")] int nPage)
    {
        return (
            (delegate* unmanaged<IPrintManagerTemplatePrinter2, IDispatch, int, int>)((*lpVtbl)[8])
        )(this, pElemDisp, nPage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT setPageCount([NativeTypeName("long")] int nPage)
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, int, int>)((*lpVtbl)[9]))(
            this,
            nPage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT invalidatePreview()
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getPrintTaskOptionValue(
        [NativeTypeName("BSTR")] ushort* bstrKey,
        VARIANT* pvarin
    )
    {
        return (
            (delegate* unmanaged<IPrintManagerTemplatePrinter2, ushort*, VARIANT*, int>)(
                (*lpVtbl)[11]
            )
        )(this, bstrKey, pvarin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT endPrint()
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_showHeaderFooter([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, short*, int>)((*lpVtbl)[13]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_shrinkToFit([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, short*, int>)((*lpVtbl)[14]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_percentScale(float* p)
    {
        return ((delegate* unmanaged<IPrintManagerTemplatePrinter2, float*, int>)((*lpVtbl)[15]))(
            this,
            p
        );
    }

    public interface Interface : IPrintManagerTemplatePrinter.Interface
    {
        [VtblIndex(13)]
        HRESULT get_showHeaderFooter([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(14)]
        HRESULT get_shrinkToFit([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(15)]
        HRESULT get_percentScale(float* p);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> startPrint;

        [NativeTypeName("HRESULT (IDispatch *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch, int, int> drawPreviewPage;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> setPageCount;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> invalidatePreview;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> getPrintTaskOptionValue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> endPrint;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_showHeaderFooter;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_shrinkToFit;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_percentScale;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintManagerTemplatePrinter2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintManagerTemplatePrinter2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPrintManagerTemplatePrinter"/> to <see cref = "IPrintManagerTemplatePrinter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPrintManagerTemplatePrinter"/> instance to be converted </param>
    public static explicit operator IPrintManagerTemplatePrinter2(
        Silk.NET.Windows.IPrintManagerTemplatePrinter value
    )
    {
        return new IPrintManagerTemplatePrinter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintManagerTemplatePrinter2"/> to <see cref = "Silk.NET.Windows.IPrintManagerTemplatePrinter"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintManagerTemplatePrinter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPrintManagerTemplatePrinter(
        IPrintManagerTemplatePrinter2 value
    )
    {
        return new Silk.NET.Windows.IPrintManagerTemplatePrinter(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IPrintManagerTemplatePrinter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IPrintManagerTemplatePrinter2(Silk.NET.Windows.IDispatch value)
    {
        return new IPrintManagerTemplatePrinter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintManagerTemplatePrinter2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintManagerTemplatePrinter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IPrintManagerTemplatePrinter2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintManagerTemplatePrinter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintManagerTemplatePrinter2(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintManagerTemplatePrinter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintManagerTemplatePrinter2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintManagerTemplatePrinter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintManagerTemplatePrinter2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
