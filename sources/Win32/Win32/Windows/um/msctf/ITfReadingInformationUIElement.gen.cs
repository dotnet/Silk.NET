// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EA1EA139-19DF-11D7-A6D2-00065B84435C")]
[NativeTypeName("struct ITfReadingInformationUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfReadingInformationUIElement
    : ITfReadingInformationUIElement.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfReadingInformationUIElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfReadingInformationUIElement, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, BOOL, int>)((*lpVtbl)[5]))(
            this,
            bShow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pbShow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, uint*, int>)((*lpVtbl)[7]))(
            this,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetContext(ITfContext* ppic)
    {
        return (
            (delegate* unmanaged<ITfReadingInformationUIElement, ITfContext*, int>)((*lpVtbl)[8])
        )(this, ppic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, ushort**, int>)((*lpVtbl)[9]))(
            this,
            pstr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMaxReadingStringLength(uint* pcchMax)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, uint*, int>)((*lpVtbl)[10]))(
            this,
            pcchMax
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetErrorIndex(uint* pErrorIndex)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, uint*, int>)((*lpVtbl)[11]))(
            this,
            pErrorIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsVerticalOrderPreferred(BOOL* pfVertical)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement, BOOL*, int>)((*lpVtbl)[12]))(
            this,
            pfVertical
        );
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(8)]
        HRESULT GetContext(ITfContext* ppic);

        [VtblIndex(9)]
        HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr);

        [VtblIndex(10)]
        HRESULT GetMaxReadingStringLength(uint* pcchMax);

        [VtblIndex(11)]
        HRESULT GetErrorIndex(uint* pErrorIndex);

        [VtblIndex(12)]
        HRESULT IsVerticalOrderPreferred(BOOL* pfVertical);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUpdatedFlags;

        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, int> GetContext;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetString;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxReadingStringLength;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetErrorIndex;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsVerticalOrderPreferred;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfReadingInformationUIElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfReadingInformationUIElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfUIElement"/> to <see cref = "ITfReadingInformationUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfUIElement"/> instance to be converted </param>
    public static explicit operator ITfReadingInformationUIElement(
        Silk.NET.Windows.ITfUIElement value
    )
    {
        return new ITfReadingInformationUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfReadingInformationUIElement"/> to <see cref = "Silk.NET.Windows.ITfUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "ITfReadingInformationUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfUIElement(
        ITfReadingInformationUIElement value
    )
    {
        return new Silk.NET.Windows.ITfUIElement(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfReadingInformationUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfReadingInformationUIElement(Silk.NET.Windows.IUnknown value)
    {
        return new ITfReadingInformationUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfReadingInformationUIElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfReadingInformationUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfReadingInformationUIElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
