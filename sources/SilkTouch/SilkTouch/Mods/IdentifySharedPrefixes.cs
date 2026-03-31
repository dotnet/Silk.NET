// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Identifies shared prefixes,
/// such as namespace prefixes (eg: vk, gl)
/// and enum constant prefixes (eg: VK_ACCESS).
/// <para/>
/// These are identified as [NameAffix] attributes that
/// <see cref="PrettifyNames"/> and other mods can then process further.
/// </summary>
public class IdentifySharedPrefixes : Mod
{
    public override Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        return base.ExecuteAsync(ctx, ct);
    }
}
