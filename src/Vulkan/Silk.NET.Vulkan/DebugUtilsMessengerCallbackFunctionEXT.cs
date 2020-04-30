using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate uint DebugUtilsMessengerCallbackFunctionEXT
    (
        DebugUtilsMessageSeverityFlagsEXT messageSeverity,
        DebugUtilsMessageTypeFlagsEXT messageTypes,
        DebugUtilsMessengerCallbackDataEXT* pCallbackData,
        void* pUserData
    );
}
