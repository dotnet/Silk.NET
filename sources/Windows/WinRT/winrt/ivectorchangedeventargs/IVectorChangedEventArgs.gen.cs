// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/ivectorchangedeventargs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IVectorChangedEventArgs.xml' path='doc/member[@name="IVectorChangedEventArgs"]/*'/>
[Guid("575933DF-34FE-4480-AF15-07691F3D5D9B")]
[NativeTypeName("struct IVectorChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVectorChangedEventArgs : IVectorChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVectorChangedEventArgs));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, Guid*, void**, int> )(lpVtbl[0]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, uint> )(lpVtbl[1]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, uint> )(lpVtbl[2]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, uint*, Guid**, int> )(lpVtbl[3]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, HSTRING*, int> )(lpVtbl[4]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, TrustLevel*, int> )(lpVtbl[5]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVectorChangedEventArgs.xml' path='doc/member[@name="IVectorChangedEventArgs.get_CollectionChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CollectionChange([NativeTypeName("ABI::Windows::Foundation::Collections::CollectionChange *")] CollectionChange* value)
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, CollectionChange*, int> )(lpVtbl[6]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVectorChangedEventArgs.xml' path='doc/member[@name="IVectorChangedEventArgs.get_Index"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Index([NativeTypeName("unsigned int *")] uint* value)
    {
        return ((delegate* unmanaged<IVectorChangedEventArgs*, uint*, int> )(lpVtbl[7]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CollectionChange([NativeTypeName("ABI::Windows::Foundation::Collections::CollectionChange *")] CollectionChange* value);
        [VtblIndex(7)]
        HRESULT get_Index([NativeTypeName("unsigned int *")] uint* value);
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
        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::CollectionChange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CollectionChange*, int> get_CollectionChange;
        [NativeTypeName("HRESULT (unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Index;
    }
}