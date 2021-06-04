// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.OpenXR;
using static OpenGL_VR_Demo.OpenXR.OpenGLXRGame;

namespace OpenGL_VR_Demo.OpenXR
{
    /// <summary>
    /// An abstraction over an OpenXR system.
    /// </summary>
    public class System
    {
        // Variables
        private readonly OpenGLXRGame _game; // keep a reference to our game, it probably has some APIs we want.
        private readonly XR _xr; // ease-of-access variable for our XR API
        private readonly SystemProperties _props; // cache this system's properties.
        
        // Properties
        /// <summary>The System ID.</summary>
        public ulong Id { get; init; }

        /// <summary>The System Name, marshalled from the Name property in the SystemProperties struct.</summary>
        public unsafe string Name
            => SilkMarshal.PtrToString((nint) Unsafe.AsPointer(ref Unsafe.AsRef(in _props.SystemName[0])))!;

        /// <summary>The maximum width of swapchain images for this system</summary>
        public uint MaxSwapchainImageWidth => _props.GraphicsProperties.MaxSwapchainImageWidth;

        /// <summary>The maximum width of swapchain images for this system</summary>
        public uint MaxSwapchainImageHeight => _props.GraphicsProperties.MaxSwapchainImageHeight;

        /// <summary>The maximum number of layers in swapchain images for this system</summary>
        public uint MaxLayerCount => _props.GraphicsProperties.MaxLayerCount;
        
        /// <summary>A <see cref="ViewConfigurationView"/> for each eye on the HMD system.</summary>
        public ViewConfigurationView[] ViewConfigs { get; init; }
        
        /// <summary>The size of the render target. This render target encapsulates both eyes.</summary>
        public Vector2D<uint> RenderTargetSize { get; init; }

        public unsafe System(OpenGLXRGame game, ulong id)
        {
            _game = game;
            _xr = game.Xr;
            Id = id;

            CheckResult(_xr.GetSystemProperties(_game.Instance, Id, ref _props));

            // Log some stuff about the system we've selected for our benefit
            Console.WriteLine($"[INFO] Application: Using OpenXR System with ID {Id}.");
            Console.WriteLine($"    Name: {Name}");
            Console.WriteLine($"    Max Swapchain Image Size: {MaxSwapchainImageWidth}x{MaxSwapchainImageHeight}");
            Console.WriteLine($"    Max Swapchain Image Layers: {MaxLayerCount}");
            
            // Get the ViewConfigurationViews - these tell us about the images we should create for the eyes in the
            // headset.
            var viewConfigCount = 0u;
            CheckResult
            (
                // First, get the number of configurations.
                _xr.EnumerateViewConfigurationView
                (
                    _game.Instance, Id, ViewConfigurationType.PrimaryStereo, viewConfigCount, ref viewConfigCount, null
                )
            );

            // Last time I checked humans only have 2 eyes, and I don't feel like making an example for spiders today.
            if (viewConfigCount != 2)
            {
                throw new($"Unexpected number of eyes (got {viewConfigCount})");
            }

            ViewConfigs = new ViewConfigurationView[viewConfigCount]; // make an appropriately-sized array
            CheckResult
            (
                _xr.EnumerateViewConfigurationView
                (
                    _game.Instance, Id, ViewConfigurationType.PrimaryStereo, ref viewConfigCount, ViewConfigs
                )
            );

            var recommended = $"{ViewConfigs[0].RecommendedImageRectWidth}x{ViewConfigs[0].RecommendedImageRectHeight}";
            var max = $"{ViewConfigs[0].MaxImageRectWidth}x{ViewConfigs[0].MaxImageRectHeight}";

            // More sanity checking, making sure each eye has the same recommended/max resolution.
            if (ViewConfigs[0].RecommendedImageRectWidth != ViewConfigs[1].RecommendedImageRectWidth ||
                ViewConfigs[0].RecommendedImageRectHeight != ViewConfigs[1].RecommendedImageRectHeight ||
                ViewConfigs[0].MaxImageRectWidth != ViewConfigs[1].MaxImageRectWidth ||
                ViewConfigs[0].MaxImageRectHeight != ViewConfigs[1].MaxImageRectHeight)
            {
                throw new
                (
                    "Per-eye images have different max or recommended dimensions!\n"+
                    $"Eye 0: recommended {recommended} max {max}\n" +
                    "Eye 1: recommended " +
                    $"{ViewConfigs[1].RecommendedImageRectWidth}x{ViewConfigs[1].RecommendedImageRectHeight}" +
                    "max " +
                    $"{ViewConfigs[1].MaxImageRectWidth}x{ViewConfigs[1].MaxImageRectHeight}"
                );
            }
            
            Console.WriteLine($"[INFO] Application: Using recommended per-eye resolution {recommended} (max {max})");

            // Instead of creating a swapchain per-eye, we create a single swapchain of double width.
            RenderTargetSize = new(ViewConfigs[0].RecommendedImageRectWidth, ViewConfigs[0].RecommendedImageRectHeight);
        }
    }
}
