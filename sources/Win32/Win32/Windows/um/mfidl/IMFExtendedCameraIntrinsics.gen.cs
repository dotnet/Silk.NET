// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("687F6DAC-6987-4750-A16A-734D1E7A10FE")]
[NativeTypeName("struct IMFExtendedCameraIntrinsics : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFExtendedCameraIntrinsics
    : IMFExtendedCameraIntrinsics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFExtendedCameraIntrinsics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFExtendedCameraIntrinsics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFromBuffer(byte* pbBuffer, [NativeTypeName("DWORD")] uint dwBufferSize)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics, byte*, uint, int>)((*lpVtbl)[3]))(
            this,
            pbBuffer,
            dwBufferSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBufferSize([NativeTypeName("DWORD *")] uint* pdwBufferSize)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwBufferSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SerializeToBuffer(
        byte* pbBuffer,
        [NativeTypeName("DWORD *")] uint* pdwBufferSize
    )
    {
        return (
            (delegate* unmanaged<IMFExtendedCameraIntrinsics, byte*, uint*, int>)((*lpVtbl)[5])
        )(this, pbBuffer, pdwBufferSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIntrinsicModelCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics, uint*, int>)((*lpVtbl)[6]))(
            this,
            pdwCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIntrinsicModelByIndex(
        [NativeTypeName("DWORD")] uint dwIndex,
        IMFExtendedCameraIntrinsicModel* ppIntrinsicModel
    )
    {
        return (
            (delegate* unmanaged<
                IMFExtendedCameraIntrinsics,
                uint,
                IMFExtendedCameraIntrinsicModel*,
                int>)((*lpVtbl)[7])
        )(this, dwIndex, ppIntrinsicModel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddIntrinsicModel(IMFExtendedCameraIntrinsicModel pIntrinsicModel)
    {
        return (
            (delegate* unmanaged<
                IMFExtendedCameraIntrinsics,
                IMFExtendedCameraIntrinsicModel,
                int>)((*lpVtbl)[8])
        )(this, pIntrinsicModel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeFromBuffer(byte* pbBuffer, [NativeTypeName("DWORD")] uint dwBufferSize);

        [VtblIndex(4)]
        HRESULT GetBufferSize([NativeTypeName("DWORD *")] uint* pdwBufferSize);

        [VtblIndex(5)]
        HRESULT SerializeToBuffer(byte* pbBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferSize);

        [VtblIndex(6)]
        HRESULT GetIntrinsicModelCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(7)]
        HRESULT GetIntrinsicModelByIndex(
            [NativeTypeName("DWORD")] uint dwIndex,
            IMFExtendedCameraIntrinsicModel* ppIntrinsicModel
        );

        [VtblIndex(8)]
        HRESULT AddIntrinsicModel(IMFExtendedCameraIntrinsicModel pIntrinsicModel);
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

        [NativeTypeName("HRESULT (BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> InitializeFromBuffer;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBufferSize;

        [NativeTypeName("HRESULT (BYTE *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint*, int> SerializeToBuffer;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetIntrinsicModelCount;

        [NativeTypeName(
            "HRESULT (DWORD, IMFExtendedCameraIntrinsicModel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMFExtendedCameraIntrinsicModel*,
            int> GetIntrinsicModelByIndex;

        [NativeTypeName("HRESULT (IMFExtendedCameraIntrinsicModel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFExtendedCameraIntrinsicModel, int> AddIntrinsicModel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFExtendedCameraIntrinsics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFExtendedCameraIntrinsics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFExtendedCameraIntrinsics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFExtendedCameraIntrinsics(Silk.NET.Windows.IUnknown value)
    {
        return new IMFExtendedCameraIntrinsics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFExtendedCameraIntrinsics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFExtendedCameraIntrinsics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFExtendedCameraIntrinsics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
