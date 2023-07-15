// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpSerializeState.xml' path='doc/member[@name="ISpSerializeState"]/*'/>
[Guid("21B501A0-0EC7-46C9-92C3-A2BC784C54B9")]
[NativeTypeName("struct ISpSerializeState : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpSerializeState : ISpSerializeState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpSerializeState));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpSerializeState*, Guid*, void**, int> )(lpVtbl[0]))((ISpSerializeState*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpSerializeState*, uint> )(lpVtbl[1]))((ISpSerializeState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpSerializeState*, uint> )(lpVtbl[2]))((ISpSerializeState*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpSerializeState.xml' path='doc/member[@name="ISpSerializeState.GetSerializedState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSerializedState(byte** ppbData, [NativeTypeName("ULONG *")] uint* pulSize, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISpSerializeState*, byte**, uint*, uint, int> )(lpVtbl[3]))((ISpSerializeState*)Unsafe.AsPointer(ref this), ppbData, pulSize, dwReserved);
    }

    /// <include file='ISpSerializeState.xml' path='doc/member[@name="ISpSerializeState.SetSerializedState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSerializedState(byte* pbData, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISpSerializeState*, byte*, uint, uint, int> )(lpVtbl[4]))((ISpSerializeState*)Unsafe.AsPointer(ref this), pbData, ulSize, dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSerializedState(byte** ppbData, [NativeTypeName("ULONG *")] uint* pulSize, [NativeTypeName("DWORD")] uint dwReserved);
        [VtblIndex(4)]
        HRESULT SetSerializedState(byte* pbData, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("DWORD")] uint dwReserved);
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
        [NativeTypeName("HRESULT (BYTE **, ULONG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, uint, int> GetSerializedState;
        [NativeTypeName("HRESULT (BYTE *, ULONG, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint, int> SetSerializedState;
    }
}