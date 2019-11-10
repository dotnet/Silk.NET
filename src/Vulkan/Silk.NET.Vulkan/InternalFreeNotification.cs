using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate void InternalFreeNotification(
        void* pUserData,
        UIntPtr size,
        InternalAllocationType allocationType,
        SystemAllocationScope allocationScope);
}