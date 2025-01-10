// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7C857801-7381-11CF-884D-00AA004B2E24")]
[NativeTypeName("struct IWbemObjectSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemObjectSink : IWbemObjectSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemObjectSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemObjectSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemObjectSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemObjectSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject* apObjArray)
    {
        return ((delegate* unmanaged<IWbemObjectSink, int, IWbemClassObject*, int>)((*lpVtbl)[3]))(
            this,
            lObjectCount,
            apObjArray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStatus(
        [NativeTypeName("long")] int lFlags,
        HRESULT hResult,
        [NativeTypeName("BSTR")] ushort* strParam,
        IWbemClassObject pObjParam
    )
    {
        return (
            (delegate* unmanaged<IWbemObjectSink, int, HRESULT, ushort*, IWbemClassObject, int>)(
                (*lpVtbl)[4]
            )
        )(this, lFlags, hResult, strParam, pObjParam);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject* apObjArray);

        [VtblIndex(4)]
        HRESULT SetStatus(
            [NativeTypeName("long")] int lFlags,
            HRESULT hResult,
            [NativeTypeName("BSTR")] ushort* strParam,
            IWbemClassObject pObjParam
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

        [NativeTypeName("HRESULT (long, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IWbemClassObject*, int> Indicate;

        [NativeTypeName(
            "HRESULT (long, HRESULT, BSTR, IWbemClassObject *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, HRESULT, ushort*, IWbemClassObject, int> SetStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemObjectSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemObjectSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemObjectSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemObjectSink(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemObjectSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemObjectSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemObjectSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemObjectSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
