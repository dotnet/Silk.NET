// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Native
{
    // this type is compatible with System.Runtime.InteropServices.UnmanagedType where possible.
    public enum UnmanagedType
    {
        Default = 0,
        
        /// <summary>A 4-byte Boolean value (true != 0, false = 0).</summary>
        /// <returns></returns>
        Bool = 2,

        /// <summary>A 1-byte signed integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        I1 = 3,

        /// <summary>A 1-byte unsigned integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        U1 = 4,

        /// <summary>A 2-byte signed integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        I2 = 5,

        /// <summary>A 2-byte unsigned integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        U2 = 6,

        /// <summary>A 4-byte signed integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        I4 = 7,

        /// <summary>A 4-byte unsigned integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        U4 = 8,

        /// <summary>An 8-byte signed integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        I8 = 9,

        /// <summary>An 8-byte unsigned integer.</summary>
        /// <remarks>When applied to Booleans (true != 0, false = 0)</remarks>
        U8 = 10,

        /// <summary>A 4-byte floating-point number.</summary>
        R4 = 11,

        /// <summary>An 8-byte floating-point number.</summary>
        /// <returns></returns>
        R8 = 12,

        /// <summary>A Unicode character string that is a length-prefixed double byte.</summary>
        BStr = 19,

        /// <summary>A single byte, null-terminated ANSI character string. </summary>
        LPStr = 20, // 0x00000014

        /// <summary>A 2-byte, null-terminated Unicode character string.</summary>
        LPWStr = 21,

        /// <summary>A platform-dependent character string: ANSI on Windows 98, and Unicode on Windows NT and Windows XP.</summary>
        LPTStr = 22,
        
        /// <summary>A UTF8-encoded, null-terminated character string.</summary>
        LPUTF8Str = 48,

        /// <summary>A platform-dependent, signed integer: 4 bytes on 32-bit, 8 bytes on 64-bit.</summary>
        /// <seealso cref="System.IntPtr" />
        SysInt = 31,

        /// <summary>A platform-dependent, unsigned integer: 4 bytes on 32-bit Windows, 8 bytes on 64-bit Windows.</summary>
        /// <seealso cref="System.UIntPtr" />
        SysUInt = 32,

        /// <summary>An ANSI character string that is a length-prefixed single byte.</summary>
        AnsiBStr = 35,

        /// <summary>A 2-byte, OLE-defined VARIANT_BOOL type (true = -1, false = 0).</summary>
        VariantBool = 37,

        /// <summary>
        /// A WinRT string.
        /// </summary>
        /// <remarks>
        /// Value is large enough such that any future additions to .NET's own UnmanagedType shouldn't conflict with
        /// this.
        /// </remarks>
        WinString = 0x44500001
    }
}
