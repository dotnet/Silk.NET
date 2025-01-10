// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("49353C92-516B-11D1-AEA6-00C04FB68820")]
[NativeTypeName("struct IWbemConfigureRefresher : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemConfigureRefresher
    : IWbemConfigureRefresher.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemConfigureRefresher));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemConfigureRefresher, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemConfigureRefresher, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemConfigureRefresher, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddObjectByPath(
        IWbemServices pNamespace,
        [NativeTypeName("LPCWSTR")] ushort* wszPath,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pContext,
        IWbemClassObject* ppRefreshable,
        [NativeTypeName("long *")] int* plId
    )
    {
        return (
            (delegate* unmanaged<
                IWbemConfigureRefresher,
                IWbemServices,
                ushort*,
                int,
                IWbemContext,
                IWbemClassObject*,
                int*,
                int>)((*lpVtbl)[3])
        )(this, pNamespace, wszPath, lFlags, pContext, ppRefreshable, plId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddObjectByTemplate(
        IWbemServices pNamespace,
        IWbemClassObject pTemplate,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pContext,
        IWbemClassObject* ppRefreshable,
        [NativeTypeName("long *")] int* plId
    )
    {
        return (
            (delegate* unmanaged<
                IWbemConfigureRefresher,
                IWbemServices,
                IWbemClassObject,
                int,
                IWbemContext,
                IWbemClassObject*,
                int*,
                int>)((*lpVtbl)[4])
        )(this, pNamespace, pTemplate, lFlags, pContext, ppRefreshable, plId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddRefresher(
        IWbemRefresher pRefresher,
        [NativeTypeName("long")] int lFlags,
        [NativeTypeName("long *")] int* plId
    )
    {
        return (
            (delegate* unmanaged<IWbemConfigureRefresher, IWbemRefresher, int, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pRefresher, lFlags, plId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Remove([NativeTypeName("long")] int lId, [NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemConfigureRefresher, int, int, int>)((*lpVtbl)[6]))(
            this,
            lId,
            lFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddEnum(
        IWbemServices pNamespace,
        [NativeTypeName("LPCWSTR")] ushort* wszClassName,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pContext,
        IWbemHiPerfEnum* ppEnum,
        [NativeTypeName("long *")] int* plId
    )
    {
        return (
            (delegate* unmanaged<
                IWbemConfigureRefresher,
                IWbemServices,
                ushort*,
                int,
                IWbemContext,
                IWbemHiPerfEnum*,
                int*,
                int>)((*lpVtbl)[7])
        )(this, pNamespace, wszClassName, lFlags, pContext, ppEnum, plId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddObjectByPath(
            IWbemServices pNamespace,
            [NativeTypeName("LPCWSTR")] ushort* wszPath,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pContext,
            IWbemClassObject* ppRefreshable,
            [NativeTypeName("long *")] int* plId
        );

        [VtblIndex(4)]
        HRESULT AddObjectByTemplate(
            IWbemServices pNamespace,
            IWbemClassObject pTemplate,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pContext,
            IWbemClassObject* ppRefreshable,
            [NativeTypeName("long *")] int* plId
        );

        [VtblIndex(5)]
        HRESULT AddRefresher(
            IWbemRefresher pRefresher,
            [NativeTypeName("long")] int lFlags,
            [NativeTypeName("long *")] int* plId
        );

        [VtblIndex(6)]
        HRESULT Remove([NativeTypeName("long")] int lId, [NativeTypeName("long")] int lFlags);

        [VtblIndex(7)]
        HRESULT AddEnum(
            IWbemServices pNamespace,
            [NativeTypeName("LPCWSTR")] ushort* wszClassName,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pContext,
            IWbemHiPerfEnum* ppEnum,
            [NativeTypeName("long *")] int* plId
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
            "HRESULT (IWbemServices *, LPCWSTR, long, IWbemContext *, IWbemClassObject **, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemServices,
            ushort*,
            int,
            IWbemContext,
            IWbemClassObject*,
            int*,
            int> AddObjectByPath;

        [NativeTypeName(
            "HRESULT (IWbemServices *, IWbemClassObject *, long, IWbemContext *, IWbemClassObject **, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemServices,
            IWbemClassObject,
            int,
            IWbemContext,
            IWbemClassObject*,
            int*,
            int> AddObjectByTemplate;

        [NativeTypeName("HRESULT (IWbemRefresher *, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWbemRefresher, int, int*, int> AddRefresher;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> Remove;

        [NativeTypeName(
            "HRESULT (IWbemServices *, LPCWSTR, long, IWbemContext *, IWbemHiPerfEnum **, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemServices,
            ushort*,
            int,
            IWbemContext,
            IWbemHiPerfEnum*,
            int*,
            int> AddEnum;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemConfigureRefresher"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemConfigureRefresher(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemConfigureRefresher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemConfigureRefresher(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemConfigureRefresher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemConfigureRefresher"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemConfigureRefresher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemConfigureRefresher value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
