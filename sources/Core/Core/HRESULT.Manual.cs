// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable CS1589, CS0419, CA1416, CS0618
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Core;

/// <summary>
/// Common error code value returned by Microsoft methods
/// </summary>
public partial struct HResult
{
    /// <summary>
    /// Has the function failed
    /// </summary>
    public bool Failed => Value < 0;

    /// <summary>
    /// Has the function succeeded
    /// </summary>
    public bool Succeeded => Value >= 0;

    /// <summary>
    /// Does the given HResult value indicates success
    /// </summary>
    /// <param name="hr">HResult value</param>
    /// <returns>Whether the value indicates success</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static bool IndicatesSuccess(int hr) => hr >= 0;

    /// <summary>
    /// Does the given HResult value indicates failure
    /// </summary>
    /// <param name="hr">HResult value</param>
    /// <returns>Whether the value indicates failure</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static bool IndicatesFailure(int hr) => hr < 0;

    /// <summary>
    /// Does the given HResult status indicates error
    /// </summary>
    /// <param name="status">HResult status value</param>
    /// <returns>Whether the value indicates error</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static bool IndicatesError(int status) => ((uint)status >> 31) == 1;

    /// <summary>
    /// Gets the code from the given HResult value
    /// </summary>
    /// <param name="hr">HResult value</param>
    /// <returns>code of the HResult</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static int GetCode(int hr) => hr & 0xFFFF;

    /// <summary>
    /// Gets the facility from the given HResult value
    /// </summary>
    /// <param name="hr">HResult value</param>
    /// <returns>facility of the HResult</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static int GetFacility(int hr) => (hr >> 16) & 0x1FFF;

    /// <summary>
    /// Gets the severity from the given HResult value
    /// </summary>
    /// <param name="hr">HResult value</param>
    /// <returns>severity of the HResult</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static int GetSeverity(int hr) => (hr >> 31) & 1;

    /// <summary>
    /// Creates a HResult from the given severity, facility, and code values
    /// </summary>
    /// <param name="severity">severity value</param>
    /// <param name="facility">facility value</param>
    /// <param name="code">code value</param>
    /// <returns>HResult with the given severity, facility, and code</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static int Create(int severity, int facility, int code) =>
        (int)(((uint)severity << 31) | ((uint)facility << 16) | (uint)code);

    /// <summary>
    /// Constructs a HResult from the given severity, facility, and code values
    /// </summary>
    /// <param name="severity">severity value</param>
    /// <param name="facility">facility value</param>
    /// <param name="code">code value</param>
    public HResult(int severity, int facility, int code) =>
        Value = Create(severity, facility, code);

    /// <summary>
    /// Does this HResult represent a success
    /// </summary>
    public bool IsSuccess
    {
        [MethodImpl((MethodImplOptions)768)]
        get => IndicatesSuccess(Value);
    }

    /// <summary>
    /// Does this HResult represent a failure
    /// </summary>
    public bool IsFailure
    {
        [MethodImpl((MethodImplOptions)768)]
        get => IndicatesFailure(Value);
    }

    /// <summary>
    /// Does this HResult represent a error
    /// </summary>
    public bool IsError
    {
        [MethodImpl((MethodImplOptions)768)]
        get => IndicatesError(Value);
    }

    /// <summary>
    /// Gets the code for this HResult
    /// </summary>
    public int Code
    {
        [MethodImpl((MethodImplOptions)768)]
        get => GetCode(Value);
    }

    /// <summary>
    /// Gets the facility for this HResult
    /// </summary>
    public int Facility
    {
        [MethodImpl((MethodImplOptions)768)]
        get => GetFacility(Value);
    }

    /// <summary>
    /// Gets the severity for this HResult
    /// </summary>
    public int Severity
    {
        [MethodImpl((MethodImplOptions)768)]
        get => GetSeverity(Value);
    }

    /// <summary>
    /// Throws this HResult as an exception
    /// </summary>
    public void Throw() => Marshal.ThrowExceptionForHR(Value);
}
