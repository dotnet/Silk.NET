// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("22F55882-280B-11D0-A8A9-00A0C90C2004")]
[NativeTypeName("struct IPropertyBag2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyBag2 : IPropertyBag2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyBag2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyBag2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyBag2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyBag2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        [NativeTypeName("ULONG")] uint cProperties,
        PROPBAG2* pPropBag,
        IErrorLog pErrLog,
        VARIANT* pvarValue,
        HRESULT* phrError
    )
    {
        return (
            (delegate* unmanaged<
                IPropertyBag2,
                uint,
                PROPBAG2*,
                IErrorLog,
                VARIANT*,
                HRESULT*,
                int>)((*lpVtbl)[3])
        )(this, cProperties, pPropBag, pErrLog, pvarValue, phrError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write(
        [NativeTypeName("ULONG")] uint cProperties,
        PROPBAG2* pPropBag,
        VARIANT* pvarValue
    )
    {
        return ((delegate* unmanaged<IPropertyBag2, uint, PROPBAG2*, VARIANT*, int>)((*lpVtbl)[4]))(
            this,
            cProperties,
            pPropBag,
            pvarValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CountProperties([NativeTypeName("ULONG *")] uint* pcProperties)
    {
        return ((delegate* unmanaged<IPropertyBag2, uint*, int>)((*lpVtbl)[5]))(this, pcProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyInfo(
        [NativeTypeName("ULONG")] uint iProperty,
        [NativeTypeName("ULONG")] uint cProperties,
        PROPBAG2* pPropBag,
        [NativeTypeName("ULONG *")] uint* pcProperties
    )
    {
        return (
            (delegate* unmanaged<IPropertyBag2, uint, uint, PROPBAG2*, uint*, int>)((*lpVtbl)[6])
        )(this, iProperty, cProperties, pPropBag, pcProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LoadObject(
        [NativeTypeName("LPCOLESTR")] ushort* pstrName,
        [NativeTypeName("DWORD")] uint dwHint,
        IUnknown pUnkObject,
        IErrorLog pErrLog
    )
    {
        return (
            (delegate* unmanaged<IPropertyBag2, ushort*, uint, IUnknown, IErrorLog, int>)(
                (*lpVtbl)[7]
            )
        )(this, pstrName, dwHint, pUnkObject, pErrLog);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Read(
            [NativeTypeName("ULONG")] uint cProperties,
            PROPBAG2* pPropBag,
            IErrorLog pErrLog,
            VARIANT* pvarValue,
            HRESULT* phrError
        );

        [VtblIndex(4)]
        HRESULT Write(
            [NativeTypeName("ULONG")] uint cProperties,
            PROPBAG2* pPropBag,
            VARIANT* pvarValue
        );

        [VtblIndex(5)]
        HRESULT CountProperties([NativeTypeName("ULONG *")] uint* pcProperties);

        [VtblIndex(6)]
        HRESULT GetPropertyInfo(
            [NativeTypeName("ULONG")] uint iProperty,
            [NativeTypeName("ULONG")] uint cProperties,
            PROPBAG2* pPropBag,
            [NativeTypeName("ULONG *")] uint* pcProperties
        );

        [VtblIndex(7)]
        HRESULT LoadObject(
            [NativeTypeName("LPCOLESTR")] ushort* pstrName,
            [NativeTypeName("DWORD")] uint dwHint,
            IUnknown pUnkObject,
            IErrorLog pErrLog
        );
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
            "HRESULT (ULONG, PROPBAG2 *, IErrorLog *, VARIANT *, HRESULT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            PROPBAG2*,
            IErrorLog,
            VARIANT*,
            HRESULT*,
            int> Read;

        [NativeTypeName("HRESULT (ULONG, PROPBAG2 *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPBAG2*, VARIANT*, int> Write;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> CountProperties;

        [NativeTypeName("HRESULT (ULONG, ULONG, PROPBAG2 *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, PROPBAG2*, uint*, int> GetPropertyInfo;

        [NativeTypeName(
            "HRESULT (LPCOLESTR, DWORD, IUnknown *, IErrorLog *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, IUnknown, IErrorLog, int> LoadObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyBag2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyBag2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyBag2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyBag2(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyBag2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyBag2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyBag2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyBag2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
