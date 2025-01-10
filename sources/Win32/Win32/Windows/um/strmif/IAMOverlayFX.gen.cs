// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("62FAE250-7E65-4460-BFC9-6398B322073C")]
[NativeTypeName("struct IAMOverlayFX : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMOverlayFX : IAMOverlayFX.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMOverlayFX));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMOverlayFX, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMOverlayFX, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMOverlayFX, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryOverlayFXCaps([NativeTypeName("DWORD *")] uint* lpdwOverlayFXCaps)
    {
        return ((delegate* unmanaged<IAMOverlayFX, uint*, int>)((*lpVtbl)[3]))(
            this,
            lpdwOverlayFXCaps
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOverlayFX([NativeTypeName("DWORD")] uint dwOverlayFX)
    {
        return ((delegate* unmanaged<IAMOverlayFX, uint, int>)((*lpVtbl)[4]))(this, dwOverlayFX);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOverlayFX([NativeTypeName("DWORD *")] uint* lpdwOverlayFX)
    {
        return ((delegate* unmanaged<IAMOverlayFX, uint*, int>)((*lpVtbl)[5]))(this, lpdwOverlayFX);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryOverlayFXCaps([NativeTypeName("DWORD *")] uint* lpdwOverlayFXCaps);

        [VtblIndex(4)]
        HRESULT SetOverlayFX([NativeTypeName("DWORD")] uint dwOverlayFX);

        [VtblIndex(5)]
        HRESULT GetOverlayFX([NativeTypeName("DWORD *")] uint* lpdwOverlayFX);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> QueryOverlayFXCaps;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOverlayFX;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOverlayFX;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMOverlayFX"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMOverlayFX(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMOverlayFX"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMOverlayFX(Silk.NET.Windows.IUnknown value)
    {
        return new IAMOverlayFX(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMOverlayFX"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMOverlayFX"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMOverlayFX value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
