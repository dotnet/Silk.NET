// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C1FB73D0-EC3A-4BA2-B512-8CDB9187B6D1")]
[NativeTypeName("struct IHWEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHWEventHandler : IHWEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHWEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHWEventHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHWEventHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHWEventHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszParams)
    {
        return ((delegate* unmanaged<IHWEventHandler, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pszParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT HandleEvent(
        [NativeTypeName("LPCWSTR")] ushort* pszDeviceID,
        [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID,
        [NativeTypeName("LPCWSTR")] ushort* pszEventType
    )
    {
        return (
            (delegate* unmanaged<IHWEventHandler, ushort*, ushort*, ushort*, int>)((*lpVtbl)[4])
        )(this, pszDeviceID, pszAltDeviceID, pszEventType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HandleEventWithContent(
        [NativeTypeName("LPCWSTR")] ushort* pszDeviceID,
        [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID,
        [NativeTypeName("LPCWSTR")] ushort* pszEventType,
        [NativeTypeName("LPCWSTR")] ushort* pszContentTypeHandler,
        IDataObject pdataobject
    )
    {
        return (
            (delegate* unmanaged<
                IHWEventHandler,
                ushort*,
                ushort*,
                ushort*,
                ushort*,
                IDataObject,
                int>)((*lpVtbl)[5])
        )(this, pszDeviceID, pszAltDeviceID, pszEventType, pszContentTypeHandler, pdataobject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszParams);

        [VtblIndex(4)]
        HRESULT HandleEvent(
            [NativeTypeName("LPCWSTR")] ushort* pszDeviceID,
            [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID,
            [NativeTypeName("LPCWSTR")] ushort* pszEventType
        );

        [VtblIndex(5)]
        HRESULT HandleEventWithContent(
            [NativeTypeName("LPCWSTR")] ushort* pszDeviceID,
            [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID,
            [NativeTypeName("LPCWSTR")] ushort* pszEventType,
            [NativeTypeName("LPCWSTR")] ushort* pszContentTypeHandler,
            IDataObject pdataobject
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Initialize;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> HandleEvent;

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, IDataObject *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            ushort*,
            IDataObject,
            int> HandleEventWithContent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHWEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHWEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHWEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHWEventHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IHWEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHWEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHWEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHWEventHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
