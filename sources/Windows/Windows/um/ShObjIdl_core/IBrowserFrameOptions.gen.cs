// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IBrowserFrameOptions.xml' path='doc/member[@name="IBrowserFrameOptions"]/*'/>
[Guid("10DF43C8-1DBE-11D3-8B34-006097DF5BD4")]
[NativeTypeName("struct IBrowserFrameOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBrowserFrameOptions : IBrowserFrameOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrowserFrameOptions));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, Guid*, void**, int> )(lpVtbl[0]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, uint> )(lpVtbl[1]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, uint> )(lpVtbl[2]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBrowserFrameOptions.xml' path='doc/member[@name="IBrowserFrameOptions.GetFrameOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFrameOptions([NativeTypeName("BROWSERFRAMEOPTIONS")] uint dwMask, [NativeTypeName("BROWSERFRAMEOPTIONS *")] uint* pdwOptions)
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, uint, uint*, int> )(lpVtbl[3]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this), dwMask, pdwOptions);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFrameOptions([NativeTypeName("BROWSERFRAMEOPTIONS")] uint dwMask, [NativeTypeName("BROWSERFRAMEOPTIONS *")] uint* pdwOptions);
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
        [NativeTypeName("HRESULT (BROWSERFRAMEOPTIONS, BROWSERFRAMEOPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetFrameOptions;
    }
}