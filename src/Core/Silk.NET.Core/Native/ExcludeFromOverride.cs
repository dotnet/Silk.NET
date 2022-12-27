// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Native
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class ExcludeFromOverrideAttribute : Attribute
    {
        public ExcludeFromOverrideAttribute(int id) { }
    }
}
