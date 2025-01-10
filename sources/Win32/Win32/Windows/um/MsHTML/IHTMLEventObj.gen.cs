// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F32D-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLEventObj : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLEventObj : IHTMLEventObj.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEventObj));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEventObj, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLEventObj, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEventObj, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLEventObj, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLEventObj, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLEventObj,
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
    public HRESULT get_srcElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, IHTMLElement*, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, short*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, short*, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, short*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_returnValue(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLEventObj, VARIANT, int>)((*lpVtbl)[11]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_returnValue(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, VARIANT*, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_cancelBubble([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLEventObj, short, int>)((*lpVtbl)[13]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_cancelBubble([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, short*, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_fromElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, IHTMLElement*, int>)((*lpVtbl)[15]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_toElement(IHTMLElement* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, IHTMLElement*, int>)((*lpVtbl)[16]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_keyCode([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int, int>)((*lpVtbl)[17]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_keyCode([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[18]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_button([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[19]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, ushort**, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_qualifier([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, ushort**, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_reason([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[22]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_x([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[23]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_y([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[24]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_clientX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_clientY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[26]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_offsetX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[27]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_offsetY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[28]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_screenX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[29]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_screenY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, int*, int>)((*lpVtbl)[30]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_srcFilter(IDispatch* p)
    {
        return ((delegate* unmanaged<IHTMLEventObj, IDispatch*, int>)((*lpVtbl)[31]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_srcElement(IHTMLElement* p);

        [VtblIndex(8)]
        HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(9)]
        HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(10)]
        HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(11)]
        HRESULT put_returnValue(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_returnValue(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_cancelBubble([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(14)]
        HRESULT get_cancelBubble([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(15)]
        HRESULT get_fromElement(IHTMLElement* p);

        [VtblIndex(16)]
        HRESULT get_toElement(IHTMLElement* p);

        [VtblIndex(17)]
        HRESULT put_keyCode([NativeTypeName("long")] int v);

        [VtblIndex(18)]
        HRESULT get_keyCode([NativeTypeName("long *")] int* p);

        [VtblIndex(19)]
        HRESULT get_button([NativeTypeName("long *")] int* p);

        [VtblIndex(20)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT get_qualifier([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(22)]
        HRESULT get_reason([NativeTypeName("long *")] int* p);

        [VtblIndex(23)]
        HRESULT get_x([NativeTypeName("long *")] int* p);

        [VtblIndex(24)]
        HRESULT get_y([NativeTypeName("long *")] int* p);

        [VtblIndex(25)]
        HRESULT get_clientX([NativeTypeName("long *")] int* p);

        [VtblIndex(26)]
        HRESULT get_clientY([NativeTypeName("long *")] int* p);

        [VtblIndex(27)]
        HRESULT get_offsetX([NativeTypeName("long *")] int* p);

        [VtblIndex(28)]
        HRESULT get_offsetY([NativeTypeName("long *")] int* p);

        [VtblIndex(29)]
        HRESULT get_screenX([NativeTypeName("long *")] int* p);

        [VtblIndex(30)]
        HRESULT get_screenY([NativeTypeName("long *")] int* p);

        [VtblIndex(31)]
        HRESULT get_srcFilter(IDispatch* p);
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

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_srcElement;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_altKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ctrlKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_shiftKey;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_returnValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_returnValue;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_cancelBubble;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_cancelBubble;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_fromElement;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> get_toElement;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_keyCode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_keyCode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_button;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_qualifier;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_reason;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_x;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_y;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_clientY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_screenY;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_srcFilter;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLEventObj"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLEventObj(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLEventObj"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLEventObj(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLEventObj(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEventObj"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEventObj"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLEventObj value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLEventObj"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLEventObj(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLEventObj(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEventObj"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEventObj"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLEventObj value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
