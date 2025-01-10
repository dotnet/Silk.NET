// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("133ADCD4-19B4-4020-9FDC-842E78253B17")]
[NativeTypeName("struct ISpPhoneticAlphabetConverter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpPhoneticAlphabetConverter
    : ISpPhoneticAlphabetConverter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhoneticAlphabetConverter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpPhoneticAlphabetConverter, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetConverter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetConverter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLangId([NativeTypeName("WORD *")] ushort* pLangID)
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetConverter, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pLangID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetLangId([NativeTypeName("WORD")] ushort LangID)
    {
        return ((delegate* unmanaged<ISpPhoneticAlphabetConverter, ushort, int>)((*lpVtbl)[4]))(
            this,
            LangID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SAPI2UPS(
        [NativeTypeName("const SPPHONEID *")] ushort* pszSAPIId,
        [NativeTypeName("SPPHONEID *")] ushort* pszUPSId,
        [NativeTypeName("DWORD")] uint cMaxLength
    )
    {
        return (
            (delegate* unmanaged<ISpPhoneticAlphabetConverter, ushort*, ushort*, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, pszSAPIId, pszUPSId, cMaxLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UPS2SAPI(
        [NativeTypeName("const SPPHONEID *")] ushort* pszUPSId,
        [NativeTypeName("SPPHONEID *")] ushort* pszSAPIId,
        [NativeTypeName("DWORD")] uint cMaxLength
    )
    {
        return (
            (delegate* unmanaged<ISpPhoneticAlphabetConverter, ushort*, ushort*, uint, int>)(
                (*lpVtbl)[6]
            )
        )(this, pszUPSId, pszSAPIId, cMaxLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxConvertLength(
        [NativeTypeName("DWORD")] uint cSrcLength,
        BOOL bSAPI2UPS,
        [NativeTypeName("DWORD *")] uint* pcMaxDestLength
    )
    {
        return (
            (delegate* unmanaged<ISpPhoneticAlphabetConverter, uint, BOOL, uint*, int>)(
                (*lpVtbl)[7]
            )
        )(this, cSrcLength, bSAPI2UPS, pcMaxDestLength);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLangId([NativeTypeName("WORD *")] ushort* pLangID);

        [VtblIndex(4)]
        HRESULT SetLangId([NativeTypeName("WORD")] ushort LangID);

        [VtblIndex(5)]
        HRESULT SAPI2UPS(
            [NativeTypeName("const SPPHONEID *")] ushort* pszSAPIId,
            [NativeTypeName("SPPHONEID *")] ushort* pszUPSId,
            [NativeTypeName("DWORD")] uint cMaxLength
        );

        [VtblIndex(6)]
        HRESULT UPS2SAPI(
            [NativeTypeName("const SPPHONEID *")] ushort* pszUPSId,
            [NativeTypeName("SPPHONEID *")] ushort* pszSAPIId,
            [NativeTypeName("DWORD")] uint cMaxLength
        );

        [VtblIndex(7)]
        HRESULT GetMaxConvertLength(
            [NativeTypeName("DWORD")] uint cSrcLength,
            BOOL bSAPI2UPS,
            [NativeTypeName("DWORD *")] uint* pcMaxDestLength
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

        [NativeTypeName("HRESULT (WORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetLangId;

        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> SetLangId;

        [NativeTypeName("HRESULT (const SPPHONEID *, SPPHONEID *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint, int> SAPI2UPS;

        [NativeTypeName("HRESULT (const SPPHONEID *, SPPHONEID *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint, int> UPS2SAPI;

        [NativeTypeName("HRESULT (DWORD, BOOL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, uint*, int> GetMaxConvertLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpPhoneticAlphabetConverter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpPhoneticAlphabetConverter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpPhoneticAlphabetConverter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpPhoneticAlphabetConverter(Silk.NET.Windows.IUnknown value)
    {
        return new ISpPhoneticAlphabetConverter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhoneticAlphabetConverter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhoneticAlphabetConverter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpPhoneticAlphabetConverter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
