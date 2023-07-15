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
/// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform"]/*'/>
[Guid("71FDE914-40EF-45EF-BD51-68B037C339F9")]
[NativeTypeName("struct IDCompositionScaleTransform : IDCompositionTransform")]
[NativeInheritance("IDCompositionTransform")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionScaleTransform : IDCompositionScaleTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionScaleTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, uint> )(lpVtbl[1]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, uint> )(lpVtbl[2]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetScaleX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetScaleX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int> )(lpVtbl[3]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetScaleX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetScaleX(float scaleX)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int> )(lpVtbl[4]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleX);
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetScaleY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetScaleY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int> )(lpVtbl[5]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetScaleY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetScaleY(float scaleY)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int> )(lpVtbl[6]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleY);
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetCenterX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCenterX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int> )(lpVtbl[7]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetCenterX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCenterX(float centerX)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int> )(lpVtbl[8]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerX);
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetCenterY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetCenterY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int> )(lpVtbl[9]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionScaleTransform.xml' path='doc/member[@name="IDCompositionScaleTransform.SetCenterY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCenterY(float centerY)
    {
        return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int> )(lpVtbl[10]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerY);
    }

    public interface Interface : IDCompositionTransform.Interface
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
        HRESULT SetCenterX(IDCompositionAnimation* animation);
        [VtblIndex(8)]
        HRESULT SetCenterX(float centerX);
        [VtblIndex(9)]
        HRESULT SetCenterY(IDCompositionAnimation* animation);
        [VtblIndex(10)]
        HRESULT SetCenterY(float centerY);
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
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCenterX;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCenterX1;
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetCenterY;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCenterY1;
    }
}