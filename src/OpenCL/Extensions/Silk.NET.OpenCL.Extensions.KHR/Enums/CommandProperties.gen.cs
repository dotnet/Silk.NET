// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_command_properties_khr")]
    public enum CommandProperties : ulong
    {
        [NativeName("Name", "CL_MUTABLE_DISPATCH_UPDATABLE_FIELDS_KHR")]
        UpdatableFields = 0x12B1,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_ASSERTS_KHR")]
        Asserts = 0x12B8,
    }
}
