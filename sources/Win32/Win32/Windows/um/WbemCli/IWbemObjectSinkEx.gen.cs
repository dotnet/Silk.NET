// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E7D35CFA-348B-485E-B524-252725D697CA")]
[NativeTypeName("struct IWbemObjectSinkEx : IWbemObjectSink")]
[NativeInheritance("IWbemObjectSink")]
public unsafe partial struct IWbemObjectSinkEx : IWbemObjectSinkEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemObjectSinkEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemObjectSinkEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject* apObjArray)
    {
        return (
            (delegate* unmanaged<IWbemObjectSinkEx, int, IWbemClassObject*, int>)((*lpVtbl)[3])
        )(this, lObjectCount, apObjArray);
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
            (delegate* unmanaged<IWbemObjectSinkEx, int, HRESULT, ushort*, IWbemClassObject, int>)(
                (*lpVtbl)[4]
            )
        )(this, lFlags, hResult, strParam, pObjParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT WriteMessage(
        [NativeTypeName("ULONG")] uint uChannel,
        [NativeTypeName("const BSTR")] ushort* strMessage
    )
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx, uint, ushort*, int>)((*lpVtbl)[5]))(
            this,
            uChannel,
            strMessage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteError(
        IWbemClassObject pObjError,
        [NativeTypeName("unsigned char *")] byte* puReturned
    )
    {
        return (
            (delegate* unmanaged<IWbemObjectSinkEx, IWbemClassObject, byte*, int>)((*lpVtbl)[6])
        )(this, pObjError, puReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PromptUser(
        [NativeTypeName("const BSTR")] ushort* strMessage,
        [NativeTypeName("unsigned char")] byte uPromptType,
        [NativeTypeName("unsigned char *")] byte* puReturned
    )
    {
        return ((delegate* unmanaged<IWbemObjectSinkEx, ushort*, byte, byte*, int>)((*lpVtbl)[7]))(
            this,
            strMessage,
            uPromptType,
            puReturned
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteProgress(
        [NativeTypeName("const BSTR")] ushort* strActivity,
        [NativeTypeName("const BSTR")] ushort* strCurrentOperation,
        [NativeTypeName("const BSTR")] ushort* strStatusDescription,
        [NativeTypeName("ULONG")] uint uPercentComplete,
        [NativeTypeName("ULONG")] uint uSecondsRemaining
    )
    {
        return (
            (delegate* unmanaged<IWbemObjectSinkEx, ushort*, ushort*, ushort*, uint, uint, int>)(
                (*lpVtbl)[8]
            )
        )(
            this,
            strActivity,
            strCurrentOperation,
            strStatusDescription,
            uPercentComplete,
            uSecondsRemaining
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteStreamParameter(
        [NativeTypeName("const BSTR")] ushort* strName,
        VARIANT* vtValue,
        [NativeTypeName("ULONG")] uint ulType,
        [NativeTypeName("ULONG")] uint ulFlags
    )
    {
        return (
            (delegate* unmanaged<IWbemObjectSinkEx, ushort*, VARIANT*, uint, uint, int>)(
                (*lpVtbl)[9]
            )
        )(this, strName, vtValue, ulType, ulFlags);
    }

    public interface Interface : IWbemObjectSink.Interface
    {
        [VtblIndex(5)]
        HRESULT WriteMessage(
            [NativeTypeName("ULONG")] uint uChannel,
            [NativeTypeName("const BSTR")] ushort* strMessage
        );

        [VtblIndex(6)]
        HRESULT WriteError(
            IWbemClassObject pObjError,
            [NativeTypeName("unsigned char *")] byte* puReturned
        );

        [VtblIndex(7)]
        HRESULT PromptUser(
            [NativeTypeName("const BSTR")] ushort* strMessage,
            [NativeTypeName("unsigned char")] byte uPromptType,
            [NativeTypeName("unsigned char *")] byte* puReturned
        );

        [VtblIndex(8)]
        HRESULT WriteProgress(
            [NativeTypeName("const BSTR")] ushort* strActivity,
            [NativeTypeName("const BSTR")] ushort* strCurrentOperation,
            [NativeTypeName("const BSTR")] ushort* strStatusDescription,
            [NativeTypeName("ULONG")] uint uPercentComplete,
            [NativeTypeName("ULONG")] uint uSecondsRemaining
        );

        [VtblIndex(9)]
        HRESULT WriteStreamParameter(
            [NativeTypeName("const BSTR")] ushort* strName,
            VARIANT* vtValue,
            [NativeTypeName("ULONG")] uint ulType,
            [NativeTypeName("ULONG")] uint ulFlags
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

        [NativeTypeName("HRESULT (ULONG, const BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> WriteMessage;

        [NativeTypeName("HRESULT (IWbemClassObject *, unsigned char *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWbemClassObject, byte*, int> WriteError;

        [NativeTypeName(
            "HRESULT (const BSTR, unsigned char, unsigned char *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, byte, byte*, int> PromptUser;

        [NativeTypeName(
            "HRESULT (const BSTR, const BSTR, const BSTR, ULONG, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            uint,
            uint,
            int> WriteProgress;

        [NativeTypeName("HRESULT (const BSTR, VARIANT *, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, uint, uint, int> WriteStreamParameter;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemObjectSinkEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemObjectSinkEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWbemObjectSink"/> to <see cref = "IWbemObjectSinkEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWbemObjectSink"/> instance to be converted </param>
    public static explicit operator IWbemObjectSinkEx(Silk.NET.Windows.IWbemObjectSink value)
    {
        return new IWbemObjectSinkEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemObjectSinkEx"/> to <see cref = "Silk.NET.Windows.IWbemObjectSink"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemObjectSinkEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWbemObjectSink(IWbemObjectSinkEx value)
    {
        return new Silk.NET.Windows.IWbemObjectSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemObjectSinkEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemObjectSinkEx(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemObjectSinkEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemObjectSinkEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemObjectSinkEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemObjectSinkEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
