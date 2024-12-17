# Changelog/Version History

The second-level headings define the version number, and the contents below that header up until the next header define
the release notes. The first heading encountered is treated as the latest version for build purposes. The headings
should be in SemVer order.

Please read [the Contributions Guide](CONTRIBUTING.md) before writing release notes here!

## 3.0.0-preview

Silk.NET 3.0 Preview 1

- Added SDL3 bindings using the 3.0 bindings style.
- Added combined OpenGL bindings using the 3.0 bindings style.
- Improved the bindings style to be more accessible, IDE-friendly, and AOT-friendly. Learn more at **TODO ADD A LINK TO DOCUMENTATION HERE**.
- Removed SDL2 bindings.

This is the first preview of the rewritten Silk.NET 3.0 - the latest and greatest Silk.NET, laser-focused on addressing
pain points and reimagining how C# bindings libraries can be done. Functionality not present but not listed as removed
in the changelog will likely be available in a future 3.0 preview and hasn't been rewritten yet. Further information
about 3.0, including current status of 3.0 development, can be tracked at https://github.com/dotnet/Silk.NET/issues/209

## 2.22.0 (04/11/2024)

Silk.NET Mobile Update

- Added production-ready iOS support - wrap your Program.cs/IView code with SilkMobile.RunApp and run as-is!
- Added the ability to programmatically focus a window using IWindow.Focus(). (thanks @mayatskiy/@Arugin)
- Added a helper for custom IO in Assimp.
- Added a ToString implementation for Vulkan handles to display the handle value.
- Added some missing Flags attributes to enums, reducing the number of bitwise operation warnings on enums.
- Updated to Vulkan 1.3.300.
- Updated to OpenXR 1.1.42.
- Updated to SDL 2.30.8.
- Updated to MoltenVK 1.2.11.
- Updated to DXVK 2.4.1.
- Updated to OpenAL Soft 1.23.1.
- Updated to shaderc 2024.3.
- Updated to Assimp 5.4.1.
- Updated to latest OpenGL specifications.
- Updated to latest OpenCL specifications.
- Updated to ImGui.NET 1.90.8.1. (thanks @matt-edmondson)
- Updated DirectX/Windows bindings to 10.0.26100.0.
- Updated WebGPU/wgpu/dawn bindings.
- Updated SPIR-V Reflect, Cross, Headers, and Tools to their latest Vulkan 1.3.296 version.
- Updated ANGLE binaries for macOS. (thanks @ramezgerges/Uno Platform)
- Improved native binary packaging. (thanks @joskuijpers, @alexrp)
- Fixed Android 14/API 34 RECEIVER_EXPORTED/RECEIVER_NOT_EXPORTED errors.
- Fixed WGPU binaries being out of sync with the bindings API surface and crashing as a result.
- Fixed MultiNativeContext reporting present symbols as missing, affecting WGL, OpenAL, and Vulkan in some cases.
- Fixed native packages not correctly applying when being referenced transitively on .NET Framework and .NET 6+ mobile.
- Fixed windows being stuck when minimising where a recursive call to DoEvents in callbacks is used.
- Fixed changes to the standard cursor type not being accurately reflected on the GLFW backend.
- Fixed Silk.NET.Core not checking its own directory for native binaries.
- Fixed an ImGui memory leak. (thanks @rbertels)
- Fixed being unable to obtain Wayland window pointers when GLFW is compiled with both X11 and Wayland.
- Miscellaneous bugfixes and improvements.

Special thanks to Stride for sponsoring this 2.X update and our contributors for their contributions and continued interest in the project.
The Silk.NET team are hard at work on 3.0, with 2.X updates continuing with the support of contributors and sponsors.
Learn more at https://github.com/dotnet/Silk.NET

## 2.21.0 (23/04/2024)

Silk.NET April 2024 Update

- Added nint overloads for the cases where OpenGL represents a native-sized integer as a void pointer.
- Added support for executing Windowing loops during repaint and drag events on GLFW in some cases. (thanks @otac0n)
- Added a distinction between "unset" (-1) and "default" (null) for Windowing depth/stencil buffer bits, defaulting to 24/8 on all platforms unless overridden.
- Added support for 64-bit Arm Linux for Assimp, GLFW (+ Windowing &amp; Input), OpenAL Soft, SDL, Vkd3d, Vulkan Loader, SwiftShader, and WGPU. (thanks @alexrp)
- Added support for Apple Silicon Macs for OpenAL Soft, Vulkan Loader, and SwiftShader. (thanks @alexrp)
- Added support for 32-bit Arm Linux for Assimp, GLFW, OpenAL Soft, SDL, Shaderc, SPIR-V Cross, SPIR-V Reflect, Vkd3d, SwiftShader, and WGPU. (thanks @alexrp)
- Added support for 64-bit Windows on Arm for Assimp, OpenAL Soft, VulkanLoader, and SwiftShader. (thanks @alexrp)
- Added limited native library support (SPIR-V Tools and Shaderc) for glibc versions as old as 2.17 on Linux platforms.
- Added support for new standard cursor shapes in Input and GLFW.
- Updated to use `ref readonly` instead of `in`.
- Updated to OpenXR 1.1.36.
- Updated to DirectStorage 1.2.2.
- Updated to Vulkan 1.3.281.
- Updated to SDL 2.30.1.
- Updated to latest OpenCL specifications.
- Updated to latest SPIR-V Reflect.
- Updated to latest WebGPU/Dawn/WGPU headers.
- Updated Vkd3d native binaries.
- Fixed string marshalling occasionally resulting in memory access violations on newer .NET 8 versions.
- Fixed Windowing crashing on .NET Framework builds with prefer 32-bit set using GLFW.
- Fixed extension loading generic type usage issues with full IL trimming enabled.
- Fixed erroneous BreakneckLock acquisition logic slowing input events on mobile/SDL. (thanks @ZingBallyhoo)
- Fixed windowing losing events when using multiple windows on desktop with the mobile/SDL implementation. (thanks @ZingBallyhoo)
- Fixed some packages not referencing their native counterparts where appropriate. (thanks @alexrp)
- Fixed Input events for standalone joysticks not being tracked on GLFW.
- Fixed Input events no longer being tracked after 3-10 reopens of the same window on GLFW.
- Fixed V-Sync configuration not persisting over window state changes in Windowing.
- Fixed Circle.Contains erroneously comparing the squared vector distance from its center against its non-squared radius. (thanks @djoyahoy)

After this update:
- Apple Silicon support is complete except for missing ANGLE binaries.
- Arm Linux support is complete except for missing DXVK, ANGLE, and Vulkan Loader (missing on 32-bit only) binaries.
- 64-bit Windows on Arm support is complete except for missing DXVK and ANGLE binaries.
- 32-bit Windows on Arm remains unsupported except for DirectStorage.

## 2.20.0 (12/12/2023)

Silk.NET December 2023 Update

- Added support for UTF-8 file paths in GLFW and SDL windows (thanks @WinstonMao)
- Updated to OpenXR 1.0.32.1
- Updated to Vulkan 1.3.273
- Updated to latest OpenGL specifications
- Updated to latest OpenCL specifications
- Fixed Matrix2X2.GetDeterminant returning incorrect values
- Fixed ALC_SOFT_reopen_device being a non-context extension (thanks @okaniku, @doobah)

## 2.19.0 (14/11/2023)

Silk.NET November 2023 Update

- Updated to OpenXR 1.0.31
- Updated to Vulkan 1.3.270
- Updated to latest ImGui.NET, alleviating some incompatibilities introduced by the ImGui.NET team.
- Updated to latest OpenGL specifications
- Fixed OpenCL clCreateImage not functioning as expected with ImageDesc's ABI
- Fixed OpenAL throwing when loading an extension prefixed with ALC_ instead AL_

## 2.18.0 (21/10/2023)

Silk.NET October 2023 Update

- Added SPIR-V Reflect bindings
- Added SPIR-V Cross bindings
- Added Shaderc bindings
- Added WIC/WindowsCodecs bindings (thanks @hez2010)
- Added multi-channel formats support for OpenAL (thanks @aleksrutins)
- Added EffectTarget support for OpenAL Soft (thanks @okaniku, @doobah)
- Added MoltenVK support for iOS (massive thank you to @zvasya for contributing and testing)
- Added macOS support for the CreateWebGPUSurface helper function (thanks @AsgardXIV)
- Added the ability to load MoltenVK directly as a fallback should the Vulkan Loader be unavailable on macOS
- Added trimming support with an option to enable/disable static-linking support at link time
- Added WinRT interoperability support for Direct3D 11.
- Added the ability to query extensions from specific Vulkan layers using the Silk.NET helpers
- Added extension methods on IGamepad to return Thumbstick state instead of requiring use of the indexers (thanks @jvyden)
- Added ref properties for Vulkan chain constituents (thanks @khitiara)
- Added Apple Silicon binaries for Assimp (thanks @jschieck)
- Added compatibility with Linux distributions using as early as glibc 2.16
- Added equality operators and IEquatable to Bool32 (thanks @Syncaidius)
- Added ToSystem/ToGeneric as extension methods (rather than plain static functions) to convert to/from Silk.NET.Maths types (thanks @Wafer-EX)
- Added discriminant values to PinObjectMarshaller to tie pinned handles to state to which the pin pertains
- Updated to Vulkan 1.3.266
- Updated to OpenXR 1.0.30
- Updated to SDL 2.28.1
- Updated to MoltenVK 1.2.5
- Updated to latest WebGPU headers
- Updated to latest OpenCL specifications
- Updated to latest OpenGL specifications
- Improved allocations in the Silk.NET Loader (thanks @Youssef1313)
- Improved robustness of HLU on AOT compilations
- Fixed WGPU not loading with the correct filename on Windows
- Fixed COM V-Table indices not matching the Clang-reported V-Table index in some cases (DirectWrite/D2D1/DComp)
- Fixed OpenAL throwing when loading an extension prefixed with ALC_ instead AL_
- Fixed WGL.GetApi throwing a NotImplementedException
- Fixed library loading failing on platforms that do not have a libdl.so symlink (we are now using libdl.so.2, thanks @CasualPokePlayer)
- Fixed a StackOverflowException when using SetWindowIcon in some cases with Silk.NET.Windowing
- Fixed GLFW crashing in some cases where multiple windows are used
- Fixed WebGPU using the incorrect size for booleans
- Fixed a memory leak with some string marshalling functions

If you are using Silk.NET with an iOS or Android application, please enable trimming and set TrimMode to full.

## 2.17.1 (09/04/2023)

Fix a minor regression with some OpenGL Span overloads. Read more about the 2.17 update here: https://dotnet.github.io/Silk.NET/blog/apr-2023/silk2170.html

## 2.17.0 (06/04/2023)

Silk.NET Spring 2023 Update 1

- Added zero-cost extension methods for ComPtrs, making our DirectX bindings easier to use and higher quality than ever before.
- Added WebGPU bindings for Dawn and WGPU.
- Added Direct2D bindings. (massive thank you to @curin)
- Added DirectComposition bindings. (again, massive preesh to @curin)
- Added DirectWrite bindings.
- Added d3d11on12 bindings.
- Added WGL bindings.
- Added support for Android 12.
- Added support for OpenAL disconnect extension. (thanks @okaniku)
- Added GLFW API constants for ANGLE. (thanks @cyraid)
- Added extension functions for OpenAL BufferData to make use of AL_EXT_float32 enums.
- Added ReopenDevices extension for OpenAL Soft. (thanks @LeNitrous)
- Added BufferCallback extension for OpenAL Soft.
- Added Vulkan structure chain polymorphism. (thanks @Khitiara for the proposal)
- Added SDL/GLFW native libraries for Windows on ARM64.
- Added IsScancodePressed function in Silk.NET Input.
- Added TopMost in Silk.NET Windowing (thanks @MarioGK)
- Added EGL display and surface to INativeWindow.
- Added an explicit check against calling Reset on a window while within the render loop of said window.
- Added support for multiple native binary candidate paths for a single binding.
- Improved support for WASM and AOT in the Silk.NET loader.
- Improved support for Windows on ARM64.
- Improved Silk.NET.Maths generic specialization codegen.
- Improved support for DXVK, including a new DXHandle property in INativeWindow for getting Linux HWND equivalents.
- Improved support for Silk.NET.Windowing under reflection-free NativeAOT
- Updated to SDL 2.24.
- Updated to Vulkan 1.3.246.
- Updated to DirectStorage 1.1.1.
- Updated to OpenXR 1.0.27.
- Updated to Assimp 5.2.5.
- Updated to latest OpenCL specifications.
- Updated to latest OpenGL specifications.
- Updated to latest ImGui.
- Fixed XInput GetApi not being implemented. (thanks @skyebird189)
- Fixed TransparentBuffer not being applied correctly without specifying a PreferredBitDepth. (thanks @MarioGK)
- Fixed wide string marshalling.
- Fixed string array marshalling on systems where the max DBCS character size is insufficient for UTF8.
- Fixed Span overloads not calculating the correct length value for ommitted (implicit) length parameters.
- Fixed copying of native libraries under .NET Framework 4.6.1. (thanks @paralaxsd)
- Fixed SDL crashing on Android when the screen rotates in some cases.
- Fixed a memory leak when using GlobalMemory to marshal string arrays instead of StringArrayToPtr. (thanks @Khitiara)

## 2.17.0-preview (19/03/2023)

Silk.NET Spring 2023 Update 1 (EARLY PREVIEW)

- Added zero-cost extension methods for ComPtrs, making our DirectX bindings easier to use and higher quality than ever before.
- Added WebGPU bindings for Dawn and WGPU.
- Added Direct2D bindings. (massive thank you to @curin)
- Added DirectComposition bindings. (again, massive preesh to @curin)
- Added d3d11on12 bindings.
- Added WGL bindings.
- Added support for OpenAL disconnect extension. (thanks @okaniku)
- Added extension functions for OpenAL BufferData to make use of AL_EXT_float32 enums.
- Added ReopenDevices extension for OpenAL Soft. (thanks @LeNitrous)
- Added BufferCallback extension for OpenAL Soft.
- Added Vulkan structure chain polymorphism. (thanks @Khitiara for the proposal)
- Added SDL/GLFW native libraries for Windows on ARM64.
- Added IsScancodePressed function in Silk.NET Input.
- Added TopMost in Silk.NET Windowing (thanks @MarioGK)
- Added EGL display and surface to INativeWindow.
- Added an explicit check against calling Reset on a window while within the render loop of said window.
- Improved support for WASM and AOT in the Silk.NET loader.
- Improved support for Windows on ARM64.
- Improved Silk.NET.Maths generic specialization codegen.
- Improved support for DXVK, including a new DXHandle property in INativeWindow for getting Linux HWND equivalents.
- Updated to SDL 2.24.
- Updated to Vulkan 1.3.242.
- Updated to DirectStorage 1.1.0.
- Updated to OpenXR 1.0.26.
- Updated to latest OpenCL specifications.
- Updated to latest OpenGL specifications.
- Updated to latest ImGui.
- Fixed XInput GetApi not being implemented. (thanks @ohtorobinson)
- Fixed TransparentBuffer not being applied correctly without specifying a PreferredBitDepth. (thanks @MarioGK)
- Fixed wide string marshalling.

## 2.16.0 (02/08/2022)

Silk.NET Summer 2022 Update 1

- Massive project-wide bindings overhaul, making our bindings easier to use and higher quality than before.
- Added grouped OpenCL enums. (thanks @Alexx999)
- Added support for creation of contexts with versions prior to OpenGL 3.2. (thanks @Beyley)
- Added support for multiple ImGuiControllers. (thanks @Beyley)
- Added support for single-file mode. (thanks @kant2002)
- Added shorter names in enums used in bindings.
- Added AspectRatioEstimate API to VideoMode. (thanks @ohtrobinson)
- Update to latest OpenGL specifications
- Update to OpenXR 1.0.24
- Update to Vulkan 1.3.223
- Improved ImGuiController disposal. (thanks @Beyley)
- Fixed incorrect OpenCL functions. This is breaking, but if you were using these functions your code didn't work anyway. (thanks @Alexx999)
- Fixed IsVisible not being respected in some cases. (thanks @paralaxsd)
- Fixed window close events not being respected on the SDL backend. (thanks @paralaxsd)

This update may result in your projects having a lot of deprecation warnings. We believe this update contains much-needed improvements to both Silk.NET and code consuming it, but we appeciate migrating to this version may take time.

## 2.15.0 (02/04/2022)

Silk.NET April 2022 Update

- Add DirectStorage bindings
- Add legacy OpenGL 2.0 support for the ImGui extension (thank you @Beyley)
- Add the ability to customize the functionality/priorities of DefaultPathResolver
- Add more auto-generated constants to Assimp, DirectX, and SDL
- Update to Vulkan 1.3.210
- Update to latest OpenGL specifications
- Fix Assimp native package being out-of-sync with latest binding
- Fix SDL input backend producing different key mappings to the GLFW input backend
- Fix Android Activity restarts not being properly handled by Silk.NET Windowing

## 2.14.0 (15/03/2022)

Silk.NET March 2022 Update

- Add a Version13 convenience property (thanks @Eeveelution)
- Add DXGI_CREATE_FACTORY_DEBUG Constant to DXGI (thanks @Eeveelution)
- Update to Vulkan 1.3.207
- Update to latest OpenCL specifications
- Update to latest OpenGL specifications
- Fix SilkMarshal.StringToPtr throwing "buffer is too small to contain the encoded data" in some cases
- Fix Direct3D11 having its own ID3D10Blob type
- Fix Assimp using the wrong quaternion types
- Fix SDL windowing backend causing lots of allocations
- Fix GLFW windowing backend circular reference/memory leak

This release may be breaking for users, but those users who experience breaking changes most likely had code that didn't work anyway.

## 2.13.0 (06/02/2022)

Silk.NET February 2022 Update

- Add an OpenGLES version of the ImGui plugin (thanks @Beyley)
- Add an initial version of a Rider/ReSharper plugin to open Khronos specifications with one click (may not be available for install immediately)
- Update to OpenXR 1.0.22
- Update to Vulkan 1.2.203
- Update to latest OpenCL specifications
- Fix mouse scroll wheels state not always being up-to-date on the SDL backend (thanks @paralaxsd)

In addition, thanks to @roeyskoe for contributing lots of behind-the-scenes changes to improve the Silk.NET native packaging experience.

## 2.12.0 (07/01/2022)

Silk.NET January 2022 Update

- Add support for retrieving the clipboard text on IKeyboard (thanks @Beyley)
- Add a constructor for customizing the ImGui configuration before ImGuiController applies its configuration (thanks @sampletext32)
- Add Flags attributes to all bitmasks generated from C++ headers (i.e. DirectX), fixing warnings on usage
- Update to latest OpenCL specifications
- Update to Vulkan 1.2.203 (from 1.2.201, not 1.2.210 as the previous update indicated)
- Fix input information being one or two frames behind due to running in DoUpdate instead of DoEvents
- Fix BuildTools incorrectly defaulting to Cdecl instead of Winapi (fixes 32-bit issues)
- Fix string marshalling not allocating enough memory for multibyte UTF8 strings
- Fix a DivideByZeroException in PointToFramebuffer thrown in some circumstances
- Fix SymbolLoadingExceptions on usage of GetStringList functions in OpenAL

## 2.11.0 (06/12/2021)

Silk.NET December 2021 Update

- Add a high-level C# wrapper over Vulkan Structure Chains (thanks @thargy).
- Add a WindowClass option in Windowing for setting the X11 class name (thanks @Pydacor)
- Add a IsContextControlDisabled option in Windowing to disable automatically making OpenGL contexts current
- Add support for cloning Vk objects to allow reuse of their function tables independently
- Update to latest OpenCL specifications
- Update to latest OpenGL and OpenGLES specifications
- Update to Vulkan 1.2.210
- Fix string marshalling regression which resulted in multiple string-overloaded functions throwing
- Fix multiple input-related problems when using the SDL backend of our Windowing abstractions
- Discontinued support for Legacy Xamarin (exclusively supporting .NET 6 mobile from now on)

## 2.10.1 (10/11/2021)

Silk.NET .NET Conf 2021 Update

- Fixes issues with 2.10 (compiled against .NET 6 RC1) not working correctly in projects using the .NET 6 Release SDK.

## 2.10.0 (06/11/2021)

Silk.NET November 2021 Update

- Added support for BigInteger and Complex in the Silk.NET.Maths.Scalar APIs. (thanks @WhiteBlackGoose)
- Added helper constructors for maths types (Rectangle, Box2D, Box3D, etc). (thanks @nathan-alden-sr)
- Added bitwise APIs to Silk.NET.Maths.Scalar. (thanks @WhiteBlackGoose)
- Added support for configuring OpenGL multisamping.
- Updated to Vulkan 1.2.197.
- Updated to latest OpenCL specifications.
- Updated to latest OpenGL specifications.
- Updated DirectX and Win32 bindings to Windows 11 SDK.
- Removed redundant references with no DLLs (i.e. BCL/legacy packages not needed on newer platforms, thanks @nathan-alden-sr @WhiteBlackGoose)
- Removed problematic implicit-in OpenGL overloads (fixes the infamous VertexAttribPointer bug)
- Fixed incorrect character encoding of keyboard (text) input on the SDL backend. (thanks @roeyskoe)
- Fixed native libraries not being resolved despite being present in the "runtimes" folder.
- Miscellaneous documentation fixes and improvements.

## 2.9.0 (05/10/2021)

Silk.NET October 2021 Update

- Add bindings for DirectX Video Acceleration (DXVA)
- Add bindings for D3D9Ex
- Add bindings for extra core Win32 APIs (as required by DXVA)
- Add a .NET 6 code path for GlobalMemory using NativeMemory
- Add more TFMs in addition to .NET Standard 2.0 for DirectX bindings
- Add enhanced anonymous struct support with ref-returning properties on .NET Standard 2.1 and up
- Update to Vulkan 1.2.194
- Update to latest OpenCL specifications
- Fix MarshalDirectiveException when a struct containing a char passes across a native boundary
- Fix Vulkan out parameters not having their structure type set before passing across the native boundary
- Fix native libraries not being found in some cases for self-contained executables

## 2.8.0 (04/09/2021)

Silk.NET September 2021 Update

- Add TryGetExtension methods to AL &amp; ALContext
- Add support for .NET 6 Android
- Update to Vulkan 1.2.190
- Update to OpenXR 1.0.19
- Update to latest OpenGL specifications
- Update to latest OpenCL specifications
- Fix calling CreateInput on an uninitialized IView resulting in a AccessViolationException
- Fix calling Close on an uninitialized IView resulting in an AccessViolationException
- Fix Silk.NET (and by extension SDL) taking full control of orientation on Android
- Fix DoRender being called if Window.Close was called during DoUpdate
- Fix Scalar.Abs for double values
- Fix "Pfn" function pointer structures being marshalled with the incorrect calling convention
- Fix Scalar.IsNaN and Scalar.IsInfinity returning true for non floating point types
- Fix Box2D.Center returning bogus values
- Fix incorrect documentation in Thumbstick.Direction
- Fix incorrect documentation in WindowOptions

## 2.7.0 (09/08/2021)

Silk.NET August 2021 Update

- Add code signing to all Silk.NET binaries
- Add support for platform-default calling conventions
- Update to latest OpenGL specifications
- Update to Vulkan 1.2.187
- Update to OpenXR 1.0.18
- Fix loading some OpenAL extensions

## 2.6.0 (03/07/2021)

Silk.NET July 2021 Update

- Add support for OpenAL Soft native libraries for ALContext
- Update to Vulkan 1.2.183
- Update to latest OpenCL specifications
- Fix struct layout issues in DirectX and OpenXR bindings
- Fix OpenCL library name resolution on Linux
- Fix NU5127, NU5128, and NU1701 native package NuGet errors on .NET Framework
- Improve FileNotFoundExceptions when native library loading fails
- Improve GlobalMemory call chains by removing unnecessary usage of Span&lt;T&gt;

## 2.5.0 (08/06/2021)

Silk.NET June 2021 Update

- OpenXR bindings are now production-ready &amp; no longer experimental!
- Add (optional) native binaries for OpenAL Soft
- Add support for reversed-z projection matrices in Silk.NET.Maths
- Add bindings for a number of missing Vulkan and OpenCL extensions
- Add OpenGL-OpenXR interoperability helper APIs
- Add more helper APIs in Silk.NET.Core and Silk.NET.Maths
- Update to latest OpenGL and OpenGLES specifications
- Update to OpenXR 1.0.16
- Update to Vulkan 1.2.180
- Fix SDL OpenGL context issues when not using OpenGL
- Fix GLFW native window issues on 32-bit Windows
- Fix OpenXR loading issues
- Fix incorrect bindings in OpenXR
- Miscellaneous windowing &amp; input bugfixes &amp; improvements

## 2.4.0 (07/05/2021)

Silk.NET May 2021 Update

- Add As methods to all Maths types &amp; other miscellaneous API additions
- Add support for provisional Vulkan Video encoding &amp; decoding extensions
- Update to latest OpenGL specification
- Update to latest OpenCL specification
- Update to Vulkan 1.2.177
- Update to OpenXR 1.0.15
- Fix ImGui robustness
- Fix disposal and reset robustness
- Fix SDL input backend not respecting deadzones
- Fix GLFW input backend not respecting start-up state
- Fix Vulkan device function pointer loader bugs
- Fix BSTR GlobalMemory issues
- Fix Vulkan codegen issues
- Fix bitfield codegen for Vulkan &amp; clang-generated bindings
- Miscellaneous windowing &amp; input bugfixes

## 2.3.0 (03/04/2021)

Silk.NET April 2021 Update

- Add a new Silk.NET.OpenGL.Extensions.ImGui package, a first-party ImGui integration for Silk.NET.OpenGL
- Add support for native method definitions across multiple partial classes
- Add improved SDL exception throwing, only throwing when a function indicates an error
- Updated metadata to reference .NET Foundation and dotnet following our .NET Foundation onboarding
- Update to SDL 2.0.14
- Update to GLFW 3.3.3
- Miscellaneous build system related fixes
- Miscellaneous SourceLink related fixes

## 2.2.0 (06/03/2021)

Silk.NET March 2021 Update

- Add memory pooling for Input State Capture extensions
- Add Input State Capture stability and robustness improvements
- Update to Vulkan 1.2.171
- Update to latest OpenGL as of 22nd February 2021
- Update to latest OpenCL as of 2nd March 2021
- Fix window disposal/reset bugs
- Fix a build toolchain issue where packages released in Debug mode (#416)
- Fix a string marshalling issue and OpenAL regression (#414)

## 2.1.0 (16/02/2021)

Silk.NET February 2021 Update

- Add native handles for Windowing
- Add Veldrid support
- Add support for macro constants
- Add support for unnamed nested anonymous struct fields
- Add better name hinting for anonymous types
- Add support for OpenGL token reuse for tokens that had been previously deprecated and removed, fixing #400
- Add nested anonymous struct "fusion" with their parent structs, allowing direct ref access on .NET Standard 2.1 platforms without going through the anonymous field
- Add static Guid members for structs with a COM interface ID
- Fix struct field size and type variation between 32-bit and 64-bit in generated C++ bindings
- Fix calling convention detection, and actually respect the calling convention we detect
- Fix being unable to specify calling convention using NativeApiAttribute
- Fix some type issues
- Fix accidental initialization of both platforms, resolving #407
- Fix zero-length string allocation resulting in an IndexOutOfRangeException exception by clamping the allocation length to 1, resolving #396
- Fix unreasonably small delta times when running a window with OpenGL V-Sync enabled
- Fix faulty addition in Silk.NET.Maths where (u)ints were produced by (s)byte and (u)short addition, resulting in an invalid cast
- Fix malformed XML in MSBuild targets included by Silk.NET.Windowing.Sdl.Android, resolving #405

This should be treated as an "emergency patch" and you should update as soon as reasonably practicable. Some of the bugs
in 2.0 are fatal in some workloads.

## 2.0.0 (02/01/2021)

Silk.NET January 2021 Update - 2.0, the largest Silk.NET update to date

- Adds Assimp bindings
- Adds SDL bindings
- Adds a SDL windowing backend
- Adds a new, AOT-friendly interop system (SilkTouch)
- Adds Android support
- Adds a generic, flexible maths library to fill in the holes left by System.Numerics
- Adds an initial set of Microsoft DirectX bindings
- Adds improved function pointer support
- Adds more OpenGL framebuffer bit-depth options
- Adds shared OpenGL contexts
- (EXPERIMENTAL!) Adds OpenXR bindings
- (EXPERIMENTAL!) Adds iOS support
- Massive performance improvements
- GLFW fixes
- Windowing and Input fixes/refactorings
- OpenCL and OpenAL improvements
- Vulkan bug fixes
- Miscellaneous bug fixes and improvements

This release may be breaking and will likely require some modification in updating existing code to it. Please contact
us in our Discord server if this is the case. We'll do our best to publish a migration guide shortly.

## 2.0.0-preview5 (29/12/2020)

Includes everything from the last previews, as well as:
- Maths packaging fixes
- Improved function pointer support
- Vulkan bug fixes
- OpenGL VSync fixes
- Miscellaneous Linux library loading improvements (#279)
- More OpenGL framebuffer bit-depth options (#286)
- Shared OpenGL contexts (#334)
- SDL windowing improvements (#350)
- Minor assembly size improvements (#374)
- Other miscellaneous fixes and improvements

This is the last 2.0 preview before full release, and is a production-ready "go live" release. Feel free to use this in
new applications.

## 2.0.0-preview4 (08/12/2020)

Includes everything from the last previews, as well as:
- A generic, flexible maths library to fill in the holes left by System.Numerics
- An initial set of Microsoft DirectX bindings
- Miscellaenous fixes and improvements

Silk.NET v1.9.0 was the last version of Silk.NET v1.X as this release (2.0 Preview 4) is a production-ready "go live"
release. Feel free to use this in new applications.

## 2.0.0-preview3 (17/11/2020)

Includes everything from the last previews, as well as:
- Experimental Android support
- Experimental iOS support
- Add static linking support to SilkTouch
- Surface API improvements
- SilkTouch improvements
- OpenCL and OpenAL improvements
- Other miscellaneous bug fixes and improvements

## 2.0.0-preview2 (21/08/2020)

Includes everything from the last previews, as well as:
- SDL bindings
- A SDL windowing backend
- A new, AOT-friendly interop system
- A new and improved overload system and bindings API surface
- Miscellaneous OpenXR and GLFW fixes
- Miscellaneous windowing and input fixes and refactorings

## 2.0.0-preview (15/07/2020)

Includes Assimp and experimental OpenXR bindings.

## 1.9.0 (04/12/2020)

Silk.NET December 2020 Update - The Final Silk.NET 1.x Update

- Update to latest specifications.
- Miscellaneous bug fixes and improvements.

## 1.8.0 (06/11/2020)

Silk.NET November 2020 Update

- Update to latest specifications.
- Miscellaneous bug fixes and improvements.

## 1.7.0 (02/10/2020)

Silk.NET October 2020 Update

- Add a BorderSize property and GetFullSize extension method to IWindow for working with window borders.
- Add a Center extension method which will center the window to a monitor.
- Update to latest specifications.
- Miscellaneous bug fixes and improvements.

## 1.6.0 (04/09/2020)

Silk.NET September 2020 Update

- Add a byte* overload to Glfw.GetError
- Make GlfwProvider throw if Glfw.Init fails
- Update to latest specifications
- Miscellaneous bug fixes and improvements

## 1.5.0 (07/08/2020)

Silk.NET August 2020 Update

- Update to Vulkan 1.2.149
- Update OpenCL
- Add a Time property to IView, tracking the seconds since window initialization
- Add a Run method to IView, which will invoke a delegate as fast as possible (required for 2.0 and mobile)
- Fix more first-chance exceptions

## 1.4.0 (03/07/2020)

Silk.NET July 2020 Update

- Update to OpenCL v3.0.1 (Provisional Specification)
- Update to Vulkan v1.2.145
- Update to SuperInvoke v1.1.0
- Added an IGLContext implementation (GlfwContext) to Silk.NET.GLFW
- Added glfwSetFramebufferSizeCallback to Silk.NET.GLFW
- Fixed some cases of first-chance exceptions when loading native libraries
- Miscellaneous bug fixes and improvements

## 1.3.0 (05/06/2020)

Silk.NET June 2020 Update

- FPS stabilization improvements
- Vulkan loader improvements
- Support EGL_NV_stream_consumer_eglimage

## 1.2.1 (16/05/2020)

Silk.NET 1.2.1 Patch Update

- Updated to the latest OpenCL specification
- Updated to Vulkan 1.2.141
- Added a ContinueEvents method to force an event-driven game loop to continue
- Added support for IGLContext in GL instances (this was slated for 1.2.0, but left out for some reason)
- Moved GlfwLoader out of Silk.NET.Windowing.Desktop and into Silk.NET.GLFW

## 1.2.0 (01/05/2020)

Silk.NET May 2020 Update

- Update to Vulkan 1.2.139
- Update to OpenCL 3.0
- Add a new context abstraction
- Add extensions for using Silk.NET's Windowing API with Veldrid
- Add a new way of accessing OpenGL-specific and Vulkan-specific functions
- Add a helpful hint as to why your Vulkan functions are throwing EntryPointNotFoundExceptions.
- Add ExtensionName constants to all extension classes (useful for Vulkan)
- Add an option for waiting for events before proceeding to execute the render loop.
- Add a setter to the IsClosing property so you can cancel window closure
- Fix the incorrect DebugUtilsMessengerCallbackFunctionEXT signature
- Fix a bug where you couldn't catch GlfwExceptions on Linux and macOS
- Fix a bug where attempting to call Invoke on a window will result in a deadlock
- Fix a bug where VSync was always on regardless of the requested configuration
- Fix a bug where eventhough we fixed the previous VSync bug, we still weren't respecting initial vsync settings.
- Fix a bug where directly accessing scroll-wheel info would return bogus data
- Fix a bug where Render and Update are fired again after close
- Deprecated adaptive vsync
- Deprecated SilkManager
- Deprecated obsolete native methods that we weren't annotating as obsolete before
- Miscellaneous fixes and improvements

## 1.1.1 (13/04/2020)

Silk.NET 1.1.1 Hotfix

- Fix OpenAL symbol loading bugs
- Fix a bug where gamepad button states weren't stored correctly
- Fix a bug where the Close method wouldn't trigger the Close event

## 1.1.0 (05/04/2020)

Silk.NET April 2020 Update

- Add Input Capture Extensions
- Add transparent framebuffers
- Fix miscellaneous bugs in OpenAL
- Updated to Vulkan 1.2.136
- Updated OpenCL to include 2.2's latest experimental features

## 1.0.1 (17/03/2020)

This is a small patch fixing some small Vulkan-specific bugs within Silk.NET.

- Updated to Vulkan 1.2.135 (March 17, 2020)
- Fixed Vulkan extension loading
- Fixed Vulkan windowing
- Fixed some typos in autogenerated method names

## 1.0.0 (08/03/2020)

This is the first full release of Silk.NET. Changes since Preview 5:

- Add window icons
- Add more in-depth OpenGL context-management methods.
- Add click events
- Add OpenGL direct state access overloads
- Add Vulkan boolean & version helpers

## 1.0.0-preview5 (18/02/2020)

Silk.NET 1.0 Preview 5

- Added cursor modes
- Added EGL bindings (no windowing backend yet)
- Rewrite the overload system, hopefully resulting in overloads that make sense.
- Miscellaenous Silk.NET.Core improvements
- Updated to SuperInvoke 1.0.3, encompassing a lot of bug fixes.
- Updated to GLFW 3.3.2, encompassing a lot of bug fixes.
- Fix an infinite loop in OpenAL's GetStringList methods
- Other bug fixes

As a result of the new overload system, some work may be required to migrate to Preivew 5 from an earlier
preview.

## 1.0.0-preview4 (08/02/2020)

- Added OpenCL
- Added monitor support
- Added view/window separation (in preparation for mobile support in a later release)
- Added monitors and video modes
- Fixed vsync
- Removed AdvancedDLSupport in favour of SuperInvoke
- Removed dispatcher
- Removed other unused/unnecessary packages

## 1.0.0-preview3 (15/11/2019)

- Added Vulkan
- Added mouse movement
- Added gamepad rumble (though it hasn't been implemented in GLFW yet)
- Added macOS support
- Added more overloads, as well as fixed the existing ones.
- Added DoRender, DoUpdate, DoEvents, Open, Reset, and IsClosing members for custom game loops
- Added KeyChar for receiving text input (modifiers applied)
- Added strongly-typed enum groupings for OpenGL and OpenGLES
- Fixed extension loading
- Fixed a bug where strings weren't marshalled properly
- Fixed a bug where some shaders didn't compile correctly
- Fixed a bug where some programs didn't link correctly
- Fixed various OpenAL bugs
- Removed all built-in thread management, the user will have to take care of this themselves.
- Synchronised the enum of all available keys with that of GLFW

## 1.0.0-preview2 (10/08/2019)

- Fixed a bug where calling an unloaded OpenGL function will throw a GlfwException.
- Fixed a bug where GLFW wasn't swapping the buffers (no drawing will ever make it to the window!)
- Refactored Silk.NET.Core, unifying the platform loading logic.
- Renamed OnRender to Render + other windowing events

## 1.0.0-preview (04/08/2019)

- First preview release
