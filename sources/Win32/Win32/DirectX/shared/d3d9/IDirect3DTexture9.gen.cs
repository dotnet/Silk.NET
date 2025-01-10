// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("85C31227-3DE5-4F00-9B3A-F11AC38C18B5")]
[NativeTypeName("struct IDirect3DTexture9 : IDirect3DBaseTexture9")]
[NativeInheritance("IDirect3DBaseTexture9")]
public unsafe partial struct IDirect3DTexture9 : IDirect3DTexture9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DTexture9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3DTexture9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DTexture9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9* ppDevice)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, IDirect3DDevice9*, int>)((*lpVtbl)[3]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* refguid,
        [NativeTypeName("const void *")] void* pData,
        [NativeTypeName("DWORD")] uint SizeOfData,
        [NativeTypeName("DWORD")] uint Flags
    )
    {
        return (
            (delegate* unmanaged<IDirect3DTexture9, Guid*, void*, uint, uint, int>)((*lpVtbl)[4])
        )(this, refguid, pData, SizeOfData, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* refguid,
        void* pData,
        [NativeTypeName("DWORD *")] uint* pSizeOfData
    )
    {
        return ((delegate* unmanaged<IDirect3DTexture9, Guid*, void*, uint*, int>)((*lpVtbl)[5]))(
            this,
            refguid,
            pData,
            pSizeOfData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, Guid*, int>)((*lpVtbl)[6]))(this, refguid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, uint, uint>)((*lpVtbl)[7]))(
            this,
            PriorityNew
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("DWORD")]
    public uint GetPriority()
    {
        return ((delegate* unmanaged<IDirect3DTexture9, uint>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void PreLoad()
    {
        ((delegate* unmanaged<IDirect3DTexture9, void>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public new D3DRESOURCETYPE GetType()
    {
        return ((delegate* unmanaged<IDirect3DTexture9, D3DRESOURCETYPE>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("DWORD")]
    public uint SetLOD([NativeTypeName("DWORD")] uint LODNew)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, uint, uint>)((*lpVtbl)[11]))(this, LODNew);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("DWORD")]
    public uint GetLOD()
    {
        return ((delegate* unmanaged<IDirect3DTexture9, uint>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("DWORD")]
    public uint GetLevelCount()
    {
        return ((delegate* unmanaged<IDirect3DTexture9, uint>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetAutoGenFilterType(D3DTEXTUREFILTERTYPE FilterType)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, D3DTEXTUREFILTERTYPE, int>)((*lpVtbl)[14]))(
            this,
            FilterType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public D3DTEXTUREFILTERTYPE GetAutoGenFilterType()
    {
        return ((delegate* unmanaged<IDirect3DTexture9, D3DTEXTUREFILTERTYPE>)((*lpVtbl)[15]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void GenerateMipSubLevels()
    {
        ((delegate* unmanaged<IDirect3DTexture9, void>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetLevelDesc(uint Level, D3DSURFACE_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<IDirect3DTexture9, uint, D3DSURFACE_DESC*, int>)((*lpVtbl)[17])
        )(this, Level, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetSurfaceLevel(uint Level, IDirect3DSurface9* ppSurfaceLevel)
    {
        return (
            (delegate* unmanaged<IDirect3DTexture9, uint, IDirect3DSurface9*, int>)((*lpVtbl)[18])
        )(this, Level, ppSurfaceLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT LockRect(
        uint Level,
        D3DLOCKED_RECT* pLockedRect,
        [NativeTypeName("const RECT *")] RECT* pRect,
        [NativeTypeName("DWORD")] uint Flags
    )
    {
        return (
            (delegate* unmanaged<IDirect3DTexture9, uint, D3DLOCKED_RECT*, RECT*, uint, int>)(
                (*lpVtbl)[19]
            )
        )(this, Level, pLockedRect, pRect, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT UnlockRect(uint Level)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, uint, int>)((*lpVtbl)[20]))(this, Level);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddDirtyRect([NativeTypeName("const RECT *")] RECT* pDirtyRect)
    {
        return ((delegate* unmanaged<IDirect3DTexture9, RECT*, int>)((*lpVtbl)[21]))(
            this,
            pDirtyRect
        );
    }

    public interface Interface : IDirect3DBaseTexture9.Interface
    {
        [VtblIndex(17)]
        HRESULT GetLevelDesc(uint Level, D3DSURFACE_DESC* pDesc);

        [VtblIndex(18)]
        HRESULT GetSurfaceLevel(uint Level, IDirect3DSurface9* ppSurfaceLevel);

        [VtblIndex(19)]
        HRESULT LockRect(
            uint Level,
            D3DLOCKED_RECT* pLockedRect,
            [NativeTypeName("const RECT *")] RECT* pRect,
            [NativeTypeName("DWORD")] uint Flags
        );

        [VtblIndex(20)]
        HRESULT UnlockRect(uint Level);

        [VtblIndex(21)]
        HRESULT AddDirtyRect([NativeTypeName("const RECT *")] RECT* pDirtyRect);
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

        [NativeTypeName(
            "HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DDevice9*, int> GetDevice;

        [NativeTypeName(
            "HRESULT (const GUID &, const void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint, uint, int> SetPrivateData;

        [NativeTypeName(
            "HRESULT (const GUID &, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> FreePrivateData;

        [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> SetPriority;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetPriority;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PreLoad;

        [NativeTypeName("D3DRESOURCETYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3DRESOURCETYPE> GetType;

        [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> SetLOD;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLOD;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLevelCount;

        [NativeTypeName(
            "HRESULT (D3DTEXTUREFILTERTYPE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DTEXTUREFILTERTYPE, int> SetAutoGenFilterType;

        [NativeTypeName(
            "D3DTEXTUREFILTERTYPE () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DTEXTUREFILTERTYPE> GetAutoGenFilterType;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> GenerateMipSubLevels;

        [NativeTypeName(
            "HRESULT (UINT, D3DSURFACE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DSURFACE_DESC*, int> GetLevelDesc;

        [NativeTypeName(
            "HRESULT (UINT, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9*, int> GetSurfaceLevel;

        [NativeTypeName(
            "HRESULT (UINT, D3DLOCKED_RECT *, const RECT *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DLOCKED_RECT*, RECT*, uint, int> LockRect;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnlockRect;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> AddDirtyRect;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DTexture9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DTexture9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirect3DBaseTexture9"/> to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirect3DBaseTexture9"/> instance to be converted </param>
    public static explicit operator IDirect3DTexture9(Silk.NET.DirectX.IDirect3DBaseTexture9 value)
    {
        return new IDirect3DTexture9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DTexture9"/> to <see cref = "Silk.NET.DirectX.IDirect3DBaseTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirect3DBaseTexture9(IDirect3DTexture9 value)
    {
        return new Silk.NET.DirectX.IDirect3DBaseTexture9(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirect3DResource9"/> to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirect3DResource9"/> instance to be converted </param>
    public static explicit operator IDirect3DTexture9(Silk.NET.DirectX.IDirect3DResource9 value)
    {
        return new IDirect3DTexture9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DTexture9"/> to <see cref = "Silk.NET.DirectX.IDirect3DResource9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirect3DResource9(IDirect3DTexture9 value)
    {
        return new Silk.NET.DirectX.IDirect3DResource9(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DTexture9(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DTexture9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DTexture9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DTexture9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
