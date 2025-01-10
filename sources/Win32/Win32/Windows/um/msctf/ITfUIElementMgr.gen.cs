// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EA1EA135-19DF-11D7-A6D2-00065B84435C")]
[NativeTypeName("struct ITfUIElementMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfUIElementMgr : ITfUIElementMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfUIElementMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfUIElementMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfUIElementMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfUIElementMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginUIElement(
        ITfUIElement pElement,
        BOOL* pbShow,
        [NativeTypeName("DWORD *")] uint* pdwUIElementId
    )
    {
        return (
            (delegate* unmanaged<ITfUIElementMgr, ITfUIElement, BOOL*, uint*, int>)((*lpVtbl)[3])
        )(this, pElement, pbShow, pdwUIElementId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
    {
        return ((delegate* unmanaged<ITfUIElementMgr, uint, int>)((*lpVtbl)[4]))(
            this,
            dwUIElementId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
    {
        return ((delegate* unmanaged<ITfUIElementMgr, uint, int>)((*lpVtbl)[5]))(
            this,
            dwUIElementId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetUIElement(
        [NativeTypeName("DWORD")] uint dwUIELementId,
        ITfUIElement* ppElement
    )
    {
        return ((delegate* unmanaged<ITfUIElementMgr, uint, ITfUIElement*, int>)((*lpVtbl)[6]))(
            this,
            dwUIELementId,
            ppElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumUIElements(IEnumTfUIElements* ppEnum)
    {
        return ((delegate* unmanaged<ITfUIElementMgr, IEnumTfUIElements*, int>)((*lpVtbl)[7]))(
            this,
            ppEnum
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginUIElement(
            ITfUIElement pElement,
            BOOL* pbShow,
            [NativeTypeName("DWORD *")] uint* pdwUIElementId
        );

        [VtblIndex(4)]
        HRESULT UpdateUIElement([NativeTypeName("DWORD")] uint dwUIElementId);

        [VtblIndex(5)]
        HRESULT EndUIElement([NativeTypeName("DWORD")] uint dwUIElementId);

        [VtblIndex(6)]
        HRESULT GetUIElement([NativeTypeName("DWORD")] uint dwUIELementId, ITfUIElement* ppElement);

        [VtblIndex(7)]
        HRESULT EnumUIElements(IEnumTfUIElements* ppEnum);
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

        [NativeTypeName("HRESULT (ITfUIElement *, BOOL *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfUIElement, BOOL*, uint*, int> BeginUIElement;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UpdateUIElement;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> EndUIElement;

        [NativeTypeName("HRESULT (DWORD, ITfUIElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfUIElement*, int> GetUIElement;

        [NativeTypeName("HRESULT (IEnumTfUIElements **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfUIElements*, int> EnumUIElements;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfUIElementMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfUIElementMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfUIElementMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfUIElementMgr(Silk.NET.Windows.IUnknown value)
    {
        return new ITfUIElementMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfUIElementMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfUIElementMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfUIElementMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
