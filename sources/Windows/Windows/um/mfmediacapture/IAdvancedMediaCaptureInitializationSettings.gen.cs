// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAdvancedMediaCaptureInitializationSettings.xml' path='doc/member[@name="IAdvancedMediaCaptureInitializationSettings"]/*' />
[Guid("3DE21209-8BA6-4F2A-A577-2819B56FF14D")]
[NativeTypeName("struct IAdvancedMediaCaptureInitializationSettings : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAdvancedMediaCaptureInitializationSettings : IAdvancedMediaCaptureInitializationSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedMediaCaptureInitializationSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, uint>)(lpVtbl[1]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, uint>)(lpVtbl[2]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAdvancedMediaCaptureInitializationSettings.xml' path='doc/member[@name="IAdvancedMediaCaptureInitializationSettings.SetDirectxDeviceManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDirectxDeviceManager(IMFDXGIDeviceManager* value)
    {
        return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, IMFDXGIDeviceManager*, int>)(lpVtbl[3]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDirectxDeviceManager(IMFDXGIDeviceManager* value);
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

        [NativeTypeName("HRESULT (IMFDXGIDeviceManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFDXGIDeviceManager*, int> SetDirectxDeviceManager;
    }
}
