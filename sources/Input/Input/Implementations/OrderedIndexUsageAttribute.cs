// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input;

/// <summary>
/// Used to indicate that an enum type is to be used as an ordered index. Proceed with caution, as changing the value
/// of an enum member, or adding additional enum members, may cause unexpected behavior. See <see cref="EnumInfo{T}"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Enum)]
internal class OrderedIndexUsageAttribute : Attribute;

/// <summary>
/// Used to indicate that an enum member is to be ignored for index coversions despite being a member of an enum with an
/// <see cref="OrderedIndexUsageAttribute"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
internal class OrderedIndexIgnoreAttribute : Attribute;
