using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate uint DebugUtilsMessengerCallbackFunctionEXT
    (
        DebugReportFlagsEXT flags,
        DebugReportObjectTypeEXT objectType,
        ulong @object,
        UIntPtr location,
        int messageCode,
        char* pLayerPrefix,
        char* pMessage,
        void* pUserData
    );
}
