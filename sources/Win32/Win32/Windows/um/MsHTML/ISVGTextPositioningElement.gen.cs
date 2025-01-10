// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3051051B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGTextPositioningElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGTextPositioningElement
    : ISVGTextPositioningElement.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGTextPositioningElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGTextPositioningElement, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, uint, uint, ITypeInfo*, int>)(
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
                ISVGTextPositioningElement,
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
                ISVGTextPositioningElement,
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
    public HRESULT putref_x(ISVGAnimatedLengthList v)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList, int>)(
                (*lpVtbl)[7]
            )
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_x(ISVGAnimatedLengthList* p)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList*, int>)(
                (*lpVtbl)[8]
            )
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_y(ISVGAnimatedLengthList v)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList, int>)(
                (*lpVtbl)[9]
            )
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_y(ISVGAnimatedLengthList* p)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList*, int>)(
                (*lpVtbl)[10]
            )
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_dx(ISVGAnimatedLengthList v)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList, int>)(
                (*lpVtbl)[11]
            )
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_dx(ISVGAnimatedLengthList* p)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList*, int>)(
                (*lpVtbl)[12]
            )
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_dy(ISVGAnimatedLengthList v)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList, int>)(
                (*lpVtbl)[13]
            )
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_dy(ISVGAnimatedLengthList* p)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedLengthList*, int>)(
                (*lpVtbl)[14]
            )
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT putref_rotate(ISVGAnimatedNumberList v)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedNumberList, int>)(
                (*lpVtbl)[15]
            )
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_rotate(ISVGAnimatedNumberList* p)
    {
        return (
            (delegate* unmanaged<ISVGTextPositioningElement, ISVGAnimatedNumberList*, int>)(
                (*lpVtbl)[16]
            )
        )(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_x(ISVGAnimatedLengthList v);

        [VtblIndex(8)]
        HRESULT get_x(ISVGAnimatedLengthList* p);

        [VtblIndex(9)]
        HRESULT putref_y(ISVGAnimatedLengthList v);

        [VtblIndex(10)]
        HRESULT get_y(ISVGAnimatedLengthList* p);

        [VtblIndex(11)]
        HRESULT putref_dx(ISVGAnimatedLengthList v);

        [VtblIndex(12)]
        HRESULT get_dx(ISVGAnimatedLengthList* p);

        [VtblIndex(13)]
        HRESULT putref_dy(ISVGAnimatedLengthList v);

        [VtblIndex(14)]
        HRESULT get_dy(ISVGAnimatedLengthList* p);

        [VtblIndex(15)]
        HRESULT putref_rotate(ISVGAnimatedNumberList v);

        [VtblIndex(16)]
        HRESULT get_rotate(ISVGAnimatedNumberList* p);
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

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList, int> putref_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> get_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList, int> putref_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> get_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList, int> putref_dx;

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> get_dx;

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList, int> putref_dy;

        [NativeTypeName("HRESULT (ISVGAnimatedLengthList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLengthList*, int> get_dy;

        [NativeTypeName("HRESULT (ISVGAnimatedNumberList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedNumberList, int> putref_rotate;

        [NativeTypeName("HRESULT (ISVGAnimatedNumberList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedNumberList*, int> get_rotate;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISVGTextPositioningElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISVGTextPositioningElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISVGTextPositioningElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISVGTextPositioningElement(Silk.NET.Windows.IDispatch value)
    {
        return new ISVGTextPositioningElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTextPositioningElement"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTextPositioningElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISVGTextPositioningElement value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISVGTextPositioningElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISVGTextPositioningElement(Silk.NET.Windows.IUnknown value)
    {
        return new ISVGTextPositioningElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTextPositioningElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTextPositioningElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISVGTextPositioningElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
