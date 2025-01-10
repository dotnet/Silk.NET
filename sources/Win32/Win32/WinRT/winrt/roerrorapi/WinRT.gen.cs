// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoGetErrorReportingFlags(
        [NativeTypeName("UINT32 *")] uint* pflags
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoSetErrorReportingFlags([NativeTypeName("UINT32")] uint flags);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoResolveRestrictedErrorInfoReference(
        [NativeTypeName("PCWSTR")] ushort* reference,
        IRestrictedErrorInfo* ppRestrictedErrorInfo
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetRestrictedErrorInfo(IRestrictedErrorInfo pRestrictedErrorInfo);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetRestrictedErrorInfo(
        IRestrictedErrorInfo* ppRestrictedErrorInfo
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL RoOriginateErrorW(
        HRESULT error,
        uint cchMax,
        [NativeTypeName("PCWSTR")] ushort* message
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL RoOriginateError(HRESULT error, HSTRING message);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL RoTransformErrorW(
        HRESULT oldError,
        HRESULT newError,
        uint cchMax,
        [NativeTypeName("PCWSTR")] ushort* message
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL RoTransformError(HRESULT oldError, HRESULT newError, HSTRING message);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RoCaptureErrorContext(HRESULT hr);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void RoFailFastWithErrorContext(HRESULT hrError);

    [SupportedOSPlatform("windows6.2")]
    public static HRESULT GetErrorReportingFlags([NativeTypeName("UINT32 *")] uint* pflags)
    {
        return RoGetErrorReportingFlags(pflags);
    }

    [SupportedOSPlatform("windows6.2")]
    public static HRESULT SetErrorReportingFlags([NativeTypeName("UINT32")] uint flags)
    {
        return RoSetErrorReportingFlags(flags);
    }

    [SupportedOSPlatform("windows6.2")]
    public static BOOL OriginateError(
        HRESULT error,
        uint cchMax,
        [NativeTypeName("PCWSTR")] ushort* message
    )
    {
        if ((((HRESULT)(error)) >= 0))
        {
            return 0;
        }
        return RoOriginateErrorW(error, cchMax, message);
    }

    [SupportedOSPlatform("windows6.2")]
    public static BOOL OriginateError(HRESULT error, HSTRING message)
    {
        if ((((HRESULT)(error)) >= 0))
        {
            return 0;
        }
        return RoOriginateError(error, message);
    }

    [SupportedOSPlatform("windows6.2")]
    public static BOOL TransformError(
        HRESULT oldError,
        HRESULT newError,
        uint cchMax,
        [NativeTypeName("PCWSTR")] ushort* message
    )
    {
        if (
            (oldError == newError) || ((((HRESULT)(oldError)) >= 0) && (((HRESULT)(newError)) >= 0))
        )
        {
            return 0;
        }
        return RoTransformErrorW(oldError, newError, cchMax, message);
    }

    [SupportedOSPlatform("windows6.2")]
    public static BOOL TransformError(HRESULT oldError, HRESULT newError, HSTRING message)
    {
        if (
            (oldError == newError) || ((((HRESULT)(oldError)) >= 0) && (((HRESULT)(newError)) >= 0))
        )
        {
            return 0;
        }
        return RoTransformError(oldError, newError, message);
    }

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL RoOriginateLanguageException(
        HRESULT error,
        HSTRING message,
        IUnknown languageException
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern void RoClearError();

    [DllImport("api-ms-win-core-winrt-error-l1-1-1", ExactSpelling = true)]
    public static extern HRESULT RoReportUnhandledError(IRestrictedErrorInfo pRestrictedErrorInfo);

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RoInspectThreadErrorInfo(
        [NativeTypeName("UINT_PTR")] nuint targetTebAddress,
        ushort machine,
        [NativeTypeName("PINSPECT_MEMORY_CALLBACK")]
            delegate* unmanaged<void*, nuint, uint, byte*, HRESULT> readMemoryCallback,
        [NativeTypeName("PVOID")] void* context,
        [NativeTypeName("UINT_PTR *")] nuint* targetErrorInfoAddress
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RoInspectCapturedStackBackTrace(
        [NativeTypeName("UINT_PTR")] nuint targetErrorInfoAddress,
        ushort machine,
        [NativeTypeName("PINSPECT_MEMORY_CALLBACK")]
            delegate* unmanaged<void*, nuint, uint, byte*, HRESULT> readMemoryCallback,
        [NativeTypeName("PVOID")] void* context,
        [NativeTypeName("UINT32 *")] uint* frameCount,
        [NativeTypeName("UINT_PTR *")] nuint* targetBackTraceAddress
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoGetMatchingRestrictedErrorInfo(
        HRESULT hrIn,
        IRestrictedErrorInfo* ppRestrictedErrorInfo
    );

    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoReportFailedDelegate(
        IUnknown punkDelegate,
        IRestrictedErrorInfo pRestrictedErrorInfo
    );

    [DllImport("combase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL IsErrorPropagationEnabled();
}
