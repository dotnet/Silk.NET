// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A9849BBE-9EC8-4263-B764-62730F0D15D0")]
[NativeTypeName("struct IVMRSurface : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRSurface : IVMRSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRSurface));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRSurface, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVMRSurface, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRSurface, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsSurfaceLocked()
    {
        return ((delegate* unmanaged<IVMRSurface, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LockSurface(byte** lpSurface)
    {
        return ((delegate* unmanaged<IVMRSurface, byte**, int>)((*lpVtbl)[4]))(this, lpSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UnlockSurface()
    {
        return ((delegate* unmanaged<IVMRSurface, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSurface(
        [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7* lplpSurface
    )
    {
        return ((delegate* unmanaged<IVMRSurface, IDirectDrawSurface7*, int>)((*lpVtbl)[6]))(
            this,
            lplpSurface
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsSurfaceLocked();

        [VtblIndex(4)]
        HRESULT LockSurface(byte** lpSurface);

        [VtblIndex(5)]
        HRESULT UnlockSurface();

        [VtblIndex(6)]
        HRESULT GetSurface(
            [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7* lplpSurface
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSurfaceLocked;

        [NativeTypeName("HRESULT (BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> LockSurface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockSurface;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface7*, int> GetSurface;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVMRSurface"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRSurface(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRSurface"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRSurface(Silk.NET.Windows.IUnknown value)
    {
        return new IVMRSurface(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRSurface"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRSurface"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVMRSurface value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
