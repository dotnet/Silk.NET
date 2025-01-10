// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("92A66E2B-C830-4149-83DF-6FC2BA1E7A5B")]
[NativeTypeName("struct ISpRegDataKey : ISpDataKey")]
[NativeInheritance("ISpDataKey")]
public unsafe partial struct ISpRegDataKey : ISpRegDataKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRegDataKey));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRegDataKey, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRegDataKey, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRegDataKey, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("ULONG")] uint cbData,
        [NativeTypeName("const BYTE *")] byte* pData
    )
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, uint, byte*, int>)((*lpVtbl)[3]))(
            this,
            pszValueName,
            cbData,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("ULONG *")] uint* pcbData,
        byte* pData
    )
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, uint*, byte*, int>)((*lpVtbl)[4]))(
            this,
            pszValueName,
            pcbData,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("LPCWSTR")] ushort* pszValue
    )
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, ushort*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pszValueName,
            ppszValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD(
        [NativeTypeName("LPCWSTR")] ushort* pszValueName,
        [NativeTypeName("DWORD")] uint dwValue
    )
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, uint, int>)((*lpVtbl)[7]))(
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
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, uint*, int>)((*lpVtbl)[8]))(
            this,
            pszValueName,
            pdwValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey* ppSubKey)
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, ISpDataKey*, int>)((*lpVtbl)[9]))(
            this,
            pszSubKeyName,
            ppSubKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey* ppSubKey)
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, ISpDataKey*, int>)((*lpVtbl)[10]))(
            this,
            pszSubKey,
            ppSubKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, int>)((*lpVtbl)[11]))(this, pszSubKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
    {
        return ((delegate* unmanaged<ISpRegDataKey, ushort*, int>)((*lpVtbl)[12]))(
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
        return ((delegate* unmanaged<ISpRegDataKey, uint, ushort**, int>)((*lpVtbl)[13]))(
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
        return ((delegate* unmanaged<ISpRegDataKey, uint, ushort**, int>)((*lpVtbl)[14]))(
            this,
            Index,
            ppszValueName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetKey(HKEY hkey, BOOL fReadOnly)
    {
        return ((delegate* unmanaged<ISpRegDataKey, HKEY, BOOL, int>)((*lpVtbl)[15]))(
            this,
            hkey,
            fReadOnly
        );
    }

    public interface Interface : ISpDataKey.Interface
    {
        [VtblIndex(15)]
        HRESULT SetKey(HKEY hkey, BOOL fReadOnly);
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

        [NativeTypeName("HRESULT (HKEY, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKEY, BOOL, int> SetKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRegDataKey"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRegDataKey(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpDataKey"/> to <see cref = "ISpRegDataKey"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpDataKey"/> instance to be converted </param>
    public static explicit operator ISpRegDataKey(Silk.NET.Windows.ISpDataKey value)
    {
        return new ISpRegDataKey(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRegDataKey"/> to <see cref = "Silk.NET.Windows.ISpDataKey"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRegDataKey"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpDataKey(ISpRegDataKey value)
    {
        return new Silk.NET.Windows.ISpDataKey(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRegDataKey"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRegDataKey(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRegDataKey(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRegDataKey"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRegDataKey"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRegDataKey value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
