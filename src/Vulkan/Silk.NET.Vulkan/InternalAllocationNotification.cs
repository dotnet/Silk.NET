using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate void InternalAllocationNotification(
        void* pUserData,
        nuint size,
        InternalAllocationType allocationType,
        SystemAllocationScope allocationScope);
}