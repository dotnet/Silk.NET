// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsMessengerCallbackDataEXT")]
public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DebugUtilsMessengerCallbackDataEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("pMessageIdName")]
    public sbyte* PMessageIdName;

    [NativeName("messageIdNumber")]
    public int MessageIdNumber;

    [NativeName("pMessage")]
    public sbyte* PMessage;

    [NativeName("queueLabelCount")]
    public uint QueueLabelCount;

    [NativeName("pQueueLabels")]
    public DebugUtilsLabelEXT* PQueueLabels;

    [NativeName("cmdBufLabelCount")]
    public uint CmdBufLabelCount;

    [NativeName("pCmdBufLabels")]
    public DebugUtilsLabelEXT* PCmdBufLabels;

    [NativeName("objectCount")]
    public uint ObjectCount;

    [NativeName("pObjects")]
    public DebugUtilsObjectNameInfoEXT* PObjects;

    public DebugUtilsMessengerCallbackDataEXT() { }
}
