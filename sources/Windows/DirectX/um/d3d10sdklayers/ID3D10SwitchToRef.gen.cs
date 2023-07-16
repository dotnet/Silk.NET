// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D10SwitchToRef.xml' path='doc/member[@name="ID3D10SwitchToRef"]/*'/>
[Guid("9B7E4E02-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10SwitchToRef : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10SwitchToRef : ID3D10SwitchToRef.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10SwitchToRef));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10SwitchToRef*, Guid*, void**, int> )(lpVtbl[0]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10SwitchToRef*, uint> )(lpVtbl[1]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10SwitchToRef*, uint> )(lpVtbl[2]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10SwitchToRef.xml' path='doc/member[@name="ID3D10SwitchToRef.SetUseRef"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL SetUseRef(BOOL UseRef)
    {
        return ((delegate* unmanaged<ID3D10SwitchToRef*, BOOL, int> )(lpVtbl[3]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this), UseRef);
    }

    /// <include file='ID3D10SwitchToRef.xml' path='doc/member[@name="ID3D10SwitchToRef.GetUseRef"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL GetUseRef()
    {
        return ((delegate* unmanaged<ID3D10SwitchToRef*, int> )(lpVtbl[4]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL SetUseRef(BOOL UseRef);
        [VtblIndex(4)]
        BOOL GetUseRef();
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
        [NativeTypeName("BOOL (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetUseRef;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetUseRef;
    }
}