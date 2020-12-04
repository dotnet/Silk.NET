namespace Silk.NET.OpenXR
{
    public unsafe delegate uint DebugUtilsMessengerCallbackFunctionEXT
    (
        DebugUtilsMessageSeverityFlagsEXT messageSeverity,
        DebugUtilsMessageTypeFlagsEXT messageTypes,
        DebugUtilsMessengerCallbackDataEXT* pCallbackData,
        void* pUserData
    );
}
