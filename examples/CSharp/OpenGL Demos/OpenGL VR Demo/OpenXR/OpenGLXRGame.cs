// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.OpenXR;
using Silk.NET.OpenXR.Extensions.EXT;
using Silk.NET.OpenXR.Extensions.KHR;

namespace OpenGL_VR_Demo.OpenXR
{
    public abstract class OpenGLXRGame : IDisposable
    {
        // API Objects for accessing OpenXR and OpenGL
        public XR Xr;

        // ExtDebugUtils is a handy OpenXR debugging extension which we'll enable if available unless told otherwise.
        public bool? IsDebugUtilsSupported;
        public ExtDebugUtils? ExtDebugUtils;

        // Hooking OpenXR up to graphics APIs requires specialized extensions. OpenGL and OpenGLES have separate ones,
        // but we'll make variables for both so we can support both.
        public KhrOpenglEnable? GlEnable;
        public KhrOpenglEsEnable? GlesEnable;
        public bool IsGles;
        public bool UseMinimumVersion;

        // Maintain a list of extensions we're using. Both for sanity and so we can tell OpenXR about them when creating
        // the instance.
        protected List<string> Extensions = new();

        // OpenXR handles
        public Instance Instance;
        public DebugUtilsMessengerEXT MessengerExt;
        
        // Our abstractions
        public System System;
        public Renderer? Renderer;
        
        // Ease-of-use properties
        public uint EyeWidth => System.RenderTargetSize.X / 2;
        public uint EyeHeight => System.RenderTargetSize.Y;
        
        // Misc
        public string Name;
        private bool _unmanagedResourcesFreed;

        protected OpenGLXRGame(string name, bool forceNoDebug = false, bool useMinimumVersion = false)
        {
            Name = name;
            if (forceNoDebug)
            {
                IsDebugUtilsSupported = false;
            }

            UseMinimumVersion = useMinimumVersion;
        }

        public void Run()
        {
            Prepare();
            Renderer?.Run();
        }

        /// <summary>
        /// A simple function which throws an exception if the given OpenXR result indicates an error has been raised.
        /// </summary>
        /// <param name="result">The OpenXR result in question.</param>
        /// <returns>
        /// The same result passed in, just in case it's meaningful and we just want to use this to filter out errors.
        /// </returns>
        /// <exception cref="Exception">An exception for the given result if it indicates an error.</exception>
        [DebuggerHidden]
        [DebuggerStepThrough]
        internal static Result CheckResult(Result result)
        {
            if ((int) result < 0)
            {
                throw new($"OpenXR raised an error! Code: {result} ({result:X})");
            }

            return result;
        }

        /// <summary>
        /// A function which checks if the extension with the given name is available, and adds it to the list of
        /// requested <see cref="Extensions"/> if so, returning true; or just returns false otherwise. 
        /// </summary>
        /// <param name="name">The extension name to check for and request.</param>
        /// <returns>Whether the extension was present or not.</returns>
        private bool TryRequestExtension(string name)
        {
            // Check if OpenXR supports the extension.
            if (Xr.IsInstanceExtensionPresent(null, name))
            {
                // It does! Add it to our list of requested extensions, for use when creating the instance later...
                Console.WriteLine($"[INFO] Application: Using extension {name}");
                Extensions.Add(name);
                return true;
            }

            // Oh dear! Not supported.
            Console.WriteLine($"[WARNING] Application: {name} is not supported.");
            return false;
        }

        private unsafe void Prepare()
        {
            // Create our API object for OpenXR.
            Xr = XR.GetApi();

            // If forceNoDebug is specified in the constructor, IsDebugUtilsSupported will already be false so we won't
            // request the extension whatsoever. Otherwise, request the extension!
            IsDebugUtilsSupported ??= TryRequestExtension(ExtDebugUtils.ExtensionName);

            // Let's request desktop GL first.
            if (!TryRequestExtension(KhrOpenglEnable.ExtensionName))
            {
                // No desktop GL? What about OpenGLES?
                if (!TryRequestExtension(KhrOpenglEsEnable.ExtensionName))
                {
                    throw new PlatformNotSupportedException
                    (
                        "Neither OpenGL nor OpenGLES is supported by OpenXR on this platform!"
                    );
                }

                // I guess we're using OpenGLES from now on!
                IsGles = true;
            }

            // Before we do anything, OpenXR needs to know a little about our application.
            var appInfo = new ApplicationInfo
            {
                ApiVersion = new Version64(1, 0, 9) // this is the OpenXR version number this demo is written against
            };

            // We've got to marshal our strings and put them into global, immovable memory. To do that, we use
            // SilkMarshal.
            SilkMarshal.StringIntoSpan(Name, MemoryMarshal.CreateSpan(ref appInfo.ApplicationName[0], 128));
            SilkMarshal.StringIntoSpan("Silk.NET Examples", MemoryMarshal.CreateSpan(ref appInfo.EngineName[0], 128));
            var requestedExtensions = SilkMarshal.StringArrayToPtr(Extensions);
            var instanceCreateInfo = new InstanceCreateInfo
            (
                applicationInfo: appInfo,
                enabledExtensionCount: (uint) Extensions.Count,
                enabledExtensionNames: (byte**) requestedExtensions
            );

            // If debug utils is supported, enable it!
            DebugUtilsMessengerCreateInfoEXT debugUtilsCreateInfo = default;
            if (IsDebugUtilsSupported.Value)
            {
                // This local function is called by OpenXR. There are a lot of advanced things you can do with the data
                // you get in DebugUtilsMessengerCallbackDataEXT, such as inspecting objects, but for now we're just
                // going to use the debug messenger as a simple OpenXR logger.
                static uint OnDebug
                (
                    DebugUtilsMessageSeverityFlagsEXT severity,
                    DebugUtilsMessageTypeFlagsEXT type,
                    DebugUtilsMessengerCallbackDataEXT* data,
                    void* userData
                )
                {
                    var severityString = severity
                        .ToString()["DebugUtilsMessageSeverity".Length..^"BitExt".Length]
                        .ToUpper();

                    var typeString = type.ToString()["DebugUtilsMessageType".Length..^"BitExt".Length];
                    
                    // Marshal OpenXR's byte* back to C# strings
                    var msgString = SilkMarshal.PtrToString((nint) data->Message);
                    var idString = SilkMarshal.PtrToString((nint) data->MessageId);

                    Console.WriteLine($"[{severityString}] {typeString}: {msgString} ({idString})");
                    return 0;
                }

                // Now that we've defined the callback, let's tell OpenXR about it and create our messenger!
                debugUtilsCreateInfo = new DebugUtilsMessengerCreateInfoEXT
                (
                    messageSeverities: DebugUtilsMessageSeverityFlagsEXT.DebugUtilsMessageSeverityErrorBitExt |
                                       DebugUtilsMessageSeverityFlagsEXT.DebugUtilsMessageSeverityWarningBitExt |
                                       DebugUtilsMessageSeverityFlagsEXT.DebugUtilsMessageSeverityInfoBitExt,
                    messageTypes: DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypeGeneralBitExt |
                                  DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypeConformanceBitExt |
                                  DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypePerformanceBitExt |
                                  DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypeValidationBitExt,
                    userCallback: (DebugUtilsMessengerCallbackFunctionEXT) OnDebug
                );

                instanceCreateInfo.Next = &debugUtilsCreateInfo;
            }

            // Now we're ready to make our instance!
            CheckResult(Xr.CreateInstance(in instanceCreateInfo, ref Instance));
            
            // Turn on debug logging
            if (IsDebugUtilsSupported.Value && Xr.TryGetInstanceExtension(null, Instance, out ExtDebugUtils))
            {
                Console.WriteLine
                (
                    ExtDebugUtils!.CreateDebugUtilsMessenger(Instance, in debugUtilsCreateInfo, ref MessengerExt)
                    != Result.Success
                        ? "[WARNING] Application: Failed to create OpenXR debug messenger!"
                        : "[INFO] Application: Debug messenger active."
                );
            }

            // For our benefit, let's log some information about the instance we've just created.
            InstanceProperties properties = new();
            CheckResult(Xr.GetInstanceProperties(Instance, ref properties));

            var runtimeName = SilkMarshal.PtrToString((nint) properties.RuntimeName);
            var runtimeVersion = ((Version) (Version64) properties.RuntimeVersion).ToString(3);
            
            Console.WriteLine($"[INFO] Application: Using OpenXR Runtime \"{runtimeName}\" v{runtimeVersion}");

            // We're creating a head-mounted-display (HMD, i.e. a VR headset) example, so we ask for a runtime which
            // supports that form factor. The response we get is a ulong that is the System ID.
            var systemId = 0UL;
            var getInfo = new SystemGetInfo(formFactor: FormFactor.HeadMountedDisplay);
            CheckResult(Xr.GetSystem(Instance, in getInfo, ref systemId));
            
            // Get the appropriate enabling extension, or fail if we can't.
            if (IsGles && !Xr.TryGetInstanceExtension(null, Instance, out GlesEnable) ||
                !IsGles && !Xr.TryGetInstanceExtension(null, Instance, out GlEnable))
            {
                throw new("Failed to get the graphics binding extension!");
            }
            
            // Let our abstractions take it from here!
            System = new(this, systemId);
            Renderer = new(this);
            
            // Subscribe to our renderer's callbacks
            Renderer.Load += Load;
            Renderer.Update += Update;
            Renderer.Render += Render;
            Renderer.Unload += Unload;
        }

        // These methods will be implemented by the game.
        protected abstract void Load();
        protected abstract void Update(double delta);
        protected abstract void Render(int eye, double delta);
        protected abstract void Unload();

        private void ReleaseUnmanagedResources()
        {
            if (_unmanagedResourcesFreed)
            {
                return;
            }

            CheckResult(Xr.DestroyInstance(Instance));
            CheckResult(ExtDebugUtils?.DestroyDebugUtilsMessenger(MessengerExt) ?? Result.Success);
            _unmanagedResourcesFreed = true;
        }

        private void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();
            if (disposing)
            {
                Xr.Dispose();
                ExtDebugUtils?.Dispose();
                GlEnable?.Dispose();
                GlesEnable?.Dispose();
                Renderer?.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~OpenGLXRGame()
        {
            Dispose(false);
        }
    }
}
