using System.Buffers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Unicode;

namespace Silk.NET.Core;

/// <summary>
/// Contains marshalling utilities.
/// </summary>
public static class SilkMarshal
{
    /// <summary>
    /// Converts a string into its native representation such that the returned ref can be passed to native.
    /// </summary>
    /// <param name="str">The string to convert.</param>
    /// <param name="charSize">Character size. Must be 1, 2, or 4.</param>
    /// <returns>A reference to the converted bytes.</returns>
    /// <exception cref="ArgumentException">
    /// Either:
    /// <list type="bullet">
    /// <item><description>The character size was not 1, 2 or 4.</description></item>
    /// <item><description><see cref="Utf8.FromUtf16"/> failed.</description></item>
    /// </list>
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly byte StringToNative(ReadOnlySpan<char> str, nint charSize = 1)
    {
        if (Unsafe.IsNullRef(ref Unsafe.AsRef(in str.GetPinnableReference())))
        {
            return ref Unsafe.NullRef<byte>();
        }

        switch (charSize)
        {
            case 1:
            {
                var maxCharCount = Encoding.UTF8.GetMaxByteCount(str.Length) + 1;
                byte[]? arr = null;
                var utf8 = maxCharCount > 256
                    ? arr = ArrayPool<byte>.Shared.Rent(maxCharCount)
                    : stackalloc byte[maxCharCount];
                if (Utf8.FromUtf16(str, utf8, out _, out var bytesWritten) != OperationStatus.Done)
                {
                    throw new ArgumentException("Failed to convert to UTF8", nameof(str));
                }

                utf8 = utf8[..(bytesWritten + 1)];
                utf8[bytesWritten] = 0;
                var ret = new byte[utf8.Length];
                utf8.CopyTo(ret);
                if (arr is not null)
                {
                    ArrayPool<byte>.Shared.Return(arr);
                }
                return ref ret[0];
            }
            case 2:
            {
                return ref Unsafe.As<char, byte>(ref Unsafe.AsRef(in str.GetPinnableReference()));
            }
            case 4:
            {
                var maxCharCount = Encoding.UTF32.GetMaxByteCount(str.Length) + 1;
                byte[]? arr = null;
                var utf32 = maxCharCount > 256
                    ? arr = ArrayPool<byte>.Shared.Rent(maxCharCount)
                    : stackalloc byte[maxCharCount];
                var bytesWritten = Encoding.UTF32.GetBytes(str, utf32);
                utf32 = utf32[..(bytesWritten + 1)];
                utf32[bytesWritten] = 0;
                var ret = new byte[utf32.Length];
                utf32.CopyTo(ret);
                if (arr is not null)
                {
                    ArrayPool<byte>.Shared.Return(arr);
                }
                return ref ret[0];
            }
            default:
            {
                throw new ArgumentException("Invalid char size, must be 1, 2, or 4", nameof(charSize));
            }
        }
    }

    /// <summary>
    /// Creates a pointer from a reference.
    /// </summary>
    /// <param name="ref"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static ConstPtr<T> AsPtr<T>(ref this T @ref) where T: unmanaged => new() { Ref = @ref };
}
