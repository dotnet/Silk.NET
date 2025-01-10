// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B22754E2-4574-11D1-9888-006097DEACF9")]
[NativeTypeName("struct IADesktopP2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IADesktopP2 : IADesktopP2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IADesktopP2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IADesktopP2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IADesktopP2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IADesktopP2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReReadWallpaper()
    {
        return ((delegate* unmanaged<IADesktopP2, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetADObjectFlags(
        [NativeTypeName("DWORD *")] uint* pdwFlags,
        [NativeTypeName("DWORD")] uint dwMask
    )
    {
        return ((delegate* unmanaged<IADesktopP2, uint*, uint, int>)((*lpVtbl)[4]))(
            this,
            pdwFlags,
            dwMask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UpdateAllDesktopSubscriptions()
    {
        return ((delegate* unmanaged<IADesktopP2, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MakeDynamicChanges(IOleObject pOleObj)
    {
        return ((delegate* unmanaged<IADesktopP2, IOleObject, int>)((*lpVtbl)[6]))(this, pOleObj);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReReadWallpaper();

        [VtblIndex(4)]
        HRESULT GetADObjectFlags(
            [NativeTypeName("DWORD *")] uint* pdwFlags,
            [NativeTypeName("DWORD")] uint dwMask
        );

        [VtblIndex(5)]
        HRESULT UpdateAllDesktopSubscriptions();

        [VtblIndex(6)]
        HRESULT MakeDynamicChanges(IOleObject pOleObj);
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReReadWallpaper;

        [NativeTypeName(
            "HRESULT (DWORD *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, uint, int> GetADObjectFlags;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UpdateAllDesktopSubscriptions;

        [NativeTypeName("HRESULT (IOleObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleObject, int> MakeDynamicChanges;
    }

    /// <summary>Initializes a new instance of the <see cref = "IADesktopP2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IADesktopP2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IADesktopP2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IADesktopP2(Silk.NET.Windows.IUnknown value)
    {
        return new IADesktopP2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IADesktopP2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IADesktopP2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IADesktopP2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
