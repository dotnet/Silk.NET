# Library-Specific Notes

This document's purpose is to note down any decisions or quirks that are specific to a library that Silk is generating
bindings for.

This is meant to be a living document. Please update this as new work is being done on the generator.

## OpenAL

Currently empty.

## OpenGL

Currently empty.

## SDL

Currently empty.

## Vulkan

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
