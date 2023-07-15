// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl"]/*'/>
[Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
[NativeTypeName("struct IDXGIDisplayControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIDisplayControl : IDXGIDisplayControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDisplayControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDisplayControl*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIDisplayControl*, uint> )(lpVtbl[1]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDisplayControl*, uint> )(lpVtbl[2]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl.IsStereoEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL IsStereoEnabled()
    {
        return ((delegate* unmanaged<IDXGIDisplayControl*, int> )(lpVtbl[3]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIDisplayControl.xml' path='doc/member[@name="IDXGIDisplayControl.SetStereoEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetStereoEnabled(BOOL enabled)
    {
        ((delegate* unmanaged<IDXGIDisplayControl*, BOOL, void> )(lpVtbl[4]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), enabled);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL IsStereoEnabled();
        [VtblIndex(4)]
        void SetStereoEnabled(BOOL enabled);
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
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsStereoEnabled;
        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetStereoEnabled;
    }
}