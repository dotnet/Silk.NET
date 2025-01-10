// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D666063F-1587-4E43-81F1-B948E807363F")]
[NativeTypeName("struct IMMDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMDevice : IMMDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMMDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate(
        [NativeTypeName("const IID &")] Guid* iid,
        [NativeTypeName("DWORD")] uint dwClsCtx,
        PROPVARIANT* pActivationParams,
        void** ppInterface
    )
    {
        return (
            (delegate* unmanaged<IMMDevice, Guid*, uint, PROPVARIANT*, void**, int>)((*lpVtbl)[3])
        )(this, iid, dwClsCtx, pActivationParams, ppInterface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenPropertyStore(
        [NativeTypeName("DWORD")] uint stgmAccess,
        IPropertyStore* ppProperties
    )
    {
        return ((delegate* unmanaged<IMMDevice, uint, IPropertyStore*, int>)((*lpVtbl)[4]))(
            this,
            stgmAccess,
            ppProperties
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppstrId)
    {
        return ((delegate* unmanaged<IMMDevice, ushort**, int>)((*lpVtbl)[5]))(this, ppstrId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetState([NativeTypeName("DWORD *")] uint* pdwState)
    {
        return ((delegate* unmanaged<IMMDevice, uint*, int>)((*lpVtbl)[6]))(this, pdwState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Activate(
            [NativeTypeName("const IID &")] Guid* iid,
            [NativeTypeName("DWORD")] uint dwClsCtx,
            PROPVARIANT* pActivationParams,
            void** ppInterface
        );

        [VtblIndex(4)]
        HRESULT OpenPropertyStore(
            [NativeTypeName("DWORD")] uint stgmAccess,
            IPropertyStore* ppProperties
        );

        [VtblIndex(5)]
        HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppstrId);

        [VtblIndex(6)]
        HRESULT GetState([NativeTypeName("DWORD *")] uint* pdwState);
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
            "HRESULT (const IID &, DWORD, PROPVARIANT *, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint, PROPVARIANT*, void**, int> Activate;

        [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyStore*, int> OpenPropertyStore;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMMDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMMDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMMDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMMDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IMMDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMMDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMMDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMMDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
