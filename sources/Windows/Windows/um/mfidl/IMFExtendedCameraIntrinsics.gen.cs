// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFExtendedCameraIntrinsics.xml' path='doc/member[@name="IMFExtendedCameraIntrinsics"]/*'/>
[Guid("687F6DAC-6987-4750-A16A-734D1E7A10FE")]
[NativeTypeName("struct IMFExtendedCameraIntrinsics : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFExtendedCameraIntrinsics : IMFExtendedCameraIntrinsics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFExtendedCameraIntrinsics));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, Guid*, void**, int> )(lpVtbl[0]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, uint> )(lpVtbl[1]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, uint> )(lpVtbl[2]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedCameraIntrinsics.xml' path='doc/member[@name="IMFExtendedCameraIntrinsics.InitializeFromBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFromBuffer(byte* pbBuffer, [NativeTypeName("DWORD")] uint dwBufferSize)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, byte*, uint, int> )(lpVtbl[3]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pbBuffer, dwBufferSize);
    }

    /// <include file='IMFExtendedCameraIntrinsics.xml' path='doc/member[@name="IMFExtendedCameraIntrinsics.GetBufferSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBufferSize([NativeTypeName("DWORD *")] uint* pdwBufferSize)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, uint*, int> )(lpVtbl[4]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pdwBufferSize);
    }

    /// <include file='IMFExtendedCameraIntrinsics.xml' path='doc/member[@name="IMFExtendedCameraIntrinsics.SerializeToBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SerializeToBuffer(byte* pbBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferSize)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, byte*, uint*, int> )(lpVtbl[5]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pbBuffer, pdwBufferSize);
    }

    /// <include file='IMFExtendedCameraIntrinsics.xml' path='doc/member[@name="IMFExtendedCameraIntrinsics.GetIntrinsicModelCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIntrinsicModelCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, uint*, int> )(lpVtbl[6]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IMFExtendedCameraIntrinsics.xml' path='doc/member[@name="IMFExtendedCameraIntrinsics.GetIntrinsicModelByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIntrinsicModelByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFExtendedCameraIntrinsicModel** ppIntrinsicModel)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, uint, IMFExtendedCameraIntrinsicModel**, int> )(lpVtbl[7]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), dwIndex, ppIntrinsicModel);
    }

    /// <include file='IMFExtendedCameraIntrinsics.xml' path='doc/member[@name="IMFExtendedCameraIntrinsics.AddIntrinsicModel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddIntrinsicModel(IMFExtendedCameraIntrinsicModel* pIntrinsicModel)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsics*, IMFExtendedCameraIntrinsicModel*, int> )(lpVtbl[8]))((IMFExtendedCameraIntrinsics*)Unsafe.AsPointer(ref this), pIntrinsicModel);
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
        HRESULT GetIntrinsicModelByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFExtendedCameraIntrinsicModel** ppIntrinsicModel);
        [VtblIndex(8)]
        HRESULT AddIntrinsicModel(IMFExtendedCameraIntrinsicModel* pIntrinsicModel);
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
        [NativeTypeName("HRESULT (DWORD, IMFExtendedCameraIntrinsicModel **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFExtendedCameraIntrinsicModel**, int> GetIntrinsicModelByIndex;
        [NativeTypeName("HRESULT (IMFExtendedCameraIntrinsicModel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFExtendedCameraIntrinsicModel*, int> AddIntrinsicModel;
    }
}