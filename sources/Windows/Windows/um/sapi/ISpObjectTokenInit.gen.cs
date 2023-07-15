// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpObjectTokenInit.xml' path='doc/member[@name="ISpObjectTokenInit"]/*'/>
[Guid("B8AAB0CF-346F-49D8-9499-C8B03F161D51")]
[NativeTypeName("struct ISpObjectTokenInit : ISpObjectToken")]
[NativeInheritance("ISpObjectToken")]
public unsafe partial struct ISpObjectTokenInit : ISpObjectTokenInit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpObjectTokenInit));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, Guid*, void**, int> )(lpVtbl[0]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, uint> )(lpVtbl[1]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, uint> )(lpVtbl[2]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpDataKey.SetData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, uint, byte*, int> )(lpVtbl[3]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
    }

    /// <inheritdoc cref = "ISpDataKey.GetData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, uint*, byte*, int> )(lpVtbl[4]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
    }

    /// <inheritdoc cref = "ISpDataKey.SetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, ushort*, int> )(lpVtbl[5]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
    }

    /// <inheritdoc cref = "ISpDataKey.GetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, ushort**, int> )(lpVtbl[6]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
    }

    /// <inheritdoc cref = "ISpDataKey.SetDWORD"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, uint, int> )(lpVtbl[7]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
    }

    /// <inheritdoc cref = "ISpDataKey.GetDWORD"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, uint*, int> )(lpVtbl[8]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
    }

    /// <inheritdoc cref = "ISpDataKey.OpenKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, ISpDataKey**, int> )(lpVtbl[9]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
    }

    /// <inheritdoc cref = "ISpDataKey.CreateKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, ISpDataKey**, int> )(lpVtbl[10]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
    }

    /// <inheritdoc cref = "ISpDataKey.DeleteKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, int> )(lpVtbl[11]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszSubKey);
    }

    /// <inheritdoc cref = "ISpDataKey.DeleteValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, int> )(lpVtbl[12]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszValueName);
    }

    /// <inheritdoc cref = "ISpDataKey.EnumKeys"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, uint, ushort**, int> )(lpVtbl[13]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
    }

    /// <inheritdoc cref = "ISpDataKey.EnumValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, uint, ushort**, int> )(lpVtbl[14]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), Index, ppszValueName);
    }

    /// <inheritdoc cref = "ISpObjectToken.SetId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("LPCWSTR")] ushort* pszTokenId, BOOL fCreateIfNotExist)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, ushort*, BOOL, int> )(lpVtbl[15]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszCategoryId, pszTokenId, fCreateIfNotExist);
    }

    /// <inheritdoc cref = "ISpObjectToken.GetId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort**, int> )(lpVtbl[16]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
    }

    /// <inheritdoc cref = "ISpObjectToken.GetCategory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCategory(ISpObjectTokenCategory** ppTokenCategory)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ISpObjectTokenCategory**, int> )(lpVtbl[17]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), ppTokenCategory);
    }

    /// <inheritdoc cref = "ISpObjectToken.CreateInstance"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, IUnknown*, uint, Guid*, void**, int> )(lpVtbl[18]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pUnkOuter, dwClsContext, riid, ppvObject);
    }

    /// <inheritdoc cref = "ISpObjectToken.GetStorageFileName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszFileNameSpecifier, [NativeTypeName("ULONG")] uint nFolder, [NativeTypeName("LPWSTR *")] ushort** ppszFilePath)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, Guid*, ushort*, ushort*, uint, ushort**, int> )(lpVtbl[19]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), clsidCaller, pszValueName, pszFileNameSpecifier, nFolder, ppszFilePath);
    }

    /// <inheritdoc cref = "ISpObjectToken.RemoveStorageFileName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RemoveStorageFileName([NativeTypeName("const IID &")] Guid* clsidCaller, [NativeTypeName("LPCWSTR")] ushort* pszKeyName, BOOL fDeleteFile)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, Guid*, ushort*, BOOL, int> )(lpVtbl[20]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), clsidCaller, pszKeyName, fDeleteFile);
    }

    /// <inheritdoc cref = "ISpObjectToken.Remove"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Remove([NativeTypeName("const CLSID *")] Guid* pclsidCaller)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, Guid*, int> )(lpVtbl[21]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pclsidCaller);
    }

    /// <inheritdoc cref = "ISpObjectToken.IsUISupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject, BOOL* pfSupported)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, void*, uint, IUnknown*, BOOL*, int> )(lpVtbl[22]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, punkObject, pfSupported);
    }

    /// <inheritdoc cref = "ISpObjectToken.DisplayUI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, IUnknown* punkObject)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, HWND, ushort*, ushort*, void*, uint, IUnknown*, int> )(lpVtbl[23]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData, punkObject);
    }

    /// <inheritdoc cref = "ISpObjectToken.MatchesAttributes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT MatchesAttributes([NativeTypeName("LPCWSTR")] ushort* pszAttributes, BOOL* pfMatches)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, BOOL*, int> )(lpVtbl[24]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszAttributes, pfMatches);
    }

    /// <include file='ISpObjectTokenInit.xml' path='doc/member[@name="ISpObjectTokenInit.InitFromDataKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT InitFromDataKey([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("LPCWSTR")] ushort* pszTokenId, ISpDataKey* pDataKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenInit*, ushort*, ushort*, ISpDataKey*, int> )(lpVtbl[25]))((ISpObjectTokenInit*)Unsafe.AsPointer(ref this), pszCategoryId, pszTokenId, pDataKey);
    }

    public interface Interface : ISpObjectToken.Interface
    {
        [VtblIndex(25)]
        HRESULT InitFromDataKey([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, [NativeTypeName("LPCWSTR")] ushort* pszTokenId, ISpDataKey* pDataKey);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, BOOL, int> SetId;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetId;
        [NativeTypeName("HRESULT (ISpObjectTokenCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectTokenCategory**, int> GetCategory;
        [NativeTypeName("HRESULT (IUnknown *, DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, Guid*, void**, int> CreateInstance;
        [NativeTypeName("HRESULT (const IID &, LPCWSTR, LPCWSTR, ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, ushort*, uint, ushort**, int> GetStorageFileName;
        [NativeTypeName("HRESULT (const IID &, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, BOOL, int> RemoveStorageFileName;
        [NativeTypeName("HRESULT (const CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> Remove;
        [NativeTypeName("HRESULT (LPCWSTR, void *, ULONG, IUnknown *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void*, uint, IUnknown*, BOOL*, int> IsUISupported;
        [NativeTypeName("HRESULT (HWND, LPCWSTR, LPCWSTR, void *, ULONG, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort*, ushort*, void*, uint, IUnknown*, int> DisplayUI;
        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> MatchesAttributes;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, ISpDataKey *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ISpDataKey*, int> InitFromDataKey;
    }
}