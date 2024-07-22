// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// An attribute used to denote a field as hosting a component in implementations of <see cref="IHluComponentHost"/>.
/// This attribute is recognised by the <c>Silk.NET.Core.Analyzers</c> source generators to produce an implementation of
/// <see cref="IHluComponentHost"/> on classes marked with this attribute for each hosted component.
/// <br />
/// Please see <see cref="HluRegisteredComponentAttribute{TComponent,TImpl}"/> for parameter usage.
/// </summary>
/// <remarks>
/// For efficiency, some commonly-used components can be stored in fields instead of a map of <see cref="Type"/>s to
/// <see cref="object"/>s (thereby requiring runtime checks upon usage).
/// </remarks>
/// <param name="optional">
/// Whether the component is optional. If it isn't, the generated <c>Create</c> method will throw if the component has
/// not been configured. This has no effect when used on a parameter, please use nullability annotations instead.
/// </param>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class HluHostedComponentAttribute(bool optional = false) : Attribute()
{
    /// <summary>
    /// Whether the component is optional. If it isn't, the generated <c>Create</c> method will throw if the component
    /// has not been configured.
    /// </summary>
    public bool IsOptional { get; } = optional;

    /// <summary>
    /// Parent component types for which there may be multiple hosted components that additionally conform to the given
    /// component type. For example, <c>IGLComponent</c> and <c>IVkComponent</c> could be grouped into
    /// <c>IGraphicsComponent</c>. Groups should be used to optimise the storage of components that have similar use
    /// cases but differing applicability. When the HLU source generator is used, component groups have the following
    /// properties:
    /// <list type="bullet">
    /// <item>
    /// <term>For <see cref="IHluComponentHost.TrySet{TComponent, TImpl}"/>: </term>
    /// <description>
    /// Any attempt to set <c>TComponent</c> that already has a component in any of the given groups will be refused.
    /// To reuse the previous example, you can't set <c>IVkComponent</c> if <c>IGLComponent</c> has already been set.
    /// In addition, calling this method where <c>TComponent</c> is the group type will be refused unless the operation
    /// can succeed with <c>TComponent</c> being implicitly substituted with any of the grouped component types. That
    /// is, setting <c>IGraphicsComponent</c> will attempt to recurse into setting <c>IGLComponent</c> or
    /// <c>IVkComponent</c> if that is doable given the <c>TImpl</c> provided.
    /// </description>
    /// </item>
    /// <item>
    /// <term>For <see cref="IHluComponentHost.TryGet{TComponent}"/>: </term>
    /// <description>
    /// If <c>TComponent</c> is the group type, the first configured component that is a member of that group will be
    /// returned. This will have consistent behaviour due to the guarantees provided in
    /// <see cref="IHluComponentHost.TrySet{Tcomponent, TImpl}"/>. <c>TComponent</c> being a type of a grouped component
    /// will work in the same way as if that component wasn't grouped.
    /// </description>
    /// </item>
    /// </list>
    /// </summary>
    public Type[]? Groups { get; init; }
}
