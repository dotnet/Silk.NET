// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F0A56423-A664-4FBD-8B43-409A45E8D9A1")]
[NativeTypeName("struct ICastingController : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICastingController : ICastingController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICastingController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICastingController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICastingController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IUnknown castingEngine, IUnknown castingSource)
    {
        return ((delegate* unmanaged<ICastingController, IUnknown, IUnknown, int>)((*lpVtbl)[3]))(
            this,
            castingEngine,
            castingSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Connect()
    {
        return ((delegate* unmanaged<ICastingController, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<ICastingController, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Advise(
        ICastingEventHandler eventHandler,
        [NativeTypeName("DWORD *")] uint* cookie
    )
    {
        return (
            (delegate* unmanaged<ICastingController, ICastingEventHandler, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, eventHandler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnAdvise([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<ICastingController, uint, int>)((*lpVtbl)[7]))(this, cookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IUnknown castingEngine, IUnknown castingSource);

        [VtblIndex(4)]
        HRESULT Connect();

        [VtblIndex(5)]
        HRESULT Disconnect();

        [VtblIndex(6)]
        HRESULT Advise(ICastingEventHandler eventHandler, [NativeTypeName("DWORD *")] uint* cookie);

        [VtblIndex(7)]
        HRESULT UnAdvise([NativeTypeName("DWORD")] uint cookie);
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

        [NativeTypeName("HRESULT (IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, IUnknown, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Connect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;

        [NativeTypeName("HRESULT (ICastingEventHandler *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICastingEventHandler, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnAdvise;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICastingController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICastingController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICastingController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICastingController(Silk.NET.Windows.IUnknown value)
    {
        return new ICastingController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICastingController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICastingController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICastingController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
