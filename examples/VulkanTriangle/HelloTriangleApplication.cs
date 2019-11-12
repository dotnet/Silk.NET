// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;
using Silk.NET.GLFW;
using Silk.NET.Vulkan;
using Silk.NET.Vulkan.Extensions.EXT;
using Silk.NET.Vulkan.Extensions.KHR;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;
using Image = Silk.NET.Vulkan.Image;
using Queue = Silk.NET.Vulkan.Queue;

namespace VulkanTriangle
{
    public class HelloTriangleApplication
    {
        public const bool EnableValidationLayers = true;
        
        public void Run()
        {
            InitWindow();
            InitVulkan();
            MainLoop();
            Cleanup();
        }

        private IVulkanWindow _window;
        
        private Instance _instance;
        private DebugUtilsMessengerEXT _debugMessenger;
        private SurfaceKHR _surface;

        private PhysicalDevice _physicalDevice;
        private Device _device;

        private Queue _graphicsQueue;
        private Queue _presentQueue;

        private SwapchainKHR _swapchain;
        private Image[] _swapchainImages;
        private Format _swapchainImageFormat;
        private Extent2D _swapchainExtent;
        private ImageView[] _swapchainImageViews;
        private Framebuffer _swapchainFramebuffer;

        private RenderPass _renderPass;
        private PipelineLayout _pipelineLayout;
        private Pipeline _graphicsPipeline;

        private CommandPool _commandPool;
        private CommandBuffer[] _commandBuffers;

        private Semaphore[] _imageAvailableSemaphores;
        private Semaphore[] _renderFinishedSemaphores;
        private Fence _inFlightFences;
        private Fence _imagesInFlight;
        private UIntPtr _currentFrame;

        private Vk _vk;
        private KhrSurface _vkSurface;
        private KhrSwapchain _vkSwapchain;
        private ExtDebugUtils _debugUtils;
        private string[] _validationLayers = {"VK_LAYER_KHRONOS_validation"};
        private string[] _deviceExtensions = {"VK_KHR_SWAPCHAIN_EXTENSION_NAME"};

        private void InitWindow()
        {
            var opts = WindowOptions.DefaultVulkan;
            _window = Window.Create(opts) as IVulkanWindow;
            if (_window is null)
            {
                throw new NotSupportedException("Windowing platform doesn't support Vulkan.");
            }
        }

        private void InitVulkan()
        {
            CreateInstance();
            SetupDebugMessenger();
            CreateSurface();
            PickPhysicalDevice();
            CreateLogicalDevice();
            CreateSwapChain();
            CreateImageViews();
            CreateRenderPass();
            CreateGraphicsPipeline();
            CreateFramebuffers();
            CreateCommandPool();
            CreateCommandBuffers();
            CreateSyncObjects();
        }

        private void MainLoop()
        {
            throw new NotImplementedException();
        }

        private void Cleanup()
        {
            throw new System.NotImplementedException();
        }

        private unsafe void CreateInstance()
        {
            if (EnableValidationLayers && !CheckValidationLayerSupport())
            {
                throw new NotSupportedException("Validation layers requested, but not available!");
            }
            
            _vk = Vk.GetApi();
            if (!_vk.TryGetExtension(out _vkSurface))
            {
                throw new NotSupportedException("KHR_surface extension not found.");
            }
            
            if (!_vk.TryGetExtension(out _vkSwapchain))
            {
                throw new NotSupportedException("KHR_swapchain extension not found.");
            }

            var appInfo = new ApplicationInfo()
            {
                SType = StructureType.ApplicationInfo,
                PApplicationName = (char*) Marshal.StringToHGlobalAnsi("Hello Triangle"),
                ApplicationVersion = MakeVersion(1, 0, 0),
                PEngineName = (char*) Marshal.StringToHGlobalAnsi("No Engine"),
                EngineVersion = MakeVersion(1, 0, 0),
                ApiVersion = MakeVersion(1, 1, 0),
            };

            var createInfo = new InstanceCreateInfo
            {
                SType = StructureType.InstanceCreateInfo,
                PApplicationInfo = &appInfo,
            };

            var extensions = _window.GetRequiredExtensions(out var extCount);
            createInfo.EnabledExtensionCount = extCount;
            createInfo.PpEnabledExtensionNames = extensions;

            if (EnableValidationLayers)
            {
                createInfo.EnabledLayerCount = (uint) _validationLayers.Length;
                createInfo.PpEnabledLayerNames = (char**) SilkMarshal.MarshalStringArrayToPtr(_validationLayers);
            }
            else
            {
                createInfo.EnabledLayerCount = 0;
                createInfo.PNext = null;
            }

            fixed (Instance* instance = &_instance)
            {
                if (_vk.CreateInstance(&createInfo, null, instance) != Result.Success)
                {
                    throw new Exception("Failed to create instance!");
                }
            }
            
            Marshal.FreeHGlobal((IntPtr) appInfo.PApplicationName);
            Marshal.FreeHGlobal((IntPtr) appInfo.PEngineName);
            SilkMarshal.FreeStringArrayPtr((IntPtr) createInfo.PpEnabledLayerNames, _validationLayers.Length);
        }

        private unsafe void SetupDebugMessenger()
        {
            if (!EnableValidationLayers) return;
            if (!_vk.TryGetExtension(out _debugUtils)) return;

            var createInfo = new DebugUtilsMessengerCreateInfoEXT();
            PopulateDebugMessengerCreateInfo(ref createInfo);

            fixed (DebugUtilsMessengerEXT* debugMessenger = &_debugMessenger)
            {
                if (_debugUtils.CreateDebugUtilsMessenger
                        (_instance, &createInfo, null, debugMessenger) != Result.Success)
                {
                    throw new Exception("Failed to create debug messenger.");
                }
            }
        }

        private unsafe void PopulateDebugMessengerCreateInfo(ref DebugUtilsMessengerCreateInfoEXT createInfo)
        {
            createInfo.SType = StructureType.DebugUtilsMessengerCreateInfoExt;
            createInfo.MessageSeverity = DebugUtilsMessageSeverityFlagsEXT.DebugUtilsMessageSeverityVerboseBitExt |
                                         DebugUtilsMessageSeverityFlagsEXT.DebugUtilsMessageSeverityWarningBitExt |
                                         DebugUtilsMessageSeverityFlagsEXT.DebugUtilsMessageSeverityErrorBitExt;
            createInfo.MessageType = DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypeGeneralBitExt |
                                     DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypePerformanceBitExt |
                                     DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypeValidationBitExt;
            createInfo.PfnUserCallback = new FuncPtr<DebugUtilsMessengerCallbackFunctionEXT>(DebugCallback);
        }

        private unsafe uint DebugCallback
        (
            DebugReportFlagsEXT flags,
            DebugReportObjectTypeEXT objecttype,
            ulong o,
            UIntPtr location,
            int messagecode,
            char* playerprefix,
            char* pmessage,
            void* puserdata
        )
        {
            Console.Write("[" + flags.ToString().Replace("DebugReport", string.Empty) + "] ");
            Console.Write(Marshal.PtrToStringAnsi((IntPtr) playerprefix) + "/");
            Console.Write(objecttype.ToString().Replace("DebugReportObjectType", string.Empty)[..^3]);
            Console.WriteLine(": " + Marshal.PtrToStringAnsi((IntPtr) pmessage));
            return Vk.False;
        }

        private unsafe void CreateSurface()
        {
            _surface = _window.CreateSurface<AllocationCallbacks>(_instance.ToHandle(), null).ToSurface();
        }

        private unsafe void PickPhysicalDevice()
        {
            var deviceCount = 0u;
            _vk.EnumeratePhysicalDevices(_instance, &deviceCount, null);

            if (deviceCount == 0)
            {
                throw new NotSupportedException("Failed to find GPUs with Vulkan support.");
            }

            var devices = stackalloc PhysicalDevice[(int) deviceCount];
            _vk.EnumeratePhysicalDevices(_instance, &deviceCount, devices);

            for (var i = 0; i < deviceCount; i++)
            {
                var device = devices[i];
                if (IsDeviceSuitable(device))
                {
                    _physicalDevice = device;
                    return;
                }
            }
        }

        private bool IsDeviceSuitable(PhysicalDevice device)
        {
            QueueFamilyIndices indices = FindQueueFamilies(device);

            bool extensionsSupported = CheckDeviceExtensionSupport(device);

            bool swapChainAdequate = false;
            if (extensionsSupported) {
                SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(device);
                swapChainAdequate = swapChainSupport.Formats.Length != 0 && swapChainSupport.PresentModes.Length != 0;
            }

            return indices.IsComplete() && extensionsSupported && swapChainAdequate;
        }

        private unsafe SwapChainSupportDetails QuerySwapChainSupport(PhysicalDevice device)
        {
            var details = new SwapChainSupportDetails();
            _vkSurface.GetPhysicalDeviceSurfaceCapabilities(device, _surface, out var surfaceCapabilities);
            details.Capabilities = surfaceCapabilities;
            
            var formatCount = 0u;
            _vkSurface.GetPhysicalDeviceSurfaceFormats(device, _surface, &formatCount, null);

            if (formatCount != 0)
            {
                details.Formats = new SurfaceFormatKHR[formatCount];
                var formats = stackalloc SurfaceFormatKHR[(int) formatCount];
                _vkSurface.GetPhysicalDeviceSurfaceFormats(device, _surface, &formatCount, formats);

                for (var i = 0; i < formatCount; i++)
                {
                    details.Formats[i] = formats[i];
                }
            }

            var presentModeCount = 0u;
            _vkSurface.GetPhysicalDeviceSurfacePresentModes(device, _surface, &presentModeCount, null);

            if (presentModeCount != 0)
            {
                details.PresentModes = new PresentModeKHR[presentModeCount];
                // TODO.....
            }
        }

        private unsafe bool CheckDeviceExtensionSupport(PhysicalDevice device)
        {
            uint extensionCount;
            _vk.EnumerateDeviceExtensionProperties(device, (char*)null, &extensionCount, null);

            var availableExtensions = stackalloc ExtensionProperties[(int) extensionCount];
            _vk.EnumerateDeviceExtensionProperties(device, (char*) null, &extensionCount, availableExtensions);

            var requiredExtensions = new List<string>();
            requiredExtensions.AddRange(_deviceExtensions);
            
            for (var i = 0u; i < extensionCount; i++)
            {
                requiredExtensions.Remove(Marshal.PtrToStringAnsi((IntPtr) availableExtensions[i].ExtensionName));
            }

            return requiredExtensions.Count == 0;
        }

        private unsafe QueueFamilyIndices FindQueueFamilies(PhysicalDevice device)
        {
            var indices = new QueueFamilyIndices();

            uint queryFamilyCount = 0;
            _vk.GetPhysicalDeviceQueueFamilyProperties(device, &queryFamilyCount, null);

            var queueFamilies = stackalloc QueueFamilyProperties[(int) queryFamilyCount];

            for (var i = 0u; i < queryFamilyCount; i++)
            {
                var queueFamily = queueFamilies[i];
                // note: HasFlag is slow on .NET Core 2.1 and below.
                // if you're targeting these versions, use ((queueFamily.QueueFlags & QueueFlags.QueueGraphicsBit) != 0)
                if (queueFamily.QueueFlags.HasFlag(QueueFlags.QueueGraphicsBit))
                {
                    indices.GraphicsFamily = i;
                }

                _vkSurface.GetPhysicalDeviceSurfaceSupport(device, i, _surface, out var presentSupport);

                if (presentSupport == Vk.True)
                {
                    indices.PresentFamily = i;
                }

                if (indices.IsComplete())
                {
                    break;
                }
            }

            return indices;
        }

        public struct QueueFamilyIndices {
            public uint? GraphicsFamily { get; set; }
            public uint? PresentFamily { get; set; }

            public bool IsComplete()
            {
                return GraphicsFamily.HasValue && PresentFamily.HasValue;
            }
        };

        public struct SwapChainSupportDetails {
            public SurfaceCapabilitiesKHR Capabilities { get; set; }
            public SurfaceFormatKHR[] Formats { get; set; }
            public PresentModeKHR[] PresentModes { get; set; }
        };

        private unsafe void CreateLogicalDevice()
        {
            var indices = FindQueueFamilies(_physicalDevice);
            var uniqueQueueFamilies = new[] {indices.GraphicsFamily.Value, indices.PresentFamily.Value};
            var queueCreateInfos = stackalloc DeviceQueueCreateInfo[uniqueQueueFamilies.Length];

            var queuePriority = 1f;
            for (int i = 0; i < uniqueQueueFamilies.Length; i++)
            {
                var queueCreateInfo = new DeviceQueueCreateInfo
                {
                    SType = StructureType.DeviceQueueCreateInfo,
                    QueueFamilyIndex = uniqueQueueFamilies[i],
                    QueueCount = 1,
                    PQueuePriorities = &queuePriority
                };
                queueCreateInfos[i] = queueCreateInfo;
            }

            var deviceFeatures = new PhysicalDeviceFeatures();

            var createInfo = new DeviceCreateInfo();
            createInfo.SType = StructureType.DeviceCreateInfo;
            createInfo.QueueCreateInfoCount = (uint) uniqueQueueFamilies.Length;
            createInfo.PQueueCreateInfos = queueCreateInfos;
            createInfo.PEnabledFeatures = &deviceFeatures;
            createInfo.EnabledExtensionCount = (uint) _deviceExtensions.Length;

            var enabledExtensionNames = SilkMarshal.MarshalStringArrayToPtr(_deviceExtensions);
            createInfo.PpEnabledExtensionNames = (char**) enabledExtensionNames;

            if (EnableValidationLayers)
            {
                createInfo.EnabledLayerCount = (uint) _validationLayers.Length;
                createInfo.PpEnabledLayerNames = (char**) SilkMarshal.MarshalStringArrayToPtr(_validationLayers);
            }
            else
            {
                createInfo.EnabledLayerCount = 0;
            }

            if (_vk.CreateDevice(_physicalDevice, &createInfo, null, &_device))
            {
                throw new Exception("Failed to create logical device.");
            }

            fixed (Queue* graphicsQueue = &_graphicsQueue)
            {
                _vk.GetDeviceQueue(_device, indices.GraphicsFamily.Value, 0, graphicsQueue);
            }

            fixed (Queue* presentQueue = &_presentQueue)
            {
                _vk.GetDeviceQueue(_device, indices.PresentFamily.Value, 0, presentQueue);
            }
        }

        private unsafe void CreateSwapChain()
        {
            SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(_physicalDevice);

            SurfaceFormatKHR surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.Formats);
            PresentModeKHR presentMode = ChooseSwapPresentMode(swapChainSupport.PresentModes);
            Extent2D extent = ChooseSwapExtent(swapChainSupport.Capabilities);

            uint imageCount = swapChainSupport.Capabilities.MinImageCount + 1;
            if (swapChainSupport.Capabilities.MaxImageCount > 0 &&
                imageCount > swapChainSupport.Capabilities.MaxImageCount)
            {
                imageCount = swapChainSupport.Capabilities.MaxImageCount;
            }

            var createInfo = new SwapchainCreateInfoKHR
            {
                SType = StructureType.SwapchainCreateInfoKhr,
                Surface = _surface,
                MinImageCount = imageCount,
                ImageFormat = surfaceFormat.Format,
                ImageColorSpace = surfaceFormat.ColorSpace,
                ImageExtent = extent,
                ImageArrayLayers = 1,
                ImageUsage = ImageUsageFlags.ImageUsageColorAttachmentBit,
            };

            QueueFamilyIndices indices = FindQueueFamilies(_physicalDevice);
            uint[] queueFamilyIndices = {indices.GraphicsFamily.Value, indices.PresentFamily.Value};

            fixed (uint* qfiPtr = queueFamilyIndices)
            {
                if (indices.GraphicsFamily != indices.PresentFamily)
                {
                    createInfo.ImageSharingMode = SharingMode.Concurrent;
                    createInfo.QueueFamilyIndexCount = 2;
                    createInfo.PQueueFamilyIndices = qfiPtr;
                }
                else
                {
                    createInfo.ImageSharingMode = SharingMode.Exclusive;
                }

                createInfo.PreTransform = swapChainSupport.Capabilities.CurrentTransform;
                createInfo.CompositeAlpha = CompositeAlphaFlagsKHR.CompositeAlphaOpaqueBitKhr;
                createInfo.PresentMode = presentMode;
                createInfo.Clipped = Vk.True;

                createInfo.OldSwapchain = default;

                fixed (SwapchainKHR* swapchain = &_swapchain)
                {
                    if (_vkSwapchain.CreateSwapchain(_device, &createInfo, null, swapchain) != Result.Success)
                    {
                        throw new Exception("failed to create swap chain!");
                    }
                }
            }

            _vkSwapchain.GetSwapchainImages(_device, _swapchain, &imageCount, null);
            _swapchainImages = new Image[imageCount];
            fixed (Image* swapchainImage = _swapchainImages)
            {
                _vkSwapchain.GetSwapchainImages(_device, _swapchain, &imageCount, swapchainImage);
            }

            _swapchainImageFormat = surfaceFormat.Format;
            _swapchainExtent = extent;
        }

        private Extent2D ChooseSwapExtent(SurfaceCapabilitiesKHR capabilities)
        {
            if (capabilities.CurrentExtent.Width != uint.MaxValue)
            {
                return capabilities.CurrentExtent;
            }

            var actualExtent = new Extent2D
                {Height = (uint) _window.Size.Height, Width = (uint) _window.Size.Width};
            actualExtent.Width = new[]
            {
                capabilities.MinImageExtent.Width,
                new uint[] {capabilities.MaxImageExtent.Width, actualExtent.Width}.Min()
            }.Max();
            actualExtent.Height = new[]
            {
                capabilities.MinImageExtent.Height,
                new uint[] {capabilities.MaxImageExtent.Height, actualExtent.Height}.Min()
            }.Max();

            return actualExtent;
        }

        private PresentModeKHR ChooseSwapPresentMode(PresentModeKHR[] presentModes)
        {
            foreach (var availablePresentMode in presentModes)
            {
                if (availablePresentMode == PresentModeKHR.PresentModeMailboxKhr)
                {
                    return availablePresentMode;
                }
            }

            return PresentModeKHR.PresentModeFifoKhr;
        }

        private SurfaceFormatKHR ChooseSwapSurfaceFormat(SurfaceFormatKHR[] formats)
        {
            throw new NotImplementedException();
        }

        private void CreateImageViews()
        {
            throw new NotImplementedException();
        }

        private void CreateRenderPass()
        {
            throw new NotImplementedException();
        }

        private void CreateGraphicsPipeline()
        {
            throw new NotImplementedException();
        }

        private void CreateFramebuffers()
        {
            throw new NotImplementedException();
        }

        private void CreateCommandPool()
        {
            throw new NotImplementedException();
        }

        private void CreateCommandBuffers()
        {
            throw new NotImplementedException();
        }

        private void CreateSyncObjects()
        {
            throw new NotImplementedException();
        }

        private uint MakeVersion(uint major, uint minor, uint patch)
        {
            return (major << 22) | (minor << 12) | patch;
        }

        private unsafe bool CheckValidationLayerSupport()
        {
            uint layerCount = 0;
            _vk.EnumerateInstanceLayerProperties(&layerCount, (LayerProperties*) 0);

            var availableLayers = new LayerProperties[layerCount];
            fixed (LayerProperties* availableLayersPtr = availableLayers)
                _vk.EnumerateInstanceLayerProperties(&layerCount, availableLayersPtr);

            foreach (var layerName in _validationLayers)
            {
                bool layerFound = false;

                foreach (var layerProperties in availableLayers)
                {
                    if (layerName == Marshal.PtrToStringAnsi((IntPtr) layerProperties.LayerName))
                    {
                        layerFound = true;
                        break;
                    }
                }

                if (!layerFound)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
