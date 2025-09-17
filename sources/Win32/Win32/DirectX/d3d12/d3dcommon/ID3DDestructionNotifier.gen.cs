// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier"]/*'/>
[Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
[NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DDestructionNotifier
    : ID3DDestructionNotifier.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID.ID3DDestructionNotifier);
    public void** LpVtbl;

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult UnregisterDestructionCallback(uint callbackID);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName(
            "HRESULT (PFN_DESTRUCTION_CALLBACK, void *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<void*, void>,
            void*,
            uint*,
            HResult> RegisterDestructionCallback;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HResult> UnregisterDestructionCallback;
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(LpVtbl[1]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, HResult>)(LpVtbl[0]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.RegisterDestructionCallback"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult RegisterDestructionCallback(
        [NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn,
        void* pData,
        uint* pCallbackID
    )
    {
        return (
            (delegate* unmanaged<
                ID3DDestructionNotifier*,
                delegate* unmanaged<void*, void>,
                void*,
                uint*,
                HResult>)(LpVtbl[3])
        )((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
    }

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterDestructionCallback(
        [NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn,
        Ref pData,
        Ref<uint> pCallbackID
    )
    {
        fixed (uint* __dsl_pCallbackID = pCallbackID)
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)RegisterDestructionCallback(callbackFn, __dsl_pData, __dsl_pCallbackID);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(LpVtbl[2]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.UnregisterDestructionCallback"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult UnregisterDestructionCallback(uint callbackID)
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, uint, HResult>)(LpVtbl[4]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this),
            callbackID
        );
    }
}
