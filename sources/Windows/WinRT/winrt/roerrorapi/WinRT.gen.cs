// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoGetErrorReportingFlags"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoGetErrorReportingFlags([NativeTypeName("UINT32 *")] uint* pflags);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoSetErrorReportingFlags"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoSetErrorReportingFlags([NativeTypeName("UINT32")] uint flags);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoResolveRestrictedErrorInfoReference"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoResolveRestrictedErrorInfoReference([NativeTypeName("PCWSTR")] ushort* reference, IRestrictedErrorInfo** ppRestrictedErrorInfo);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.SetRestrictedErrorInfo"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT SetRestrictedErrorInfo(IRestrictedErrorInfo* pRestrictedErrorInfo);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.GetRestrictedErrorInfo"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT GetRestrictedErrorInfo(IRestrictedErrorInfo** ppRestrictedErrorInfo);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoOriginateErrorW"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern BOOL RoOriginateErrorW(HRESULT error, uint cchMax, [NativeTypeName("PCWSTR")] ushort* message);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoOriginateError"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern BOOL RoOriginateError(HRESULT error, HSTRING message);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoTransformErrorW"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern BOOL RoTransformErrorW(HRESULT oldError, HRESULT newError, uint cchMax, [NativeTypeName("PCWSTR")] ushort* message);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoTransformError"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern BOOL RoTransformError(HRESULT oldError, HRESULT newError, HSTRING message);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoCaptureErrorContext"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoCaptureErrorContext(HRESULT hr);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoFailFastWithErrorContext"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern void RoFailFastWithErrorContext(HRESULT hrError);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.GetErrorReportingFlags"]/*'/>
    public static HRESULT GetErrorReportingFlags([NativeTypeName("UINT32 *")] uint* pflags)
    {
        return RoGetErrorReportingFlags(pflags);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.SetErrorReportingFlags"]/*'/>
    public static HRESULT SetErrorReportingFlags([NativeTypeName("UINT32")] uint flags)
    {
        return RoSetErrorReportingFlags(flags);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.OriginateError"]/*'/>
    public static BOOL OriginateError(HRESULT error, uint cchMax, [NativeTypeName("PCWSTR")] ushort* message)
    {
        if ((((HRESULT)(error)) >= 0))
        {
            return 0;
        }

        return RoOriginateErrorW(error, cchMax, message);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.OriginateError"]/*'/>
    public static BOOL OriginateError(HRESULT error, HSTRING message)
    {
        if ((((HRESULT)(error)) >= 0))
        {
            return 0;
        }

        return RoOriginateError(error, message);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.TransformError"]/*'/>
    public static BOOL TransformError(HRESULT oldError, HRESULT newError, uint cchMax, [NativeTypeName("PCWSTR")] ushort* message)
    {
        if ((oldError == newError) || ((((HRESULT)(oldError)) >= 0) && (((HRESULT)(newError)) >= 0)))
        {
            return 0;
        }

        return RoTransformErrorW(oldError, newError, cchMax, message);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.TransformError"]/*'/>
    public static BOOL TransformError(HRESULT oldError, HRESULT newError, HSTRING message)
    {
        if ((oldError == newError) || ((((HRESULT)(oldError)) >= 0) && (((HRESULT)(newError)) >= 0)))
        {
            return 0;
        }

        return RoTransformError(oldError, newError, message);
    }

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoOriginateLanguageException"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern BOOL RoOriginateLanguageException(HRESULT error, HSTRING message, IUnknown* languageException);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoClearError"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern void RoClearError();
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoReportUnhandledError"]/*'/>
    [DllImport("api-ms-win-core-winrt-error-l1-1-1", ExactSpelling = true)]
    public static extern HRESULT RoReportUnhandledError(IRestrictedErrorInfo* pRestrictedErrorInfo);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoInspectThreadErrorInfo"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoInspectThreadErrorInfo([NativeTypeName("UINT_PTR")] nuint targetTebAddress, ushort machine, [NativeTypeName("PINSPECT_MEMORY_CALLBACK")] delegate* unmanaged<void*, nuint, uint, byte*, HRESULT> readMemoryCallback, [NativeTypeName("PVOID")] void* context, [NativeTypeName("UINT_PTR *")] nuint* targetErrorInfoAddress);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoInspectCapturedStackBackTrace"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoInspectCapturedStackBackTrace([NativeTypeName("UINT_PTR")] nuint targetErrorInfoAddress, ushort machine, [NativeTypeName("PINSPECT_MEMORY_CALLBACK")] delegate* unmanaged<void*, nuint, uint, byte*, HRESULT> readMemoryCallback, [NativeTypeName("PVOID")] void* context, [NativeTypeName("UINT32 *")] uint* frameCount, [NativeTypeName("UINT_PTR *")] nuint* targetBackTraceAddress);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoReportFailedDelegate"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern HRESULT RoReportFailedDelegate(IUnknown* punkDelegate, IRestrictedErrorInfo* pRestrictedErrorInfo);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.IsErrorPropagationEnabled"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern BOOL IsErrorPropagationEnabled();
}