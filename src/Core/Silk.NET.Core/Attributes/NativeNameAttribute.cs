// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class NativeNameAttribute : Attribute
    {
        public NativeNameAttribute(string category, string name)
        {
            Category = category;
            Name = name;
        }

        public string Category { get; }
        public string Name { get; }
    }
}
