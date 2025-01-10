// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305104F8-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGTransformList : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGTransformList : ISVGTransformList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGTransformList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGTransformList, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISVGTransformList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGTransformList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGTransformList, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISVGTransformList, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISVGTransformList, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISVGTransformList,
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
    public HRESULT put_numberOfItems([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ISVGTransformList, int, int>)((*lpVtbl)[7]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_numberOfItems([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ISVGTransformList, int*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT clear()
    {
        return ((delegate* unmanaged<ISVGTransformList, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT initialize(ISVGTransform newItem, ISVGTransform* ppResult)
    {
        return (
            (delegate* unmanaged<ISVGTransformList, ISVGTransform, ISVGTransform*, int>)(
                (*lpVtbl)[10]
            )
        )(this, newItem, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getItem([NativeTypeName("long")] int index, ISVGTransform* ppResult)
    {
        return ((delegate* unmanaged<ISVGTransformList, int, ISVGTransform*, int>)((*lpVtbl)[11]))(
            this,
            index,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT insertItemBefore(
        ISVGTransform newItem,
        [NativeTypeName("long")] int index,
        ISVGTransform* ppResult
    )
    {
        return (
            (delegate* unmanaged<ISVGTransformList, ISVGTransform, int, ISVGTransform*, int>)(
                (*lpVtbl)[12]
            )
        )(this, newItem, index, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT replaceItem(
        ISVGTransform newItem,
        [NativeTypeName("long")] int index,
        ISVGTransform* ppResult
    )
    {
        return (
            (delegate* unmanaged<ISVGTransformList, ISVGTransform, int, ISVGTransform*, int>)(
                (*lpVtbl)[13]
            )
        )(this, newItem, index, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT removeItem([NativeTypeName("long")] int index, ISVGTransform* ppResult)
    {
        return ((delegate* unmanaged<ISVGTransformList, int, ISVGTransform*, int>)((*lpVtbl)[14]))(
            this,
            index,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT appendItem(ISVGTransform newItem, ISVGTransform* ppResult)
    {
        return (
            (delegate* unmanaged<ISVGTransformList, ISVGTransform, ISVGTransform*, int>)(
                (*lpVtbl)[15]
            )
        )(this, newItem, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT createSVGTransformFromMatrix(ISVGMatrix newItem, ISVGTransform* ppResult)
    {
        return (
            (delegate* unmanaged<ISVGTransformList, ISVGMatrix, ISVGTransform*, int>)((*lpVtbl)[16])
        )(this, newItem, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT consolidate(ISVGTransform* ppResult)
    {
        return ((delegate* unmanaged<ISVGTransformList, ISVGTransform*, int>)((*lpVtbl)[17]))(
            this,
            ppResult
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_numberOfItems([NativeTypeName("long")] int v);

        [VtblIndex(8)]
        HRESULT get_numberOfItems([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT clear();

        [VtblIndex(10)]
        HRESULT initialize(ISVGTransform newItem, ISVGTransform* ppResult);

        [VtblIndex(11)]
        HRESULT getItem([NativeTypeName("long")] int index, ISVGTransform* ppResult);

        [VtblIndex(12)]
        HRESULT insertItemBefore(
            ISVGTransform newItem,
            [NativeTypeName("long")] int index,
            ISVGTransform* ppResult
        );

        [VtblIndex(13)]
        HRESULT replaceItem(
            ISVGTransform newItem,
            [NativeTypeName("long")] int index,
            ISVGTransform* ppResult
        );

        [VtblIndex(14)]
        HRESULT removeItem([NativeTypeName("long")] int index, ISVGTransform* ppResult);

        [VtblIndex(15)]
        HRESULT appendItem(ISVGTransform newItem, ISVGTransform* ppResult);

        [VtblIndex(16)]
        HRESULT createSVGTransformFromMatrix(ISVGMatrix newItem, ISVGTransform* ppResult);

        [VtblIndex(17)]
        HRESULT consolidate(ISVGTransform* ppResult);
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
        public delegate* unmanaged<TSelf*, int, int> put_numberOfItems;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_numberOfItems;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> clear;

        [NativeTypeName("HRESULT (ISVGTransform *, ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransform, ISVGTransform*, int> initialize;

        [NativeTypeName("HRESULT (long, ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISVGTransform*, int> getItem;

        [NativeTypeName(
            "HRESULT (ISVGTransform *, long, ISVGTransform **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISVGTransform,
            int,
            ISVGTransform*,
            int> insertItemBefore;

        [NativeTypeName(
            "HRESULT (ISVGTransform *, long, ISVGTransform **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISVGTransform, int, ISVGTransform*, int> replaceItem;

        [NativeTypeName("HRESULT (long, ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISVGTransform*, int> removeItem;

        [NativeTypeName("HRESULT (ISVGTransform *, ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransform, ISVGTransform*, int> appendItem;

        [NativeTypeName("HRESULT (ISVGMatrix *, ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ISVGMatrix,
            ISVGTransform*,
            int> createSVGTransformFromMatrix;

        [NativeTypeName("HRESULT (ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransform*, int> consolidate;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISVGTransformList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISVGTransformList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISVGTransformList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISVGTransformList(Silk.NET.Windows.IDispatch value)
    {
        return new ISVGTransformList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTransformList"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTransformList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISVGTransformList value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISVGTransformList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISVGTransformList(Silk.NET.Windows.IUnknown value)
    {
        return new ISVGTransformList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTransformList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTransformList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISVGTransformList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
