// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;
using Silk.NET.GLFW;
using Silk.NET.Vulkan;
using Silk.NET.Vulkan.Extensions.EXT;
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
        private ExtDebugUtils _debugUtils;
        private string[] _validationLayers = {"VK_LAYER_KHRONOS_validation"};

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
            throw new NotImplementedException();
        }

        private void CreateLogicalDevice()
        {
            throw new NotImplementedException();
        }

        private void CreateSwapChain()
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
