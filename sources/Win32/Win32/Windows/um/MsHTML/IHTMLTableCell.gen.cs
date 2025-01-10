// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F23D-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTableCell : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTableCell : IHTMLTableCell.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTableCell));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTableCell, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLTableCell, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTableCell, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTableCell, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTableCell, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLTableCell, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLTableCell,
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
    public HRESULT put_rowSpan([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, int, int>)((*lpVtbl)[7]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_rowSpan([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, int*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_colSpan([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, int, int>)((*lpVtbl)[9]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_colSpan([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, int*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, ushort*, int>)((*lpVtbl)[11]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, ushort**, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_vAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, ushort*, int>)((*lpVtbl)[13]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_vAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, ushort**, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT, int>)((*lpVtbl)[15]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT*, int>)((*lpVtbl)[16]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_noWrap([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, short, int>)((*lpVtbl)[17]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_noWrap([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, short*, int>)((*lpVtbl)[18]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, ushort*, int>)((*lpVtbl)[19]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, ushort**, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_borderColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT, int>)((*lpVtbl)[21]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_borderColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT*, int>)((*lpVtbl)[22]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_borderColorLight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT, int>)((*lpVtbl)[23]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_borderColorLight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT*, int>)((*lpVtbl)[24]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_borderColorDark(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT, int>)((*lpVtbl)[25]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_borderColorDark(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT*, int>)((*lpVtbl)[26]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT, int>)((*lpVtbl)[27]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT*, int>)((*lpVtbl)[28]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT, int>)((*lpVtbl)[29]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, VARIANT*, int>)((*lpVtbl)[30]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_cellIndex([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTableCell, int*, int>)((*lpVtbl)[31]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_rowSpan([NativeTypeName("long")] int v);

        [VtblIndex(8)]
        HRESULT get_rowSpan([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT put_colSpan([NativeTypeName("long")] int v);

        [VtblIndex(10)]
        HRESULT get_colSpan([NativeTypeName("long *")] int* p);

        [VtblIndex(11)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_vAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_vAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT put_bgColor(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_bgColor(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_noWrap([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(18)]
        HRESULT get_noWrap([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(19)]
        HRESULT put_background([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_background([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_borderColor(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_borderColor(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_borderColorLight(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_borderColorLight(VARIANT* p);

        [VtblIndex(25)]
        HRESULT put_borderColorDark(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_borderColorDark(VARIANT* p);

        [VtblIndex(27)]
        HRESULT put_width(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_width(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_height(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_height(VARIANT* p);

        [VtblIndex(31)]
        HRESULT get_cellIndex([NativeTypeName("long *")] int* p);
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

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_rowSpan;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_rowSpan;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_colSpan;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_colSpan;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_vAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_vAlign;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_noWrap;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_noWrap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_background;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_background;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorLight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorLight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorDark;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorDark;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_cellIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLTableCell"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLTableCell(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLTableCell"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLTableCell(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLTableCell(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLTableCell"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLTableCell"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLTableCell value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLTableCell"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLTableCell(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLTableCell(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLTableCell"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLTableCell"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLTableCell value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
