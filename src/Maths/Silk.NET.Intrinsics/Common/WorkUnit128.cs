using System.Runtime.Intrinsics;

namespace Silk.NET.Intrinsics
{
    internal struct WorkUnit128<T> where T:unmanaged
    {   
        public WorkUnitFlags Flags { get; set; }
        public Vector128<T> Vector { get; set; }
        public unsafe fixed byte Padding[16];
    }
}