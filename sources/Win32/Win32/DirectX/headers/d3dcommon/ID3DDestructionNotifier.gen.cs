// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier"]/*'/>
[Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
[NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DDestructionNotifier
    : ID3DDestructionNotifier.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3DDestructionNotifier));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(lpVtbl[1]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, uint>)(lpVtbl[2]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.RegisterDestructionCallback"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterDestructionCallback(
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
                int>)(lpVtbl[3])
        )((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
    }

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.UnregisterDestructionCallback"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterDestructionCallback(uint callbackID)
    {
        return ((delegate* unmanaged<ID3DDestructionNotifier*, uint, int>)(lpVtbl[4]))(
            (ID3DDestructionNotifier*)Unsafe.AsPointer(ref this),
            callbackID
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HRESULT UnregisterDestructionCallback(uint callbackID);
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

        [NativeTypeName(
            "HRESULT (PFN_DESTRUCTION_CALLBACK, void *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<void*, void>,
            void*,
            uint*,
            int> RegisterDestructionCallback;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnregisterDestructionCallback;
    }
}
