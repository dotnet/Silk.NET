// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9556DC99-828C-11CF-A37E-00AA003240C7")]
[NativeTypeName("struct IWbemServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemServices : IWbemServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemServices, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OpenNamespace(
        [NativeTypeName("const BSTR")] ushort* strNamespace,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemServices* ppWorkingNamespace,
        IWbemCallResult* ppResult
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                int,
                IWbemContext,
                IWbemServices*,
                IWbemCallResult*,
                int>)((*lpVtbl)[3])
        )(this, strNamespace, lFlags, pCtx, ppWorkingNamespace, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CancelAsyncCall(IWbemObjectSink pSink)
    {
        return ((delegate* unmanaged<IWbemServices, IWbemObjectSink, int>)((*lpVtbl)[4]))(
            this,
            pSink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryObjectSink(
        [NativeTypeName("long")] int lFlags,
        IWbemObjectSink* ppResponseHandler
    )
    {
        return ((delegate* unmanaged<IWbemServices, int, IWbemObjectSink*, int>)((*lpVtbl)[5]))(
            this,
            lFlags,
            ppResponseHandler
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObjectW(
        [NativeTypeName("const BSTR")] ushort* strObjectPath,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemClassObject* ppObject,
        IWbemCallResult* ppCallResult
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                int,
                IWbemContext,
                IWbemClassObject*,
                IWbemCallResult*,
                int>)((*lpVtbl)[6])
        )(this, strObjectPath, lFlags, pCtx, ppObject, ppCallResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetObjectAsync(
        [NativeTypeName("const BSTR")] ushort* strObjectPath,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<IWbemServices, ushort*, int, IWbemContext, IWbemObjectSink, int>)(
                (*lpVtbl)[7]
            )
        )(this, strObjectPath, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PutClass(
        IWbemClassObject pObject,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemCallResult* ppCallResult
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                IWbemClassObject,
                int,
                IWbemContext,
                IWbemCallResult*,
                int>)((*lpVtbl)[8])
        )(this, pObject, lFlags, pCtx, ppCallResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PutClassAsync(
        IWbemClassObject pObject,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                IWbemClassObject,
                int,
                IWbemContext,
                IWbemObjectSink,
                int>)((*lpVtbl)[9])
        )(this, pObject, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteClass(
        [NativeTypeName("const BSTR")] ushort* strClass,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemCallResult* ppCallResult
    )
    {
        return (
            (delegate* unmanaged<IWbemServices, ushort*, int, IWbemContext, IWbemCallResult*, int>)(
                (*lpVtbl)[10]
            )
        )(this, strClass, lFlags, pCtx, ppCallResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteClassAsync(
        [NativeTypeName("const BSTR")] ushort* strClass,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<IWbemServices, ushort*, int, IWbemContext, IWbemObjectSink, int>)(
                (*lpVtbl)[11]
            )
        )(this, strClass, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateClassEnum(
        [NativeTypeName("const BSTR")] ushort* strSuperclass,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IEnumWbemClassObject* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                int,
                IWbemContext,
                IEnumWbemClassObject*,
                int>)((*lpVtbl)[12])
        )(this, strSuperclass, lFlags, pCtx, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateClassEnumAsync(
        [NativeTypeName("const BSTR")] ushort* strSuperclass,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<IWbemServices, ushort*, int, IWbemContext, IWbemObjectSink, int>)(
                (*lpVtbl)[13]
            )
        )(this, strSuperclass, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT PutInstance(
        IWbemClassObject pInst,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemCallResult* ppCallResult
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                IWbemClassObject,
                int,
                IWbemContext,
                IWbemCallResult*,
                int>)((*lpVtbl)[14])
        )(this, pInst, lFlags, pCtx, ppCallResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PutInstanceAsync(
        IWbemClassObject pInst,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                IWbemClassObject,
                int,
                IWbemContext,
                IWbemObjectSink,
                int>)((*lpVtbl)[15])
        )(this, pInst, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DeleteInstance(
        [NativeTypeName("const BSTR")] ushort* strObjectPath,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemCallResult* ppCallResult
    )
    {
        return (
            (delegate* unmanaged<IWbemServices, ushort*, int, IWbemContext, IWbemCallResult*, int>)(
                (*lpVtbl)[16]
            )
        )(this, strObjectPath, lFlags, pCtx, ppCallResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DeleteInstanceAsync(
        [NativeTypeName("const BSTR")] ushort* strObjectPath,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<IWbemServices, ushort*, int, IWbemContext, IWbemObjectSink, int>)(
                (*lpVtbl)[17]
            )
        )(this, strObjectPath, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateInstanceEnum(
        [NativeTypeName("const BSTR")] ushort* strFilter,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IEnumWbemClassObject* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                int,
                IWbemContext,
                IEnumWbemClassObject*,
                int>)((*lpVtbl)[18])
        )(this, strFilter, lFlags, pCtx, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateInstanceEnumAsync(
        [NativeTypeName("const BSTR")] ushort* strFilter,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<IWbemServices, ushort*, int, IWbemContext, IWbemObjectSink, int>)(
                (*lpVtbl)[19]
            )
        )(this, strFilter, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ExecQuery(
        [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
        [NativeTypeName("const BSTR")] ushort* strQuery,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IEnumWbemClassObject* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                ushort*,
                int,
                IWbemContext,
                IEnumWbemClassObject*,
                int>)((*lpVtbl)[20])
        )(this, strQueryLanguage, strQuery, lFlags, pCtx, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ExecQueryAsync(
        [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
        [NativeTypeName("const BSTR")] ushort* strQuery,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                ushort*,
                int,
                IWbemContext,
                IWbemObjectSink,
                int>)((*lpVtbl)[21])
        )(this, strQueryLanguage, strQuery, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ExecNotificationQuery(
        [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
        [NativeTypeName("const BSTR")] ushort* strQuery,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IEnumWbemClassObject* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                ushort*,
                int,
                IWbemContext,
                IEnumWbemClassObject*,
                int>)((*lpVtbl)[22])
        )(this, strQueryLanguage, strQuery, lFlags, pCtx, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ExecNotificationQueryAsync(
        [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
        [NativeTypeName("const BSTR")] ushort* strQuery,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                ushort*,
                int,
                IWbemContext,
                IWbemObjectSink,
                int>)((*lpVtbl)[23])
        )(this, strQueryLanguage, strQuery, lFlags, pCtx, pResponseHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ExecMethod(
        [NativeTypeName("const BSTR")] ushort* strObjectPath,
        [NativeTypeName("const BSTR")] ushort* strMethodName,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemClassObject pInParams,
        IWbemClassObject* ppOutParams,
        IWbemCallResult* ppCallResult
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                ushort*,
                int,
                IWbemContext,
                IWbemClassObject,
                IWbemClassObject*,
                IWbemCallResult*,
                int>)((*lpVtbl)[24])
        )(this, strObjectPath, strMethodName, lFlags, pCtx, pInParams, ppOutParams, ppCallResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ExecMethodAsync(
        [NativeTypeName("const BSTR")] ushort* strObjectPath,
        [NativeTypeName("const BSTR")] ushort* strMethodName,
        [NativeTypeName("long")] int lFlags,
        IWbemContext pCtx,
        IWbemClassObject pInParams,
        IWbemObjectSink pResponseHandler
    )
    {
        return (
            (delegate* unmanaged<
                IWbemServices,
                ushort*,
                ushort*,
                int,
                IWbemContext,
                IWbemClassObject,
                IWbemObjectSink,
                int>)((*lpVtbl)[25])
        )(this, strObjectPath, strMethodName, lFlags, pCtx, pInParams, pResponseHandler);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OpenNamespace(
            [NativeTypeName("const BSTR")] ushort* strNamespace,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemServices* ppWorkingNamespace,
            IWbemCallResult* ppResult
        );

        [VtblIndex(4)]
        HRESULT CancelAsyncCall(IWbemObjectSink pSink);

        [VtblIndex(5)]
        HRESULT QueryObjectSink(
            [NativeTypeName("long")] int lFlags,
            IWbemObjectSink* ppResponseHandler
        );

        [VtblIndex(6)]
        HRESULT GetObjectW(
            [NativeTypeName("const BSTR")] ushort* strObjectPath,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemClassObject* ppObject,
            IWbemCallResult* ppCallResult
        );

        [VtblIndex(7)]
        HRESULT GetObjectAsync(
            [NativeTypeName("const BSTR")] ushort* strObjectPath,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(8)]
        HRESULT PutClass(
            IWbemClassObject pObject,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemCallResult* ppCallResult
        );

        [VtblIndex(9)]
        HRESULT PutClassAsync(
            IWbemClassObject pObject,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(10)]
        HRESULT DeleteClass(
            [NativeTypeName("const BSTR")] ushort* strClass,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemCallResult* ppCallResult
        );

        [VtblIndex(11)]
        HRESULT DeleteClassAsync(
            [NativeTypeName("const BSTR")] ushort* strClass,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(12)]
        HRESULT CreateClassEnum(
            [NativeTypeName("const BSTR")] ushort* strSuperclass,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IEnumWbemClassObject* ppEnum
        );

        [VtblIndex(13)]
        HRESULT CreateClassEnumAsync(
            [NativeTypeName("const BSTR")] ushort* strSuperclass,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(14)]
        HRESULT PutInstance(
            IWbemClassObject pInst,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemCallResult* ppCallResult
        );

        [VtblIndex(15)]
        HRESULT PutInstanceAsync(
            IWbemClassObject pInst,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(16)]
        HRESULT DeleteInstance(
            [NativeTypeName("const BSTR")] ushort* strObjectPath,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemCallResult* ppCallResult
        );

        [VtblIndex(17)]
        HRESULT DeleteInstanceAsync(
            [NativeTypeName("const BSTR")] ushort* strObjectPath,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(18)]
        HRESULT CreateInstanceEnum(
            [NativeTypeName("const BSTR")] ushort* strFilter,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IEnumWbemClassObject* ppEnum
        );

        [VtblIndex(19)]
        HRESULT CreateInstanceEnumAsync(
            [NativeTypeName("const BSTR")] ushort* strFilter,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(20)]
        HRESULT ExecQuery(
            [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
            [NativeTypeName("const BSTR")] ushort* strQuery,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IEnumWbemClassObject* ppEnum
        );

        [VtblIndex(21)]
        HRESULT ExecQueryAsync(
            [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
            [NativeTypeName("const BSTR")] ushort* strQuery,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(22)]
        HRESULT ExecNotificationQuery(
            [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
            [NativeTypeName("const BSTR")] ushort* strQuery,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IEnumWbemClassObject* ppEnum
        );

        [VtblIndex(23)]
        HRESULT ExecNotificationQueryAsync(
            [NativeTypeName("const BSTR")] ushort* strQueryLanguage,
            [NativeTypeName("const BSTR")] ushort* strQuery,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemObjectSink pResponseHandler
        );

        [VtblIndex(24)]
        HRESULT ExecMethod(
            [NativeTypeName("const BSTR")] ushort* strObjectPath,
            [NativeTypeName("const BSTR")] ushort* strMethodName,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemClassObject pInParams,
            IWbemClassObject* ppOutParams,
            IWbemCallResult* ppCallResult
        );

        [VtblIndex(25)]
        HRESULT ExecMethodAsync(
            [NativeTypeName("const BSTR")] ushort* strObjectPath,
            [NativeTypeName("const BSTR")] ushort* strMethodName,
            [NativeTypeName("long")] int lFlags,
            IWbemContext pCtx,
            IWbemClassObject pInParams,
            IWbemObjectSink pResponseHandler
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
            "HRESULT (const BSTR, long, IWbemContext *, IWbemServices **, IWbemCallResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemServices*,
            IWbemCallResult*,
            int> OpenNamespace;

        [NativeTypeName("HRESULT (IWbemObjectSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWbemObjectSink, int> CancelAsyncCall;

        [NativeTypeName("HRESULT (long, IWbemObjectSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IWbemObjectSink*, int> QueryObjectSink;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemClassObject **, IWbemCallResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemClassObject*,
            IWbemCallResult*,
            int> GetObjectW;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> GetObjectAsync;

        [NativeTypeName(
            "HRESULT (IWbemClassObject *, long, IWbemContext *, IWbemCallResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemClassObject,
            int,
            IWbemContext,
            IWbemCallResult*,
            int> PutClass;

        [NativeTypeName(
            "HRESULT (IWbemClassObject *, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemClassObject,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> PutClassAsync;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemCallResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemCallResult*,
            int> DeleteClass;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> DeleteClassAsync;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IEnumWbemClassObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IEnumWbemClassObject*,
            int> CreateClassEnum;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> CreateClassEnumAsync;

        [NativeTypeName(
            "HRESULT (IWbemClassObject *, long, IWbemContext *, IWbemCallResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemClassObject,
            int,
            IWbemContext,
            IWbemCallResult*,
            int> PutInstance;

        [NativeTypeName(
            "HRESULT (IWbemClassObject *, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWbemClassObject,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> PutInstanceAsync;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemCallResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemCallResult*,
            int> DeleteInstance;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> DeleteInstanceAsync;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IEnumWbemClassObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IEnumWbemClassObject*,
            int> CreateInstanceEnum;

        [NativeTypeName(
            "HRESULT (const BSTR, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> CreateInstanceEnumAsync;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, long, IWbemContext *, IEnumWbemClassObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            int,
            IWbemContext,
            IEnumWbemClassObject*,
            int> ExecQuery;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> ExecQueryAsync;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, long, IWbemContext *, IEnumWbemClassObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            int,
            IWbemContext,
            IEnumWbemClassObject*,
            int> ExecNotificationQuery;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, long, IWbemContext *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            int,
            IWbemContext,
            IWbemObjectSink,
            int> ExecNotificationQueryAsync;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, long, IWbemContext *, IWbemClassObject *, IWbemClassObject **, IWbemCallResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            int,
            IWbemContext,
            IWbemClassObject,
            IWbemClassObject*,
            IWbemCallResult*,
            int> ExecMethod;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, long, IWbemContext *, IWbemClassObject *, IWbemObjectSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            int,
            IWbemContext,
            IWbemClassObject,
            IWbemObjectSink,
            int> ExecMethodAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemServices(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
