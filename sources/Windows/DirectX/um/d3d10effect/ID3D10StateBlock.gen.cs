// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D10StateBlock.xml' path='doc/member[@name="ID3D10StateBlock"]/*'/>
[Guid("0803425A-57F5-4DD6-9465-A87570834A08")]
[NativeTypeName("struct ID3D10StateBlock : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10StateBlock : ID3D10StateBlock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10StateBlock));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10StateBlock*, Guid*, void**, int> )(lpVtbl[0]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10StateBlock*, uint> )(lpVtbl[1]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10StateBlock*, uint> )(lpVtbl[2]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10StateBlock.xml' path='doc/member[@name="ID3D10StateBlock.Capture"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Capture()
    {
        return ((delegate* unmanaged<ID3D10StateBlock*, int> )(lpVtbl[3]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10StateBlock.xml' path='doc/member[@name="ID3D10StateBlock.Apply"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Apply()
    {
        return ((delegate* unmanaged<ID3D10StateBlock*, int> )(lpVtbl[4]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10StateBlock.xml' path='doc/member[@name="ID3D10StateBlock.ReleaseAllDeviceObjects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReleaseAllDeviceObjects()
    {
        return ((delegate* unmanaged<ID3D10StateBlock*, int> )(lpVtbl[5]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10StateBlock.xml' path='doc/member[@name="ID3D10StateBlock.GetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDevice(ID3D10Device** ppDevice)
    {
        return ((delegate* unmanaged<ID3D10StateBlock*, ID3D10Device**, int> )(lpVtbl[6]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this), ppDevice);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Capture();
        [VtblIndex(4)]
        HRESULT Apply();
        [VtblIndex(5)]
        HRESULT ReleaseAllDeviceObjects();
        [VtblIndex(6)]
        HRESULT GetDevice(ID3D10Device** ppDevice);
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
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Capture;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Apply;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseAllDeviceObjects;
        [NativeTypeName("HRESULT (ID3D10Device **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Device**, int> GetDevice;
    }
}