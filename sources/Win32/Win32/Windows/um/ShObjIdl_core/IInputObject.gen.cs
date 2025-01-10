// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("68284FAA-6A48-11D0-8C78-00C04FD918B4")]
[NativeTypeName("struct IInputObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInputObject : IInputObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInputObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInputObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInputObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInputObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UIActivateIO(BOOL fActivate, MSG* pMsg)
    {
        return ((delegate* unmanaged<IInputObject, BOOL, MSG*, int>)((*lpVtbl)[3]))(
            this,
            fActivate,
            pMsg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT HasFocusIO()
    {
        return ((delegate* unmanaged<IInputObject, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TranslateAcceleratorIO(MSG* pMsg)
    {
        return ((delegate* unmanaged<IInputObject, MSG*, int>)((*lpVtbl)[5]))(this, pMsg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UIActivateIO(BOOL fActivate, MSG* pMsg);

        [VtblIndex(4)]
        HRESULT HasFocusIO();

        [VtblIndex(5)]
        HRESULT TranslateAcceleratorIO(MSG* pMsg);
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

        [NativeTypeName("HRESULT (BOOL, MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, MSG*, int> UIActivateIO;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasFocusIO;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAcceleratorIO;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInputObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInputObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInputObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInputObject(Silk.NET.Windows.IUnknown value)
    {
        return new IInputObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInputObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInputObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInputObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
