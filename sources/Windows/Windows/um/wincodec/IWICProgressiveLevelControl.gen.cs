// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICProgressiveLevelControl.xml' path='doc/member[@name="IWICProgressiveLevelControl"]/*'/>
[Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
[NativeTypeName("struct IWICProgressiveLevelControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICProgressiveLevelControl : IWICProgressiveLevelControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICProgressiveLevelControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl*, Guid*, void**, int> )(lpVtbl[0]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint> )(lpVtbl[1]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint> )(lpVtbl[2]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICProgressiveLevelControl.xml' path='doc/member[@name="IWICProgressiveLevelControl.GetLevelCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLevelCount(uint* pcLevels)
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint*, int> )(lpVtbl[3]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pcLevels);
    }

    /// <include file='IWICProgressiveLevelControl.xml' path='doc/member[@name="IWICProgressiveLevelControl.GetCurrentLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentLevel(uint* pnLevel)
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint*, int> )(lpVtbl[4]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pnLevel);
    }

    /// <include file='IWICProgressiveLevelControl.xml' path='doc/member[@name="IWICProgressiveLevelControl.SetCurrentLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCurrentLevel(uint nLevel)
    {
        return ((delegate* unmanaged<IWICProgressiveLevelControl*, uint, int> )(lpVtbl[5]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), nLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLevelCount(uint* pcLevels);
        [VtblIndex(4)]
        HRESULT GetCurrentLevel(uint* pnLevel);
        [VtblIndex(5)]
        HRESULT SetCurrentLevel(uint nLevel);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLevelCount;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentLevel;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentLevel;
    }
}