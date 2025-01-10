// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B5CF2CFA-8AEB-11D1-9364-0060B067B86E")]
[NativeTypeName("struct IActiveIMMMessagePumpOwner : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActiveIMMMessagePumpOwner
    : IActiveIMMMessagePumpOwner.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveIMMMessagePumpOwner));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IActiveIMMMessagePumpOwner, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT End()
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnTranslateMessage([NativeTypeName("const MSG *")] MSG* pMsg)
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner, MSG*, int>)((*lpVtbl)[5]))(
            this,
            pMsg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Pause([NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner, uint*, int>)((*lpVtbl)[6]))(
            this,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Resume([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IActiveIMMMessagePumpOwner, uint, int>)((*lpVtbl)[7]))(
            this,
            dwCookie
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Start();

        [VtblIndex(4)]
        HRESULT End();

        [VtblIndex(5)]
        HRESULT OnTranslateMessage([NativeTypeName("const MSG *")] MSG* pMsg);

        [VtblIndex(6)]
        HRESULT Pause([NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(7)]
        HRESULT Resume([NativeTypeName("DWORD")] uint dwCookie);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> End;

        [NativeTypeName("HRESULT (const MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> OnTranslateMessage;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> Pause;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Resume;
    }

    /// <summary>Initializes a new instance of the <see cref = "IActiveIMMMessagePumpOwner"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IActiveIMMMessagePumpOwner(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IActiveIMMMessagePumpOwner"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IActiveIMMMessagePumpOwner(Silk.NET.Windows.IUnknown value)
    {
        return new IActiveIMMMessagePumpOwner(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActiveIMMMessagePumpOwner"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IActiveIMMMessagePumpOwner"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IActiveIMMMessagePumpOwner value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
