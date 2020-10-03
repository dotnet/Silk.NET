// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// A function pointer.
    /// </summary>
    [Obsolete
    (
        "Function pointers are included as part of the language since C# 9." +
        "As such, this struct is obsolete and will be removed in 2.0"
    )]
    public struct FuncPtr : IDisposable
    {
        /// <summary>
        /// Convert an <see cref="IntPtr" /> to a FuncPtr.
        /// </summary>
        /// <param name="src">The pointer to convert.</param>
        /// <returns>The pointer as a FuncPtr.</returns>
        public static implicit operator FuncPtr(IntPtr src)
        {
            return new FuncPtr(src);
        }

        /// <summary>
        /// Convert a <see cref="Delegate" /> to a FuncPtr.
        /// </summary>
        /// <param name="delegate">The delegate to convert.</param>
        /// <returns>The delegate as a FuncPtr.</returns>
        public static implicit operator FuncPtr(Delegate @delegate)
        {
            return new FuncPtr(@delegate);
        }

        /// <summary>
        /// Convert a FuncPtr to an IntPtr.
        /// </summary>
        /// <param name="ptr">The FuncPtr to convert.</param>
        /// <returns>The FuncPtr as an IntPtr.</returns>
        public static implicit operator IntPtr(FuncPtr ptr)
        {
            return ptr.Value;
        }

        /// <summary>
        /// The value of the FuncPtr.
        /// </summary>
        public IntPtr Value { get; }

        /// <summary>
        /// Create a FuncPtr from a delegate.
        /// </summary>
        /// <param name="delegate">The delegate to convert.</param>
        /// <typeparam name="T">The type of the delegate.</typeparam>
        /// <returns>The resulting FuncPtr.</returns>
        public static FuncPtr Of<T>(T @delegate)
            where T : Delegate
        {
            return new FuncPtr(@delegate);
        }

        /// <summary>
        /// Create a new FuncPtr instance.
        /// </summary>
        /// <param name="ptr">The source pointer.</param>
        public FuncPtr(IntPtr ptr)
        {
            Value = ptr;
        }

        /// <summary>
        /// Create a new FuncPtr instance.
        /// </summary>
        /// <param name="delegate">The source delegate.</param>
        public FuncPtr(Delegate @delegate)
        {
            var handle = GCHandle.Alloc(@delegate);
            Value = Marshal.GetFunctionPointerForDelegate(@delegate);
            FuncPtrInternal.Storage.Add(Value, new FuncPtrInternal { Delegate = @delegate, Handle = handle });
        }

        /// <summary>
        /// Get this pointer as a delegate.
        /// </summary>
        /// <typeparam name="T">The delegate type.</typeparam>
        /// <returns>The resulting delegate.</returns>
        public T Get<T>()
            where T : Delegate
        {
            if (FuncPtrInternal.Storage.TryGetValue(Value, out var value))
            {
                return (T) value.Delegate;
            }

            return Marshal.GetDelegateForFunctionPointer<T>(Value);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            if (FuncPtrInternal.Storage.TryGetValue(Value, out var value))
            {
                value.Handle.Free();
            }

            FuncPtrInternal.Storage.Remove(Value);
        }
    }
}
