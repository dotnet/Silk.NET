// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("858F956A-972F-42A2-A2F2-0321E1ABE209")]
[NativeTypeName("struct ITfTransitoryExtensionUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfTransitoryExtensionUIElement
    : ITfTransitoryExtensionUIElement.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfTransitoryExtensionUIElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfTransitoryExtensionUIElement, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfTransitoryExtensionUIElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfTransitoryExtensionUIElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return (
            (delegate* unmanaged<ITfTransitoryExtensionUIElement, ushort**, int>)((*lpVtbl)[3])
        )(this, pbstrDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfTransitoryExtensionUIElement, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfTransitoryExtensionUIElement, BOOL, int>)((*lpVtbl)[5]))(
            this,
            bShow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfTransitoryExtensionUIElement, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pbShow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDocumentMgr(ITfDocumentMgr* ppdim)
    {
        return (
            (delegate* unmanaged<ITfTransitoryExtensionUIElement, ITfDocumentMgr*, int>)(
                (*lpVtbl)[7]
            )
        )(this, ppdim);
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetDocumentMgr(ITfDocumentMgr* ppdim);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsShown;

        [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, int> GetDocumentMgr;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfTransitoryExtensionUIElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfTransitoryExtensionUIElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfUIElement"/> to <see cref = "ITfTransitoryExtensionUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfUIElement"/> instance to be converted </param>
    public static explicit operator ITfTransitoryExtensionUIElement(
        Silk.NET.Windows.ITfUIElement value
    )
    {
        return new ITfTransitoryExtensionUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfTransitoryExtensionUIElement"/> to <see cref = "Silk.NET.Windows.ITfUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "ITfTransitoryExtensionUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfUIElement(
        ITfTransitoryExtensionUIElement value
    )
    {
        return new Silk.NET.Windows.ITfUIElement(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfTransitoryExtensionUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfTransitoryExtensionUIElement(Silk.NET.Windows.IUnknown value)
    {
        return new ITfTransitoryExtensionUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfTransitoryExtensionUIElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfTransitoryExtensionUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfTransitoryExtensionUIElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
