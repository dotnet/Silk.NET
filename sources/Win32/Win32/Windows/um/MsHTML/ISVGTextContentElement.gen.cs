// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3051051A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGTextContentElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGTextContentElement : ISVGTextContentElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGTextContentElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISVGTextContentElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGTextContentElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISVGTextContentElement, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISVGTextContentElement, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISVGTextContentElement,
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
    public HRESULT putref_textLength(ISVGAnimatedLength v)
    {
        return (
            (delegate* unmanaged<ISVGTextContentElement, ISVGAnimatedLength, int>)((*lpVtbl)[7])
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_textLength(ISVGAnimatedLength* p)
    {
        return (
            (delegate* unmanaged<ISVGTextContentElement, ISVGAnimatedLength*, int>)((*lpVtbl)[8])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_lengthAdjust(ISVGAnimatedEnumeration v)
    {
        return (
            (delegate* unmanaged<ISVGTextContentElement, ISVGAnimatedEnumeration, int>)(
                (*lpVtbl)[9]
            )
        )(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_lengthAdjust(ISVGAnimatedEnumeration* p)
    {
        return (
            (delegate* unmanaged<ISVGTextContentElement, ISVGAnimatedEnumeration*, int>)(
                (*lpVtbl)[10]
            )
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getNumberOfChars([NativeTypeName("long *")] int* pResult)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, int*, int>)((*lpVtbl)[11]))(
            this,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT getComputedTextLength(float* pResult)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, float*, int>)((*lpVtbl)[12]))(
            this,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT getSubStringLength(
        [NativeTypeName("long")] int charnum,
        [NativeTypeName("long")] int nchars,
        float* pResult
    )
    {
        return (
            (delegate* unmanaged<ISVGTextContentElement, int, int, float*, int>)((*lpVtbl)[13])
        )(this, charnum, nchars, pResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT getStartPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint* ppResult)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, int, ISVGPoint*, int>)((*lpVtbl)[14]))(
            this,
            charnum,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT getEndPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint* ppResult)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, int, ISVGPoint*, int>)((*lpVtbl)[15]))(
            this,
            charnum,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT getExtentOfChar([NativeTypeName("long")] int charnum, ISVGRect* ppResult)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, int, ISVGRect*, int>)((*lpVtbl)[16]))(
            this,
            charnum,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT getRotationOfChar([NativeTypeName("long")] int charnum, float* pResult)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, int, float*, int>)((*lpVtbl)[17]))(
            this,
            charnum,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT getCharNumAtPosition(ISVGPoint point, [NativeTypeName("long *")] int* pResult)
    {
        return ((delegate* unmanaged<ISVGTextContentElement, ISVGPoint, int*, int>)((*lpVtbl)[18]))(
            this,
            point,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT selectSubString(
        [NativeTypeName("long")] int charnum,
        [NativeTypeName("long")] int nchars
    )
    {
        return ((delegate* unmanaged<ISVGTextContentElement, int, int, int>)((*lpVtbl)[19]))(
            this,
            charnum,
            nchars
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_textLength(ISVGAnimatedLength v);

        [VtblIndex(8)]
        HRESULT get_textLength(ISVGAnimatedLength* p);

        [VtblIndex(9)]
        HRESULT putref_lengthAdjust(ISVGAnimatedEnumeration v);

        [VtblIndex(10)]
        HRESULT get_lengthAdjust(ISVGAnimatedEnumeration* p);

        [VtblIndex(11)]
        HRESULT getNumberOfChars([NativeTypeName("long *")] int* pResult);

        [VtblIndex(12)]
        HRESULT getComputedTextLength(float* pResult);

        [VtblIndex(13)]
        HRESULT getSubStringLength(
            [NativeTypeName("long")] int charnum,
            [NativeTypeName("long")] int nchars,
            float* pResult
        );

        [VtblIndex(14)]
        HRESULT getStartPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint* ppResult);

        [VtblIndex(15)]
        HRESULT getEndPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint* ppResult);

        [VtblIndex(16)]
        HRESULT getExtentOfChar([NativeTypeName("long")] int charnum, ISVGRect* ppResult);

        [VtblIndex(17)]
        HRESULT getRotationOfChar([NativeTypeName("long")] int charnum, float* pResult);

        [VtblIndex(18)]
        HRESULT getCharNumAtPosition(ISVGPoint point, [NativeTypeName("long *")] int* pResult);

        [VtblIndex(19)]
        HRESULT selectSubString(
            [NativeTypeName("long")] int charnum,
            [NativeTypeName("long")] int nchars
        );
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

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength, int> putref_textLength;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> get_textLength;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration, int> putref_lengthAdjust;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedEnumeration*, int> get_lengthAdjust;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> getNumberOfChars;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> getComputedTextLength;

        [NativeTypeName("HRESULT (long, long, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, float*, int> getSubStringLength;

        [NativeTypeName("HRESULT (long, ISVGPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISVGPoint*, int> getStartPositionOfChar;

        [NativeTypeName("HRESULT (long, ISVGPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISVGPoint*, int> getEndPositionOfChar;

        [NativeTypeName("HRESULT (long, ISVGRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISVGRect*, int> getExtentOfChar;

        [NativeTypeName("HRESULT (long, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, float*, int> getRotationOfChar;

        [NativeTypeName("HRESULT (ISVGPoint *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGPoint, int*, int> getCharNumAtPosition;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> selectSubString;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISVGTextContentElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISVGTextContentElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISVGTextContentElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISVGTextContentElement(Silk.NET.Windows.IDispatch value)
    {
        return new ISVGTextContentElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTextContentElement"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTextContentElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISVGTextContentElement value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISVGTextContentElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISVGTextContentElement(Silk.NET.Windows.IUnknown value)
    {
        return new ISVGTextContentElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISVGTextContentElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISVGTextContentElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISVGTextContentElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
