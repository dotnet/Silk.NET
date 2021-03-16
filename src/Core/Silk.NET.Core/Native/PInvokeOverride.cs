// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Native
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PInvokeOverride : Attribute
    {
        public PInvokeOverride(int id, string target)
        {
        }
    }
}
