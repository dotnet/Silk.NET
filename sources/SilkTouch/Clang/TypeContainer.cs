// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A container to represent a potential Type/Delegate since often the two can be used interchangably
/// </summary>
/// <param name="Type"></param>
/// <param name="Delegate"></param>
/// <param name="Enum"></param>
public record struct TypeContainer(IBaseTypeContext? Type = null, IEnumTypeContext? Enum = null, IDelegateContext? Delegate = null);
