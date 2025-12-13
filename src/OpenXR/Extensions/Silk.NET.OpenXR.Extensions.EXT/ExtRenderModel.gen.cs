// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_render_model")]
    public unsafe partial class ExtRenderModel : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_render_model";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelCreateInfoEXT* createInfo, [Count(Count = 0)] RenderModelEXT* renderModel);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelCreateInfoEXT* createInfo, [Count(Count = 0)] ref RenderModelEXT renderModel);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelCreateInfoEXT createInfo, [Count(Count = 0)] RenderModelEXT* renderModel);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateRenderModel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelCreateInfoEXT createInfo, [Count(Count = 0)] ref RenderModelEXT renderModel);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelAssetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModelAsset([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetCreateInfoEXT* createInfo, [Count(Count = 0)] RenderModelAssetEXT* asset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelAssetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModelAsset([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetCreateInfoEXT* createInfo, [Count(Count = 0)] ref RenderModelAssetEXT asset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelAssetEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModelAsset([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelAssetCreateInfoEXT createInfo, [Count(Count = 0)] RenderModelAssetEXT* asset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelAssetEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateRenderModelAsset([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelAssetCreateInfoEXT createInfo, [Count(Count = 0)] ref RenderModelAssetEXT asset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelSpaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModelSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelSpaceCreateInfoEXT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelSpaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModelSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelSpaceCreateInfoEXT* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelSpaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateRenderModelSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelSpaceCreateInfoEXT createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateRenderModelSpaceEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateRenderModelSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelSpaceCreateInfoEXT createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyRenderModelEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroyRenderModel([Count(Count = 0)] RenderModelEXT renderModel);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyRenderModelAssetEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroyRenderModelAsset([Count(Count = 0)] RenderModelAssetEXT asset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelAssetData([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetDataGetInfoEXT* getInfo, [Count(Count = 0)] RenderModelAssetDataEXT* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelAssetData([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetDataGetInfoEXT* getInfo, [Count(Count = 0)] ref RenderModelAssetDataEXT buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelAssetData([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelAssetDataGetInfoEXT getInfo, [Count(Count = 0)] RenderModelAssetDataEXT* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetRenderModelAssetData([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelAssetDataGetInfoEXT getInfo, [Count(Count = 0)] ref RenderModelAssetDataEXT buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelAssetProperties([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetPropertiesGetInfoEXT* getInfo, [Count(Count = 0)] RenderModelAssetPropertiesEXT* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelAssetProperties([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetPropertiesGetInfoEXT* getInfo, [Count(Count = 0)] ref RenderModelAssetPropertiesEXT properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelAssetProperties([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelAssetPropertiesGetInfoEXT getInfo, [Count(Count = 0)] RenderModelAssetPropertiesEXT* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelAssetPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetRenderModelAssetProperties([Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelAssetPropertiesGetInfoEXT getInfo, [Count(Count = 0)] ref RenderModelAssetPropertiesEXT properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelProperties([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelPropertiesGetInfoEXT* getInfo, [Count(Count = 0)] RenderModelPropertiesEXT* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelProperties([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelPropertiesGetInfoEXT* getInfo, [Count(Count = 0)] ref RenderModelPropertiesEXT properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelProperties([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelPropertiesGetInfoEXT getInfo, [Count(Count = 0)] RenderModelPropertiesEXT* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetRenderModelProperties([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelPropertiesGetInfoEXT getInfo, [Count(Count = 0)] ref RenderModelPropertiesEXT properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelStateEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelState([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelStateGetInfoEXT* getInfo, [Count(Count = 0)] RenderModelStateEXT* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelStateEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelState([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelStateGetInfoEXT* getInfo, [Count(Count = 0)] ref RenderModelStateEXT state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelStateEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelState([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelStateGetInfoEXT getInfo, [Count(Count = 0)] RenderModelStateEXT* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelStateEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetRenderModelState([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderModelStateGetInfoEXT getInfo, [Count(Count = 0)] ref RenderModelStateEXT state);

        public ExtRenderModel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

