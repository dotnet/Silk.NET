// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_controller_model")]
    public unsafe partial class MsftControllerModel : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_controller_model";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelKeyMSFT")]
        public unsafe partial Result GetControllerModelKeyMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] ControllerModelKeyStateMSFT* controllerModelKeyState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelKeyMSFT")]
        public partial Result GetControllerModelKeyMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] ref ControllerModelKeyStateMSFT controllerModelKeyState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelPropertiesMSFT")]
        public unsafe partial Result GetControllerModelPropertiesMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ControllerModelPropertiesMSFT* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelPropertiesMSFT")]
        public partial Result GetControllerModelPropertiesMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ref ControllerModelPropertiesMSFT properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelStateMSFT")]
        public unsafe partial Result GetControllerModelStateMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ControllerModelStateMSFT* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelStateMSFT")]
        public partial Result GetControllerModelStateMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ref ControllerModelStateMSFT state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT")]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT")]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT")]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT")]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT")]
        public partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT")]
        public partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        public MsftControllerModel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

