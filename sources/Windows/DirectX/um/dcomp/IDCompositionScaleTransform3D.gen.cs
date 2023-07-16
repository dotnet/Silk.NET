// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D"]/*'/>
[Guid("2A9E9EAD-364B-4B15-A7C4-A1997F78B389")]
[NativeTypeName("struct IDCompositionScaleTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionScaleTransform3D : IDCompositionScaleTransform3D.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionScaleTransform3D));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, uint> )(lpVtbl[1]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, uint> )(lpVtbl[2]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetScaleX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetScaleX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[3]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetScaleX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetScaleX(float scaleX)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> )(lpVtbl[4]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleX);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetScaleY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetScaleY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[5]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetScaleY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetScaleY(float scaleY)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> )(lpVtbl[6]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleY);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetScaleZ"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetScaleZ(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[7]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetScaleZ"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetScaleZ(float scaleZ)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> )(lpVtbl[8]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleZ);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetCenterX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetCenterX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[9]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetCenterX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCenterX(float centerX)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> )(lpVtbl[10]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerX);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetCenterY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetCenterY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[11]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetCenterY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetCenterY(float centerY)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> )(lpVtbl[12]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerY);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetCenterZ"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCenterZ(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> )(lpVtbl[13]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform3D.xml' path='doc/member[@name="IDCompositionScaleTransform3D.SetCenterZ"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCenterZ(float centerZ)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> )(lpVtbl[14]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerZ);
    }

    public interface Interface : IDCompositionTransform3D.Interface
    {
        [VtblIndex(3)]
        HRESULT SetScaleX(IDCompositionAnimation* animation);
        [VtblIndex(4)]
        HRESULT SetScaleX(float scaleX);
        [VtblIndex(5)]
        HRESULT SetScaleY(IDCompositionAnimation* animation);
        [VtblIndex(6)]
        HRESULT SetScaleY(float scaleY);
        [VtblIndex(7)]
        HRESULT SetScaleZ(IDCompositionAnimation* animation);
        [VtblIndex(8)]
        HRESULT SetScaleZ(float scaleZ);
        [VtblIndex(9)]
        HRESULT SetCenterX(IDCompositionAnimation* animation);
        [VtblIndex(10)]
        HRESULT SetCenterX(float centerX);
        [VtblIndex(11)]
        HRESULT SetCenterY(IDCompositionAnimation* animation);
        [VtblIndex(12)]
        HRESULT SetCenterY(float centerY);
        [VtblIndex(13)]
        HRESULT SetCenterZ(IDCompositionAnimation* animation);
        [VtblIndex(14)]
        HRESULT SetCenterZ(float centerZ);
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
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetScaleX;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetScaleX1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetScaleY;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetScaleY1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetScaleZ;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetScaleZ1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCenterX;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCenterX1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCenterY;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCenterY1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCenterZ;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCenterZ1;
    }
}