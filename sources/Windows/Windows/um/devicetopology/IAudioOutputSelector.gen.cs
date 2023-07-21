// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAudioOutputSelector.xml' path='doc/member[@name="IAudioOutputSelector"]/*' />
[Guid("BB515F69-94A7-429E-8B9C-271B3F11A3AB")]
[NativeTypeName("struct IAudioOutputSelector : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioOutputSelector : IAudioOutputSelector.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioOutputSelector));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioOutputSelector*, Guid*, void**, int>)(lpVtbl[0]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioOutputSelector*, uint>)(lpVtbl[1]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioOutputSelector*, uint>)(lpVtbl[2]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioOutputSelector.xml' path='doc/member[@name="IAudioOutputSelector.GetSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSelection(uint* pnIdSelected)
    {
        return ((delegate* unmanaged<IAudioOutputSelector*, uint*, int>)(lpVtbl[3]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this), pnIdSelected);
    }

    /// <include file='IAudioOutputSelector.xml' path='doc/member[@name="IAudioOutputSelector.SetSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSelection(uint nIdSelect, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioOutputSelector*, uint, Guid*, int>)(lpVtbl[4]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this), nIdSelect, pguidEventContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSelection(uint* pnIdSelected);

        [VtblIndex(4)]
        HRESULT SetSelection(uint nIdSelect, [NativeTypeName("LPCGUID")] Guid* pguidEventContext);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetSelection;

        [NativeTypeName("HRESULT (UINT, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> SetSelection;
    }
}
