// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IActivationFactory.xml' path='doc/member[@name="IActivationFactory"]/*'/>
[Guid("00000035-0000-0000-C000-000000000046")]
[NativeTypeName("struct IActivationFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivationFactory : IActivationFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivationFactory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActivationFactory*, Guid*, void**, int> )(lpVtbl[0]))((IActivationFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActivationFactory*, uint> )(lpVtbl[1]))((IActivationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActivationFactory*, uint> )(lpVtbl[2]))((IActivationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IActivationFactory*, uint*, Guid**, int> )(lpVtbl[3]))((IActivationFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IActivationFactory*, HSTRING*, int> )(lpVtbl[4]))((IActivationFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IActivationFactory*, TrustLevel*, int> )(lpVtbl[5]))((IActivationFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActivationFactory.xml' path='doc/member[@name="IActivationFactory.ActivateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ActivateInstance(IInspectable** instance)
    {
        return ((delegate* unmanaged<IActivationFactory*, IInspectable**, int> )(lpVtbl[6]))((IActivationFactory*)Unsafe.AsPointer(ref this), instance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ActivateInstance(IInspectable** instance);
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
        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable**, int> ActivateInstance;
    }
}