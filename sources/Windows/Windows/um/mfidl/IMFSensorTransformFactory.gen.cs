// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFSensorTransformFactory.xml' path='doc/member[@name="IMFSensorTransformFactory"]/*' />
[Guid("EED9C2EE-66B4-4F18-A697-AC7D3960215C")]
[NativeTypeName("struct IMFSensorTransformFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorTransformFactory : IMFSensorTransformFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorTransformFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, uint>)(lpVtbl[1]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, uint>)(lpVtbl[2]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSensorTransformFactory.xml' path='doc/member[@name="IMFSensorTransformFactory.GetFactoryAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFactoryAttributes(IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, IMFAttributes**, int>)(lpVtbl[3]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), ppAttributes);
    }

    /// <include file='IMFSensorTransformFactory.xml' path='doc/member[@name="IMFSensorTransformFactory.InitializeFactory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitializeFactory([NativeTypeName("DWORD")] uint dwMaxTransformCount, IMFCollection* pSensorDevices, IMFAttributes* pAttributes)
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, uint, IMFCollection*, IMFAttributes*, int>)(lpVtbl[4]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), dwMaxTransformCount, pSensorDevices, pAttributes);
    }

    /// <include file='IMFSensorTransformFactory.xml' path='doc/member[@name="IMFSensorTransformFactory.GetTransformCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTransformCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, uint*, int>)(lpVtbl[5]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IMFSensorTransformFactory.xml' path='doc/member[@name="IMFSensorTransformFactory.GetTransformInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTransformInformation([NativeTypeName("DWORD")] uint TransformIndex, Guid* pguidTransformId, IMFAttributes** ppAttributes, IMFCollection** ppStreamInformation)
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, uint, Guid*, IMFAttributes**, IMFCollection**, int>)(lpVtbl[6]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), TransformIndex, pguidTransformId, ppAttributes, ppStreamInformation);
    }

    /// <include file='IMFSensorTransformFactory.xml' path='doc/member[@name="IMFSensorTransformFactory.CreateTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateTransform([NativeTypeName("const GUID &")] Guid* guidSensorTransformID, IMFAttributes* pAttributes, IMFDeviceTransform** ppDeviceMFT)
    {
        return ((delegate* unmanaged<IMFSensorTransformFactory*, Guid*, IMFAttributes*, IMFDeviceTransform**, int>)(lpVtbl[7]))((IMFSensorTransformFactory*)Unsafe.AsPointer(ref this), guidSensorTransformID, pAttributes, ppDeviceMFT);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFactoryAttributes(IMFAttributes** ppAttributes);

        [VtblIndex(4)]
        HRESULT InitializeFactory([NativeTypeName("DWORD")] uint dwMaxTransformCount, IMFCollection* pSensorDevices, IMFAttributes* pAttributes);

        [VtblIndex(5)]
        HRESULT GetTransformCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(6)]
        HRESULT GetTransformInformation([NativeTypeName("DWORD")] uint TransformIndex, Guid* pguidTransformId, IMFAttributes** ppAttributes, IMFCollection** ppStreamInformation);

        [VtblIndex(7)]
        HRESULT CreateTransform([NativeTypeName("const GUID &")] Guid* guidSensorTransformID, IMFAttributes* pAttributes, IMFDeviceTransform** ppDeviceMFT);
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

        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes**, int> GetFactoryAttributes;

        [NativeTypeName("HRESULT (DWORD, IMFCollection *, IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFCollection*, IMFAttributes*, int> InitializeFactory;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTransformCount;

        [NativeTypeName("HRESULT (DWORD, GUID *, IMFAttributes **, IMFCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, IMFAttributes**, IMFCollection**, int> GetTransformInformation;

        [NativeTypeName("HRESULT (const GUID &, IMFAttributes *, IMFDeviceTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IMFAttributes*, IMFDeviceTransform**, int> CreateTransform;
    }
}
