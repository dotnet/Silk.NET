// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpRegDataKey.xml' path='doc/member[@name="ISpRegDataKey"]/*'/>
[Guid("92A66E2B-C830-4149-83DF-6FC2BA1E7A5B")]
[NativeTypeName("struct ISpRegDataKey : ISpDataKey")]
[NativeInheritance("ISpDataKey")]
public unsafe partial struct ISpRegDataKey : ISpRegDataKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRegDataKey));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, Guid*, void**, int> )(lpVtbl[0]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpRegDataKey*, uint> )(lpVtbl[1]))((ISpRegDataKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRegDataKey*, uint> )(lpVtbl[2]))((ISpRegDataKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpDataKey.SetData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, uint, byte*, int> )(lpVtbl[3]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
    }

    /// <inheritdoc cref = "ISpDataKey.GetData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, uint*, byte*, int> )(lpVtbl[4]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
    }

    /// <inheritdoc cref = "ISpDataKey.SetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, ushort*, int> )(lpVtbl[5]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
    }

    /// <inheritdoc cref = "ISpDataKey.GetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, ushort**, int> )(lpVtbl[6]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
    }

    /// <inheritdoc cref = "ISpDataKey.SetDWORD"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, uint, int> )(lpVtbl[7]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
    }

    /// <inheritdoc cref = "ISpDataKey.GetDWORD"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, uint*, int> )(lpVtbl[8]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
    }

    /// <inheritdoc cref = "ISpDataKey.OpenKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, ISpDataKey**, int> )(lpVtbl[9]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
    }

    /// <inheritdoc cref = "ISpDataKey.CreateKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, ISpDataKey**, int> )(lpVtbl[10]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
    }

    /// <inheritdoc cref = "ISpDataKey.DeleteKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, int> )(lpVtbl[11]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszSubKey);
    }

    /// <inheritdoc cref = "ISpDataKey.DeleteValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, ushort*, int> )(lpVtbl[12]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName);
    }

    /// <inheritdoc cref = "ISpDataKey.EnumKeys"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, uint, ushort**, int> )(lpVtbl[13]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
    }

    /// <inheritdoc cref = "ISpDataKey.EnumValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, uint, ushort**, int> )(lpVtbl[14]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), Index, ppszValueName);
    }

    /// <include file='ISpRegDataKey.xml' path='doc/member[@name="ISpRegDataKey.SetKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetKey(HKEY hkey, BOOL fReadOnly)
    {
        return ((delegate* unmanaged<ISpRegDataKey*, HKEY, BOOL, int> )(lpVtbl[15]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), hkey, fReadOnly);
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
        public delegate* unmanaged<TSelf*, ushort*, ISpDataKey**, int> OpenKey;
        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ISpDataKey**, int> CreateKey;
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
}