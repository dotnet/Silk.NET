// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Reflection;

namespace Silk.NET.Core.Attributes
{
    public class ExtensionAttribute : Attribute
    {
        public ExtensionAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static ExtensionAttribute GetExtensionAttribute(MemberInfo type)
        {
            return type.GetCustomAttribute<ExtensionAttribute>();
        }
    }
}
