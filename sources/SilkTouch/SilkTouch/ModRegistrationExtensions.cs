// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autofac;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Extension methods for simplifying the registration of SilkTouch mods.
/// </summary>
public static class ModRegistrationExtensions
{
    /// <summary>
    /// Creates a <see cref="SilkTouchRegistrationContext"/>.
    /// </summary>
    public static SilkTouchRegistrationContext SilkTouch(this ContainerBuilder builder) =>
        new(builder);

    /// <summary>
    /// Registers the <see cref="AddApiProfiles"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext AddApiProfiles(
        this SilkTouchRegistrationContext context,
        AddApiProfiles.Configuration config
    )
    {
        context.Builder.RegisterMod<AddApiProfiles>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="ClangScraper"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext ClangScraper(
        this SilkTouchRegistrationContext context,
        ClangScraper.Configuration config
    )
    {
        context.Builder.RegisterMod<ClangScraper>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="AddIncludes"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext AddIncludes(
        this SilkTouchRegistrationContext context,
        AddIncludes.Configuration config
    )
    {
        context.Builder.RegisterMod<AddIncludes>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="AddOpaqueStructs"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext AddOpaqueStructs(
        this SilkTouchRegistrationContext context,
        AddOpaqueStructs.Configuration config
    )
    {
        context.Builder.RegisterMod<AddOpaqueStructs>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="AddVTables"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext AddVTables(
        this SilkTouchRegistrationContext context,
        AddVTables.Configuration config
    )
    {
        context.Builder.RegisterMod<AddVTables>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="BakeSourceSets"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext BakeSourceSets(
        this SilkTouchRegistrationContext context,
        BakeSourceSets.Configuration config
    )
    {
        context.Builder.RegisterMod<BakeSourceSets>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="ChangeNamespace"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext ChangeNamespace(
        this SilkTouchRegistrationContext context,
        ChangeNamespace.Configuration config
    )
    {
        context.Builder.RegisterMod<ChangeNamespace>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="ChangeNativeClass"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext ChangeNativeClass(
        this SilkTouchRegistrationContext context,
        ChangeNativeClass.Configuration config
    )
    {
        context.Builder.RegisterMod<ChangeNativeClass>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="ExtractEnumConstants"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext ExtractEnumConstants(
        this SilkTouchRegistrationContext context
    )
    {
        context.Builder.RegisterMod<ExtractEnumConstants>();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="ExtractFunctionPointers"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext ExtractFunctionPointers(
        this SilkTouchRegistrationContext context
    )
    {
        context.Builder.RegisterMod<ExtractFunctionPointers>();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="ExtractHandles"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext ExtractHandles(
        this SilkTouchRegistrationContext context
    )
    {
        context.Builder.RegisterMod<ExtractHandles>();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="ExtractNestedTypes"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext ExtractNestedTypes(
        this SilkTouchRegistrationContext context
    )
    {
        context.Builder.RegisterMod<ExtractNestedTypes>();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="IdentifySharedPrefixes"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext IdentifySharedPrefixes(
        this SilkTouchRegistrationContext context,
        IdentifySharedPrefixes.Configuration config
    )
    {
        context.Builder.RegisterMod<IdentifySharedPrefixes>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="InterceptNativeFunctions"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext InterceptNativeFunctions(
        this SilkTouchRegistrationContext context,
        InterceptNativeFunctions.Configuration config
    )
    {
        context.Builder.RegisterMod<InterceptNativeFunctions>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="MarkNativeNames"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext MarkNativeNames(
        this SilkTouchRegistrationContext context
    )
    {
        context.Builder.RegisterMod<MarkNativeNames>();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="MixKhronosData"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext MixKhronosData(
        this SilkTouchRegistrationContext context,
        MixKhronosData.Configuration config
    )
    {
        context.Builder.RegisterMod<MixKhronosData>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="PrettifyNames"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext PrettifyNames(
        this SilkTouchRegistrationContext context,
        PrettifyNames.Configuration config
    )
    {
        context.Builder.RegisterMod<PrettifyNames>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="StripAttributes"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext StripAttributes(
        this SilkTouchRegistrationContext context,
        StripAttributes.Configuration config
    )
    {
        context.Builder.RegisterMod<StripAttributes>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="TransformEnums"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext TransformEnums(
        this SilkTouchRegistrationContext context,
        TransformEnums.Configuration config
    )
    {
        context.Builder.RegisterMod<TransformEnums>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="TransformFunctions"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext TransformFunctions(
        this SilkTouchRegistrationContext context
    )
    {
        context.Builder.RegisterMod<TransformFunctions>();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="TransformHandles"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext TransformHandles(
        this SilkTouchRegistrationContext context,
        TransformHandles.Configuration config
    )
    {
        context.Builder.RegisterMod<TransformHandles>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    /// <summary>
    /// Registers the <see cref="TransformProperties"/> mod.
    /// </summary>
    public static SilkTouchRegistrationContext TransformProperties(
        this SilkTouchRegistrationContext context,
        TransformProperties.Configuration config
    )
    {
        context.Builder.RegisterMod<TransformProperties>();
        context.Builder.RegisterInstance(config).SingleInstance();
        return context;
    }

    private static void RegisterMod<T>(this ContainerBuilder builder)
        where T : IMod
    {
        var type = typeof(T);
        var typesToRegister = new HashSet<Type>();
        typesToRegister.UnionWith(type.GetInterfaces());

        var current = type;
        while (current != null)
        {
            typesToRegister.Add(current);
            current = current.BaseType;
        }

        builder.RegisterType<T>().As(typesToRegister.ToArray()).SingleInstance();
    }

    /// <summary>
    /// Helper for registering SilkTouch mods to a <see cref="ContainerBuilder"/>
    /// </summary>
    public record struct SilkTouchRegistrationContext(ContainerBuilder Builder);
}
