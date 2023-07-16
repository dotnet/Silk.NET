// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1Multithread.xml' path='doc/member[@name="ID2D1Multithread"]/*'/>
[Guid("31E6E7BC-E0FF-4D46-8C64-A0A8C41C15D3")]
[NativeTypeName("struct ID2D1Multithread : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1Multithread : ID2D1Multithread.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Multithread));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Multithread*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1Multithread*, uint> )(lpVtbl[1]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Multithread*, uint> )(lpVtbl[2]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1Multithread.xml' path='doc/member[@name="ID2D1Multithread.GetMultithreadProtected"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL GetMultithreadProtected()
    {
        return ((delegate* unmanaged<ID2D1Multithread*, int> )(lpVtbl[3]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1Multithread.xml' path='doc/member[@name="ID2D1Multithread.Enter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Enter()
    {
        ((delegate* unmanaged<ID2D1Multithread*, void> )(lpVtbl[4]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1Multithread.xml' path='doc/member[@name="ID2D1Multithread.Leave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Leave()
    {
        ((delegate* unmanaged<ID2D1Multithread*, void> )(lpVtbl[5]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL GetMultithreadProtected();
        [VtblIndex(4)]
        void Enter();
        [VtblIndex(5)]
        void Leave();
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
        [NativeTypeName("BOOL () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetMultithreadProtected;
        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Enter;
        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Leave;
    }
}