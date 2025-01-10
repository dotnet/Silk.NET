// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CA7EAC50-2D01-4145-86D4-5AE7D70F4469")]
[NativeTypeName("struct ISpeechObjectTokenCategory : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechObjectTokenCategory
    : ISpeechObjectTokenCategory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechObjectTokenCategory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpeechObjectTokenCategory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechObjectTokenCategory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechObjectTokenCategory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechObjectTokenCategory, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechObjectTokenCategory, uint, uint, ITypeInfo*, int>)(
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
                ISpeechObjectTokenCategory,
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
                ISpeechObjectTokenCategory,
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
    public HRESULT get_Id([NativeTypeName("BSTR *")] ushort** Id)
    {
        return ((delegate* unmanaged<ISpeechObjectTokenCategory, ushort**, int>)((*lpVtbl)[7]))(
            this,
            Id
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Default([NativeTypeName("const BSTR")] ushort* TokenId)
    {
        return ((delegate* unmanaged<ISpeechObjectTokenCategory, ushort*, int>)((*lpVtbl)[8]))(
            this,
            TokenId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Default([NativeTypeName("BSTR *")] ushort** TokenId)
    {
        return ((delegate* unmanaged<ISpeechObjectTokenCategory, ushort**, int>)((*lpVtbl)[9]))(
            this,
            TokenId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetId(
        [NativeTypeName("const BSTR")] ushort* Id,
        [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0
    )
    {
        return (
            (delegate* unmanaged<ISpeechObjectTokenCategory, ushort*, short, int>)((*lpVtbl)[10])
        )(this, Id, CreateIfNotExist);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDataKey(SpeechDataKeyLocation Location, ISpeechDataKey* DataKey)
    {
        return (
            (delegate* unmanaged<
                ISpeechObjectTokenCategory,
                SpeechDataKeyLocation,
                ISpeechDataKey*,
                int>)((*lpVtbl)[11])
        )(this, Location, DataKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumerateTokens(
        [NativeTypeName("BSTR")] ushort* RequiredAttributes,
        [NativeTypeName("BSTR")] ushort* OptionalAttributes,
        ISpeechObjectTokens* Tokens
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechObjectTokenCategory,
                ushort*,
                ushort*,
                ISpeechObjectTokens*,
                int>)((*lpVtbl)[12])
        )(this, RequiredAttributes, OptionalAttributes, Tokens);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Id([NativeTypeName("BSTR *")] ushort** Id);

        [VtblIndex(8)]
        HRESULT put_Default([NativeTypeName("const BSTR")] ushort* TokenId);

        [VtblIndex(9)]
        HRESULT get_Default([NativeTypeName("BSTR *")] ushort** TokenId);

        [VtblIndex(10)]
        HRESULT SetId(
            [NativeTypeName("const BSTR")] ushort* Id,
            [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0
        );

        [VtblIndex(11)]
        HRESULT GetDataKey(SpeechDataKeyLocation Location, ISpeechDataKey* DataKey);

        [VtblIndex(12)]
        HRESULT EnumerateTokens(
            [NativeTypeName("BSTR")] ushort* RequiredAttributes,
            [NativeTypeName("BSTR")] ushort* OptionalAttributes,
            ISpeechObjectTokens* Tokens
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Id;

        [NativeTypeName("HRESULT (const BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Default;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Default;

        [NativeTypeName("HRESULT (const BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> SetId;

        [NativeTypeName(
            "HRESULT (SpeechDataKeyLocation, ISpeechDataKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpeechDataKeyLocation, ISpeechDataKey*, int> GetDataKey;

        [NativeTypeName("HRESULT (BSTR, BSTR, ISpeechObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ISpeechObjectTokens*,
            int> EnumerateTokens;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechObjectTokenCategory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechObjectTokenCategory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechObjectTokenCategory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechObjectTokenCategory(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechObjectTokenCategory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechObjectTokenCategory"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechObjectTokenCategory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechObjectTokenCategory value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechObjectTokenCategory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechObjectTokenCategory(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechObjectTokenCategory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechObjectTokenCategory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechObjectTokenCategory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechObjectTokenCategory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
