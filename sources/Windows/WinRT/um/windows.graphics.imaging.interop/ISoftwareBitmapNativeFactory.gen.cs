// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='ISoftwareBitmapNativeFactory.xml' path='doc/member[@name="ISoftwareBitmapNativeFactory"]/*'/>
[Guid("C3C181EC-2914-4791-AF02-02D224A10B43")]
[NativeTypeName("struct ISoftwareBitmapNativeFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmapNativeFactory : ISoftwareBitmapNativeFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmapNativeFactory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, Guid*, void**, int> )(lpVtbl[0]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, uint> )(lpVtbl[1]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, uint> )(lpVtbl[2]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, uint*, Guid**, int> )(lpVtbl[3]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, HSTRING*, int> )(lpVtbl[4]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, TrustLevel*, int> )(lpVtbl[5]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISoftwareBitmapNativeFactory.xml' path='doc/member[@name="ISoftwareBitmapNativeFactory.CreateFromWICBitmap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromWICBitmap(IWICBitmap* data, BOOL forceReadOnly, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, IWICBitmap*, BOOL, Guid*, void**, int> )(lpVtbl[6]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), data, forceReadOnly, riid, ppv);
    }

    /// <include file='ISoftwareBitmapNativeFactory.xml' path='doc/member[@name="ISoftwareBitmapNativeFactory.CreateFromMF2DBuffer2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromMF2DBuffer2(IMF2DBuffer2* data, [NativeTypeName("const GUID &")] Guid* subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, BOOL forceReadOnly, [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory*, IMF2DBuffer2*, Guid*, uint, uint, BOOL, MFVideoArea*, Guid*, void**, int> )(lpVtbl[7]))((ISoftwareBitmapNativeFactory*)Unsafe.AsPointer(ref this), data, subtype, width, height, forceReadOnly, minDisplayAperture, riid, ppv);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromWICBitmap(IWICBitmap* data, BOOL forceReadOnly, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
        [VtblIndex(7)]
        HRESULT CreateFromMF2DBuffer2(IMF2DBuffer2* data, [NativeTypeName("const GUID &")] Guid* subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, BOOL forceReadOnly, [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
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
        [NativeTypeName("HRESULT (IWICBitmap *, BOOL, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmap*, BOOL, Guid*, void**, int> CreateFromWICBitmap;
        [NativeTypeName("HRESULT (IMF2DBuffer2 *, const GUID &, UINT32, UINT32, BOOL, const MFVideoArea *, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMF2DBuffer2*, Guid*, uint, uint, BOOL, MFVideoArea*, Guid*, void**, int> CreateFromMF2DBuffer2;
    }
}