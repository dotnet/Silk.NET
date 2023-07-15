// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IVMRVideoStreamControl.xml' path='doc/member[@name="IVMRVideoStreamControl"]/*'/>
[Guid("058D1F11-2A54-4BEF-BD54-DF706626B727")]
[NativeTypeName("struct IVMRVideoStreamControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRVideoStreamControl : IVMRVideoStreamControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRVideoStreamControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRVideoStreamControl*, Guid*, void**, int> )(lpVtbl[0]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRVideoStreamControl*, uint> )(lpVtbl[1]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRVideoStreamControl*, uint> )(lpVtbl[2]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRVideoStreamControl.xml' path='doc/member[@name="IVMRVideoStreamControl.SetColorKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetColorKey([NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* lpClrKey)
    {
        return ((delegate* unmanaged<IVMRVideoStreamControl*, DDCOLORKEY*, int> )(lpVtbl[3]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), lpClrKey);
    }

    /// <include file='IVMRVideoStreamControl.xml' path='doc/member[@name="IVMRVideoStreamControl.GetColorKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetColorKey([NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* lpClrKey)
    {
        return ((delegate* unmanaged<IVMRVideoStreamControl*, DDCOLORKEY*, int> )(lpVtbl[4]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), lpClrKey);
    }

    /// <include file='IVMRVideoStreamControl.xml' path='doc/member[@name="IVMRVideoStreamControl.SetStreamActiveState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStreamActiveState(BOOL fActive)
    {
        return ((delegate* unmanaged<IVMRVideoStreamControl*, BOOL, int> )(lpVtbl[5]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), fActive);
    }

    /// <include file='IVMRVideoStreamControl.xml' path='doc/member[@name="IVMRVideoStreamControl.GetStreamActiveState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStreamActiveState(BOOL* lpfActive)
    {
        return ((delegate* unmanaged<IVMRVideoStreamControl*, BOOL*, int> )(lpVtbl[6]))((IVMRVideoStreamControl*)Unsafe.AsPointer(ref this), lpfActive);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetColorKey([NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* lpClrKey);
        [VtblIndex(4)]
        HRESULT GetColorKey([NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* lpClrKey);
        [VtblIndex(5)]
        HRESULT SetStreamActiveState(BOOL fActive);
        [VtblIndex(6)]
        HRESULT GetStreamActiveState(BOOL* lpfActive);
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
        [NativeTypeName("HRESULT (LPDDCOLORKEY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCOLORKEY*, int> SetColorKey;
        [NativeTypeName("HRESULT (LPDDCOLORKEY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCOLORKEY*, int> GetColorKey;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetStreamActiveState;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetStreamActiveState;
    }
}