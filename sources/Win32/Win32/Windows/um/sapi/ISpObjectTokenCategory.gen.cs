// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2D3D3845-39AF-4850-BBF9-40B49780011D")]
[NativeTypeName("struct ISpObjectTokenCategory : ISpDataKey")]
[NativeInheritance("ISpDataKey")]
public unsafe partial struct ISpObjectTokenCategory : ISpObjectTokenCategory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpObjectTokenCategory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpObjectTokenCategory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("ULONG")] uint cbData,
        [NativeTypeName("const BYTE *")] byte* pData
    )
    {
        return (
            (delegate* unmanaged<ISpObjectTokenCategory, ushort*, uint, byte*, int>)((*lpVtbl)[3])
        )(this, pszValueName, cbData, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("ULONG *")] uint* pcbData,
        byte* pData
    )
    {
        return (
            (delegate* unmanaged<ISpObjectTokenCategory, ushort*, uint*, byte*, int>)((*lpVtbl)[4])
        )(this, pszValueName, pcbData, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("LPCWSTR")] ushort* pszValue
    )
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort*, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pszValueName,
            pszValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("LPWSTR *")] ushort** ppszValue
    )
    {
        return (
            (delegate* unmanaged<ISpObjectTokenCategory, ushort*, ushort**, int>)((*lpVtbl)[6])
        )(this, pszValueName, ppszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("DWORD")] uint dwValue
    )
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort*, uint, int>)((*lpVtbl)[7]))(
            this,
            pszValueName,
            dwValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("DWORD *")] uint* pdwValue
    )
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort*, uint*, int>)((*lpVtbl)[8]))(
            this,
            pszValueName,
            pdwValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey* ppSubKey)
    {
        return (
            (delegate* unmanaged<ISpObjectTokenCategory, ushort*, ISpDataKey*, int>)((*lpVtbl)[9])
        )(this, pszSubKeyName, ppSubKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey* ppSubKey)
    {
        return (
            (delegate* unmanaged<ISpObjectTokenCategory, ushort*, ISpDataKey*, int>)((*lpVtbl)[10])
        )(this, pszSubKey, ppSubKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort*, int>)((*lpVtbl)[11]))(
            this,
            pszSubKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort*, int>)((*lpVtbl)[12]))(
            this,
            pszValueName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys(
        [NativeTypeName("ULONG")] uint Index,
        [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName
    )
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, uint, ushort**, int>)((*lpVtbl)[13]))(
            this,
            Index,
            ppszSubKeyName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues(
        [NativeTypeName("ULONG")] uint Index,
        [NativeTypeName("LPWSTR *")] ushort** ppszValueName
    )
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, uint, ushort**, int>)((*lpVtbl)[14]))(
            this,
            Index,
            ppszValueName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, BOOL fCreateIfNotExist)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort*, BOOL, int>)((*lpVtbl)[15]))(
            this,
            pszCategoryId,
            fCreateIfNotExist
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemCategoryId)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort**, int>)((*lpVtbl)[16]))(
            this,
            ppszCoMemCategoryId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, ISpDataKey* ppDataKey)
    {
        return (
            (delegate* unmanaged<ISpObjectTokenCategory, SPDATAKEYLOCATION, ISpDataKey*, int>)(
                (*lpVtbl)[17]
            )
        )(this, spdkl, ppDataKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT EnumTokens(
        [NativeTypeName("LPCWSTR")] ushort* pzsReqAttribs,
        [NativeTypeName("LPCWSTR")] ushort* pszOptAttribs,
        IEnumSpObjectTokens* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                ISpObjectTokenCategory,
                ushort*,
                ushort*,
                IEnumSpObjectTokens*,
                int>)((*lpVtbl)[18])
        )(this, pzsReqAttribs, pszOptAttribs, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetDefaultTokenId([NativeTypeName("LPCWSTR")] ushort* pszTokenId)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort*, int>)((*lpVtbl)[19]))(
            this,
            pszTokenId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDefaultTokenId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory, ushort**, int>)((*lpVtbl)[20]))(
            this,
            ppszCoMemTokenId
        );
    }

    public interface Interface : ISpDataKey.Interface
    {
        [VtblIndex(15)]
        HRESULT SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, BOOL fCreateIfNotExist);

        [VtblIndex(16)]
        HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemCategoryId);

        [VtblIndex(17)]
        HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, ISpDataKey* ppDataKey);

        [VtblIndex(18)]
        HRESULT EnumTokens(
            [NativeTypeName("LPCWSTR")] ushort* pzsReqAttribs,
            [NativeTypeName("LPCWSTR")] ushort* pszOptAttribs,
            IEnumSpObjectTokens* ppEnum
        );

        [VtblIndex(19)]
        HRESULT SetDefaultTokenId([NativeTypeName("LPCWSTR")] ushort* pszTokenId);

        [VtblIndex(20)]
        HRESULT GetDefaultTokenId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId);
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

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, byte*, int> SetData;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, byte*, int> GetData;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ISpDataKey*, int> OpenKey;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ISpDataKey*, int> CreateKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteValue;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> EnumKeys;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> EnumValues;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL, int> SetId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetId;

        [NativeTypeName("HRESULT (SPDATAKEYLOCATION, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPDATAKEYLOCATION, ISpDataKey*, int> GetDataKey;

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, IEnumSpObjectTokens **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IEnumSpObjectTokens*, int> EnumTokens;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDefaultTokenId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDefaultTokenId;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpObjectTokenCategory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpObjectTokenCategory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpDataKey"/> to <see cref = "ISpObjectTokenCategory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpDataKey"/> instance to be converted </param>
    public static explicit operator ISpObjectTokenCategory(Silk.NET.Windows.ISpDataKey value)
    {
        return new ISpObjectTokenCategory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpObjectTokenCategory"/> to <see cref = "Silk.NET.Windows.ISpDataKey"/>.</summary>
    /// <param name = "value">The <see cref = "ISpObjectTokenCategory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpDataKey(ISpObjectTokenCategory value)
    {
        return new Silk.NET.Windows.ISpDataKey(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpObjectTokenCategory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpObjectTokenCategory(Silk.NET.Windows.IUnknown value)
    {
        return new ISpObjectTokenCategory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpObjectTokenCategory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpObjectTokenCategory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpObjectTokenCategory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
