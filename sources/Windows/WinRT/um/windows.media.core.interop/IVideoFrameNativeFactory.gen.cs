// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IVideoFrameNativeFactory.xml' path='doc/member[@name="IVideoFrameNativeFactory"]/*'/>
[Guid("69E3693E-8E1E-4E63-AC4C-7FDC21D9731D")]
[NativeTypeName("struct IVideoFrameNativeFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoFrameNativeFactory : IVideoFrameNativeFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoFrameNativeFactory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoFrameNativeFactory*, Guid*, void**, int> )(lpVtbl[0]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVideoFrameNativeFactory*, uint> )(lpVtbl[1]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoFrameNativeFactory*, uint> )(lpVtbl[2]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IVideoFrameNativeFactory*, uint*, Guid**, int> )(lpVtbl[3]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVideoFrameNativeFactory*, HSTRING*, int> )(lpVtbl[4]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVideoFrameNativeFactory*, TrustLevel*, int> )(lpVtbl[5]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoFrameNativeFactory.xml' path='doc/member[@name="IVideoFrameNativeFactory.CreateFromMFSample"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromMFSample(IMFSample* data, [NativeTypeName("const GUID &")] Guid* subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, BOOL forceReadOnly, [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture, IMFDXGIDeviceManager* device, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<IVideoFrameNativeFactory*, IMFSample*, Guid*, uint, uint, BOOL, MFVideoArea*, IMFDXGIDeviceManager*, Guid*, void**, int> )(lpVtbl[6]))((IVideoFrameNativeFactory*)Unsafe.AsPointer(ref this), data, subtype, width, height, forceReadOnly, minDisplayAperture, device, riid, ppv);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromMFSample(IMFSample* data, [NativeTypeName("const GUID &")] Guid* subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, BOOL forceReadOnly, [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture, IMFDXGIDeviceManager* device, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
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
        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;
        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;
        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;
        [NativeTypeName("HRESULT (IMFSample *, const GUID &, UINT32, UINT32, BOOL, const MFVideoArea *, IMFDXGIDeviceManager *, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample*, Guid*, uint, uint, BOOL, MFVideoArea*, IMFDXGIDeviceManager*, Guid*, void**, int> CreateFromMFSample;
    }
}