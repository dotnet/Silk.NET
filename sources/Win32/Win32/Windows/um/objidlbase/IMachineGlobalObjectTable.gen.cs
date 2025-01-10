// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("26D709AC-F70B-4421-A96F-D2878FAFB00D")]
[NativeTypeName("struct IMachineGlobalObjectTable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMachineGlobalObjectTable
    : IMachineGlobalObjectTable.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMachineGlobalObjectTable));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMachineGlobalObjectTable, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterObject(
        [NativeTypeName("const IID &")] Guid* clsid,
        [NativeTypeName("LPCWSTR")] ushort* identifier,
        IUnknown @object,
        MachineGlobalObjectTableRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMachineGlobalObjectTable,
                Guid*,
                ushort*,
                IUnknown,
                MachineGlobalObjectTableRegistrationToken*,
                int>)((*lpVtbl)[3])
        )(this, clsid, identifier, @object, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetObjectW(
        [NativeTypeName("const IID &")] Guid* clsid,
        [NativeTypeName("LPCWSTR")] ushort* identifier,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IMachineGlobalObjectTable, Guid*, ushort*, Guid*, void**, int>)(
                (*lpVtbl)[4]
            )
        )(this, clsid, identifier, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RevokeObject(MachineGlobalObjectTableRegistrationToken token)
    {
        return (
            (delegate* unmanaged<
                IMachineGlobalObjectTable,
                MachineGlobalObjectTableRegistrationToken,
                int>)((*lpVtbl)[5])
        )(this, token);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterObject(
            [NativeTypeName("const IID &")] Guid* clsid,
            [NativeTypeName("LPCWSTR")] ushort* identifier,
            IUnknown @object,
            MachineGlobalObjectTableRegistrationToken* token
        );

        [VtblIndex(4)]
        HRESULT GetObjectW(
            [NativeTypeName("const IID &")] Guid* clsid,
            [NativeTypeName("LPCWSTR")] ushort* identifier,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(5)]
        HRESULT RevokeObject(MachineGlobalObjectTableRegistrationToken token);
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
            "HRESULT (const IID &, LPCWSTR, IUnknown *, MachineGlobalObjectTableRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort*,
            IUnknown,
            MachineGlobalObjectTableRegistrationToken*,
            int> RegisterObject;

        [NativeTypeName(
            "HRESULT (const IID &, LPCWSTR, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, void**, int> GetObjectW;

        [NativeTypeName(
            "HRESULT (MachineGlobalObjectTableRegistrationToken) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MachineGlobalObjectTableRegistrationToken,
            int> RevokeObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMachineGlobalObjectTable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMachineGlobalObjectTable(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMachineGlobalObjectTable"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMachineGlobalObjectTable(Silk.NET.Windows.IUnknown value)
    {
        return new IMachineGlobalObjectTable(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMachineGlobalObjectTable"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMachineGlobalObjectTable"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMachineGlobalObjectTable value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
