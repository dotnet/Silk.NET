// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// Represents a native string encoding.
    /// </summary>
    public enum NativeStringEncoding
    {
        /// <summary>
        /// A Unicode character string that is a length-prefixed double byte.
        /// </summary>
        /// <seealso cref="UnmanagedType.BStr" />
        BStr = UnmanagedType.BStr,
        /// <summary>
        /// A single byte, null-terminated ANSI character string.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPStr" />
        /// <seealso cref="Ansi" />
        LPStr = UnmanagedType.LPStr,
        /// <summary>
        /// A platform-dependent character string: ANSI on Windows 98, and Unicode on Windows NT and Windows XP.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPTStr" />
        /// <seealso cref="Auto" />
        LPTStr = UnmanagedType.LPTStr,
        /// <summary>
        /// A pointer to a UTF-8 encoded string.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPUTF8Str" />
        /// <seealso cref="UTF8"/>
        LPUTF8Str = UnmanagedType.LPUTF8Str,
        /// <summary>
        /// A 2-byte, null-terminated Unicode character string.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPWStr" />
        /// <seealso cref="Uni" />
        LPWStr = UnmanagedType.LPWStr,
        /// <summary>
        /// A single byte, null-terminated ANSI character string.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPStr" />
        /// <seealso cref="LPStr" />
        Ansi = LPStr,
        /// <summary>
        /// A platform-dependent character string: ANSI on Windows 98, and Unicode on Windows NT and Windows XP.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPTStr" />
        /// <seealso cref="LPTStr" />
        Auto = LPTStr,
        /// <summary>
        /// A 2-byte, null-terminated Unicode character string.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPWStr" />
        /// <seealso cref="LPWStr" />
        Uni = LPWStr,
        /// <summary>
        /// A pointer to a UTF-8 encoded string.
        /// </summary>
        /// <seealso cref="UnmanagedType.LPUTF8Str" />
        /// <seealso cref="LPUTF8Str" />
        UTF8 = LPUTF8Str
    }
}
