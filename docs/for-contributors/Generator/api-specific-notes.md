# API-Specific Notes

This document's purpose is to note down any decisions or quirks that are specific to a library that Silk is generating
bindings for. It is fine for a section to be empty if we do not have any notes specific to that library.

This is meant to be a living document. Please update this as new work is being done on the generator.

Certain APIs are grouped together because they share similar characteristics.

## C Bindings

These are APIs that can be categorized as being straightforward C APIs or are C APIs that simply do not share
characteristics with other bindings.

### SDL

Currently empty.

## Khronos-like Bindings

These are APIs managed either by Khronos or APIs managed in a similar way to the official Khronos APIs.

### OpenAL

Spec file used: https://raw.githubusercontent.com/kcat/openal-soft/master/registry/xml/al.xml

### OpenGL

Spec file used: https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/main/xml/gl.xml

### OpenXR

Spec file used: https://raw.githubusercontent.com/KhronosGroup/OpenXR-SDK/main/specification/registry/xr.xml

### Vulkan

Spec file used: https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml

There will be the following errors in the generation log. This is expected. These types are part of the XML
specification, but not part of the main `vulkan.h` header.

For more information: https://github.com/dotnet/Silk.NET/pull/2457#issuecomment-2910293716

```
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkFullScreenExclusiveEXT" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkFaultLevel" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkFaultType" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkFaultQueryBehavior" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkPipelineMatchControl" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkSciSyncClientTypeNV" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkSciSyncPrimitiveTypeNV" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkPipelineCacheValidationVersion" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkDisplacementMicromapFormatNV" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
fail: Silk.NET.SilkTouch.Mods.MixKhronosData[0] Enum "VkCompressedTriangleFormatAMDX" has no base type. Please add TypeMap entry to the configuration. This enum group will be skipped.
```
