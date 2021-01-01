using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate void* ReallocationFunction(
        void* pUserData,
        void* pOriginal,
        nuint size,
        nuint alignment,
        SystemAllocationScope allocationScope);
}