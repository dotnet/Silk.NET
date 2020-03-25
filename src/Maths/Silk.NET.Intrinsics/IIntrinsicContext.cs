// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Silk.NET.Intrinsics
{
    public interface IIntrinsicContext<T>
        where T:unmanaged
    {
        bool IsSupported { get; }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        unsafe IWorkUnit<T> LoadScalar(T* ptr);
        unsafe IWorkUnit<T> LoadVector2(T* ptr);
        unsafe IWorkUnit<T> LoadVector3(T* ptr);
        unsafe IWorkUnit<T> LoadVector4(T* ptr);
    }
}
