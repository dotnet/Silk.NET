// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EAFE4895-A929-41EA-B14D-613E23F62B71")]
[NativeTypeName("struct IAppHostPropertyException : IAppHostConfigException")]
[NativeInheritance("IAppHostConfigException")]
public unsafe partial struct IAppHostPropertyException
    : IAppHostPropertyException.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPropertyException));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostPropertyException, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostPropertyException, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_LineNumber([NativeTypeName("ULONG *")] uint* pcLineNumber)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcLineNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_FileName([NativeTypeName("BSTR *")] ushort** pbstrFileName)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pbstrFileName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_ConfigPath([NativeTypeName("BSTR *")] ushort** pbstrConfigPath)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[5]))(
            this,
            pbstrConfigPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ErrorLine([NativeTypeName("BSTR *")] ushort** pbstrErrorLine)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pbstrErrorLine
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PreErrorLine([NativeTypeName("BSTR *")] ushort** pbstrPreErrorLine)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[7]))(
            this,
            pbstrPreErrorLine
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PostErrorLine([NativeTypeName("BSTR *")] ushort** pbstrPostErrorLine)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[8]))(
            this,
            pbstrPostErrorLine
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ErrorString([NativeTypeName("BSTR *")] ushort** pbstrErrorString)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[9]))(
            this,
            pbstrErrorString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InvalidValue([NativeTypeName("BSTR *")] ushort** pbstrValue)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[10]))(
            this,
            pbstrValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ValidationFailureReason(
        [NativeTypeName("BSTR *")] ushort** pbstrValidationReason
    )
    {
        return ((delegate* unmanaged<IAppHostPropertyException, ushort**, int>)((*lpVtbl)[11]))(
            this,
            pbstrValidationReason
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ValidationFailureParameters(SAFEARRAY** pParameterArray)
    {
        return ((delegate* unmanaged<IAppHostPropertyException, SAFEARRAY**, int>)((*lpVtbl)[12]))(
            this,
            pParameterArray
        );
    }

    public interface Interface : IAppHostConfigException.Interface
    {
        [VtblIndex(10)]
        HRESULT get_InvalidValue([NativeTypeName("BSTR *")] ushort** pbstrValue);

        [VtblIndex(11)]
        HRESULT get_ValidationFailureReason(
            [NativeTypeName("BSTR *")] ushort** pbstrValidationReason
        );

        [VtblIndex(12)]
        HRESULT get_ValidationFailureParameters(SAFEARRAY** pParameterArray);
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

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_LineNumber;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_FileName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ConfigPath;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ErrorLine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_PreErrorLine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_PostErrorLine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ErrorString;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_InvalidValue;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ValidationFailureReason;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_ValidationFailureParameters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostPropertyException"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostPropertyException(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAppHostConfigException"/> to <see cref = "IAppHostPropertyException"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAppHostConfigException"/> instance to be converted </param>
    public static explicit operator IAppHostPropertyException(
        Silk.NET.Windows.IAppHostConfigException value
    )
    {
        return new IAppHostPropertyException(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostPropertyException"/> to <see cref = "Silk.NET.Windows.IAppHostConfigException"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostPropertyException"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAppHostConfigException(
        IAppHostPropertyException value
    )
    {
        return new Silk.NET.Windows.IAppHostConfigException(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostPropertyException"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostPropertyException(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostPropertyException(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostPropertyException"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostPropertyException"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostPropertyException value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
