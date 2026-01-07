# Vulkan-Specific Views and Windows (i.e. IVulkanView, IVulkanWindow)
## Information
- Introduced in Preview 3
- Active in 1.1.1
- Deprecated in 1.2
- Removed in 2.0

## Why are we removing it?
Currently, Vulkan-specific functions are accessed by first checking if a IView or IWindow supports Vulkan, and then 
casting the IView or IWindow to a IVulkanView or IVulkanWindow respectively. This can get quite messy. As such, we
decided to instead move all API or platform specific functions into interfaces accessed via a nullable property in
IView and IWindow, as follows:

### Old
```cs
if (window.IsVulkanSupported && window is IVulkanWindow vkWindow)
{
    vkWindow.CreateSurface(...);
}
```

### New

```cs
if (window.VkSurface != null)
{
    window.VkSurface.CreateSurface(...);
}
```

All OpenGL functions will get the same treatment, but both the Vulkan-specific and OpenGL-specific functions will
continue to be accessible through the main IView and IWindow interfaces through extension methods.
