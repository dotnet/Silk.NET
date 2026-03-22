// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input;

[AttributeUsage(AttributeTargets.Enum)]
internal class OrderedIndexUsageAttribute : Attribute;

[AttributeUsage(AttributeTargets.Field)]
internal class OrderedIndexIgnoreAttribute : Attribute;
