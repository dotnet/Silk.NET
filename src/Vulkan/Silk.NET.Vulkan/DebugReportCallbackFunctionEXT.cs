using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate uint DebugReportCallbackFunctionEXT(
        uint flags,
        DebugReportObjectTypeEXT objectType,
        ulong @object,
        UIntPtr location,
        int messageCode,
        byte* pLayerPrefix,
        byte* pMessage,
        void* pUserData);
}