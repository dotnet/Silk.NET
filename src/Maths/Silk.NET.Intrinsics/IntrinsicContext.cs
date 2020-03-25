using System;
using Silk.NET.Intrinsics.Avx;
using Silk.NET.Intrinsics.Software;
using Silk.NET.Intrinsics.Sse;

namespace Silk.NET.Intrinsics
{
    public static class IntrinsicContext<T>
        where T:unmanaged
    {
        private static IIntrinsicContext<T> _context;
        public static IIntrinsicContext<T> Context => _context ??= GetContext();
        public static unsafe IWorkUnit<T> LoadScalar(T* ptr) => Context.LoadScalar(ptr);
        public static unsafe IWorkUnit<T> LoadVector2(T* ptr) => Context.LoadVector2(ptr);
        public static unsafe IWorkUnit<T> LoadVector3(T* ptr) => Context.LoadVector3(ptr);
        public static unsafe IWorkUnit<T> LoadVector4(T* ptr) => Context.LoadVector4(ptr);
        public static unsafe IWorkUnit<T> LoadScalar(ref T reference) { fixed (T* ptr = &reference){ return Context.LoadScalar(ptr); } }
        public static unsafe IWorkUnit<T> LoadVector2(ref T reference) { fixed (T* ptr = &reference){ return Context.LoadVector2(ptr); } }
        public static unsafe IWorkUnit<T> LoadVector3(ref T reference) { fixed (T* ptr = &reference){ return Context.LoadVector3(ptr); } }
        public static unsafe IWorkUnit<T> LoadVector4(ref T reference) { fixed (T* ptr = &reference){ return Context.LoadVector4(ptr); } }
        public static IWorkUnit<T> LoadScalar(T value) => LoadScalar(ref value);
        public static IWorkUnit<T> LoadVector2(T value) => LoadVector2(ref value);
        public static IWorkUnit<T> LoadVector3(T value) => LoadVector3(ref value);
        public static IWorkUnit<T> LoadVector4(T value) => LoadVector4(ref value);

        private static IIntrinsicContext<T> GetContext()
        {
            if (typeof(T) == typeof(float))
            {
                if (AvxIntrinsicContext.Instance.IsSupported)
                {
                    return (IIntrinsicContext<T>)(object)AvxIntrinsicContext.Instance;
                }
                if (SseIntrinsicContext.Instance.IsSupported)
                {
                    return (IIntrinsicContext<T>)(object)SseIntrinsicContext.Instance;
                }

                return (IIntrinsicContext<T>)(object)SoftwareIntrinsicContext.Instance;
            }

            throw new NotSupportedException
            (
                "No mathematical/intrinsic context registered for this type (is it a numerical type?)"
            );
        }
    }
}
