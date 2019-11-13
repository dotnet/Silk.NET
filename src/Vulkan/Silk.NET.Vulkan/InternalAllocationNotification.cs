using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate void InternalAllocationNotification(
        void* pUserData,
        UIntPtr size,
        InternalAllocationType allocationType,
        SystemAllocationScope allocationScope);
}