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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_extended_struct_name_lengths")]
    public unsafe partial class KhrExtendedStructNameLengths : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_extended_struct_name_lengths";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StructureTypeToString2([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Computed = "XR_MAX_STRUCTURE_NAME_SIZE_EXTENDED_KHR")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString2KHR", Convention = CallingConvention.Winapi)]
        public partial Result StructureTypeToString2([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Computed = "XR_MAX_STRUCTURE_NAME_SIZE_EXTENDED_KHR")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString2KHR", Convention = CallingConvention.Winapi)]
        public partial Result StructureTypeToString2([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        public KhrExtendedStructNameLengths(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

