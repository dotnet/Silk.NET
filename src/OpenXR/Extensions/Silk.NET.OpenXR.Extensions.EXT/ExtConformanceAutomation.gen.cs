// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_conformance_automation")]
    public unsafe partial class ExtConformanceAutomation : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_conformance_automation";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceActiveEXT")]
        public partial Result SetInputDeviceActive([Count(Count = 0)] Session session, [Count(Count = 0)] ulong interactionProfile, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] uint isActive);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceLocationEXT")]
        public partial Result SetInputDeviceLocation([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] Space space, [Count(Count = 0)] Posef pose);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceStateBoolEXT")]
        public partial Result SetInputDeviceStateBool([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] uint state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceStateFloatEXT")]
        public partial Result SetInputDeviceStateFloat([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] float state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceStateVector2fEXT")]
        public partial Result SetInputDeviceStateVector2([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] Vector2f state);

        public ExtConformanceAutomation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

