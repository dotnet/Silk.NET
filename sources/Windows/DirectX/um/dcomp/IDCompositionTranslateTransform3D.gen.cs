// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDCompositionTranslateTransform3D.xml' path='doc/member[@name="IDCompositionTranslateTransform3D"]/*'/>
[Guid("91636D4B-9BA1-4532-AAF7-E3344994D788")]
[NativeTypeName("struct IDCompositionTranslateTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionTranslateTransform3D : IDCompositionTranslateTransform3D.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTranslateTransform3D));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, uint> )(lpVtbl[1]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, uint> )(lpVtbl[2]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionTranslateTransform3D.xml' path='doc/member[@name="IDCompositionTranslateTransform3D.SetOffsetX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOffsetX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[3]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionTranslateTransform3D.xml' path='doc/member[@name="IDCompositionTranslateTransform3D.SetOffsetX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOffsetX(float offsetX)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, float, int> )(lpVtbl[4]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetX);
    }

    /// <include file='IDCompositionTranslateTransform3D.xml' path='doc/member[@name="IDCompositionTranslateTransform3D.SetOffsetY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOffsetY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[5]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionTranslateTransform3D.xml' path='doc/member[@name="IDCompositionTranslateTransform3D.SetOffsetY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetOffsetY(float offsetY)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, float, int> )(lpVtbl[6]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetY);
    }

    /// <include file='IDCompositionTranslateTransform3D.xml' path='doc/member[@name="IDCompositionTranslateTransform3D.SetOffsetZ"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetOffsetZ(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[7]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionTranslateTransform3D.xml' path='doc/member[@name="IDCompositionTranslateTransform3D.SetOffsetZ"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetOffsetZ(float offsetZ)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, float, int> )(lpVtbl[8]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetZ);
    }

    public interface Interface : IDCompositionTransform3D.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOffsetX(IDCompositionAnimation* animation);
        [VtblIndex(4)]
        HRESULT SetOffsetX(float offsetX);
        [VtblIndex(5)]
        HRESULT SetOffsetY(IDCompositionAnimation* animation);
        [VtblIndex(6)]
        HRESULT SetOffsetY(float offsetY);
        [VtblIndex(7)]
        HRESULT SetOffsetZ(IDCompositionAnimation* animation);
        [VtblIndex(8)]
        HRESULT SetOffsetZ(float offsetZ);
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
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetOffsetX;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOffsetX1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetOffsetY;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOffsetY1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetOffsetZ;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOffsetZ1;
    }
}