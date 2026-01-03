// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    [DoesNotReturn]
    public static void ThrowExternalException(string methodName, int errorCode)
    {
        var message = string.Format(
            "'{0}' failed with an error code of '{1}'",
            methodName,
            errorCode
        );
        throw new ExternalException(message, errorCode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfFailed(
        HResult value,
        [CallerArgumentExpression("value")] string? valueExpression = null
    )
    {
        if (value.FAILED)
        {
            ThrowExternalException(valueExpression ?? "Method", value);
        }
    }
}
