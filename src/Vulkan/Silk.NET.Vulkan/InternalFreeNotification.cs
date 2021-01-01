using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate void InternalFreeNotification(
        void* pUserData,
        nuint size,
        InternalAllocationType allocationType,
        SystemAllocationScope allocationScope);
}