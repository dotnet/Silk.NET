// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.Maths;

namespace Silk.NET.Windowing.WPF;

public interface IViewHost
{
    Vector2D<int> Size { get; }
    Vector2 Dpi { get; }
}
