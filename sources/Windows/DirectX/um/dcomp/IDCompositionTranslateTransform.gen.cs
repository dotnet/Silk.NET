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
/// <include file='IDCompositionTranslateTransform.xml' path='doc/member[@name="IDCompositionTranslateTransform"]/*'/>
[Guid("06791122-C6F0-417D-8323-269E987F5954")]
[NativeTypeName("struct IDCompositionTranslateTransform : IDCompositionTransform")]
[NativeInheritance("IDCompositionTransform")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionTranslateTransform : IDCompositionTranslateTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTranslateTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform*, uint> )(lpVtbl[1]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform*, uint> )(lpVtbl[2]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionTranslateTransform.xml' path='doc/member[@name="IDCompositionTranslateTransform.SetOffsetX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOffsetX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int> )(lpVtbl[3]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionTranslateTransform.xml' path='doc/member[@name="IDCompositionTranslateTransform.SetOffsetX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOffsetX(float offsetX)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform*, float, int> )(lpVtbl[4]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetX);
    }

    /// <include file='IDCompositionTranslateTransform.xml' path='doc/member[@name="IDCompositionTranslateTransform.SetOffsetY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOffsetY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int> )(lpVtbl[5]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionTranslateTransform.xml' path='doc/member[@name="IDCompositionTranslateTransform.SetOffsetY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetOffsetY(float offsetY)
    {
        return ((delegate* unmanaged<IDCompositionTranslateTransform*, float, int> )(lpVtbl[6]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetY);
    }

    public interface Interface : IDCompositionTransform.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOffsetX(IDCompositionAnimation* animation);
        [VtblIndex(4)]
        HRESULT SetOffsetX(float offsetX);
        [VtblIndex(5)]
        HRESULT SetOffsetY(IDCompositionAnimation* animation);
        [VtblIndex(6)]
        HRESULT SetOffsetY(float offsetY);
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
    }
}