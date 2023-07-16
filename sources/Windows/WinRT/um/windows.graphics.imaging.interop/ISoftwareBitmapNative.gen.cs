// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ISoftwareBitmapNative.xml' path='doc/member[@name="ISoftwareBitmapNative"]/*'/>
[Guid("94BC8415-04EA-4B2E-AF13-4DE95AA898EB")]
[NativeTypeName("struct ISoftwareBitmapNative : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmapNative : ISoftwareBitmapNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmapNative));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNative*, Guid*, void**, int> )(lpVtbl[0]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISoftwareBitmapNative*, uint> )(lpVtbl[1]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISoftwareBitmapNative*, uint> )(lpVtbl[2]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNative*, uint*, Guid**, int> )(lpVtbl[3]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNative*, HSTRING*, int> )(lpVtbl[4]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNative*, TrustLevel*, int> )(lpVtbl[5]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISoftwareBitmapNative.xml' path='doc/member[@name="ISoftwareBitmapNative.GetData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetData([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNative*, Guid*, void**, int> )(lpVtbl[6]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetData([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
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
        [NativeTypeName("HRESULT (const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetData;
    }
}