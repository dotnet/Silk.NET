// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IUserActivitySourceHostInterop.xml' path='doc/member[@name="IUserActivitySourceHostInterop"]/*'/>
[Guid("C15DF8BC-8844-487A-B85B-7578E0F61419")]
[NativeTypeName("struct IUserActivitySourceHostInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserActivitySourceHostInterop : IUserActivitySourceHostInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserActivitySourceHostInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserActivitySourceHostInterop*, Guid*, void**, int> )(lpVtbl[0]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserActivitySourceHostInterop*, uint> )(lpVtbl[1]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserActivitySourceHostInterop*, uint> )(lpVtbl[2]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IUserActivitySourceHostInterop*, uint*, Guid**, int> )(lpVtbl[3]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserActivitySourceHostInterop*, HSTRING*, int> )(lpVtbl[4]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserActivitySourceHostInterop*, TrustLevel*, int> )(lpVtbl[5]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserActivitySourceHostInterop.xml' path='doc/member[@name="IUserActivitySourceHostInterop.SetActivitySourceHost"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetActivitySourceHost(HSTRING activitySourceHost)
    {
        return ((delegate* unmanaged<IUserActivitySourceHostInterop*, HSTRING, int> )(lpVtbl[6]))((IUserActivitySourceHostInterop*)Unsafe.AsPointer(ref this), activitySourceHost);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetActivitySourceHost(HSTRING activitySourceHost);
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
        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> SetActivitySourceHost;
    }
}