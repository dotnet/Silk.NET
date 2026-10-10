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
    /// Registers the <see cref="AddApiProfiles"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterAddApiProfiles(
        this ContainerBuilder builder,
        AddApiProfiles.Configuration config
    )
    {
        builder.RegisterMod<AddApiProfiles>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ClangScraper"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterClangScraper(
        this ContainerBuilder builder,
        ClangScraper.Configuration config
    )
    {
        builder.RegisterMod<ClangScraper>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="AddIncludes"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterAddIncludes(
        this ContainerBuilder builder,
        AddIncludes.Configuration config
    )
    {
        builder.RegisterMod<AddIncludes>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="AddOpaqueStructs"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterAddOpaqueStructs(
        this ContainerBuilder builder,
        AddOpaqueStructs.Configuration config
    )
    {
        builder.RegisterMod<AddOpaqueStructs>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="AddVTables"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterAddVTables(
        this ContainerBuilder builder,
        AddVTables.Configuration config
    )
    {
        builder.RegisterMod<AddVTables>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="BakeSourceSets"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterBakeSourceSets(
        this ContainerBuilder builder,
        BakeSourceSets.Configuration config
    )
    {
        builder.RegisterMod<BakeSourceSets>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ChangeNamespace"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterChangeNamespace(
        this ContainerBuilder builder,
        ChangeNamespace.Configuration config
    )
    {
        builder.RegisterMod<ChangeNamespace>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ChangeNativeClass"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterChangeNativeClass(
        this ContainerBuilder builder,
        ChangeNativeClass.Configuration config
    )
    {
        builder.RegisterMod<ChangeNativeClass>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractEnumConstants"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractEnumConstants(this ContainerBuilder builder)
    {
        builder.RegisterMod<ExtractEnumConstants>();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractFunctionPointers"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractFunctionPointers(this ContainerBuilder builder)
    {
        builder.RegisterMod<ExtractFunctionPointers>();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractHandles"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractHandles(this ContainerBuilder builder)
    {
        builder.RegisterMod<ExtractHandles>();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractNestedTypes"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractNestedTypes(this ContainerBuilder builder)
    {
        builder.RegisterMod<ExtractNestedTypes>();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="IdentifySharedPrefixes"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterIdentifySharedPrefixes(
        this ContainerBuilder builder,
        IdentifySharedPrefixes.Configuration config
    )
    {
        builder.RegisterMod<IdentifySharedPrefixes>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="InterceptNativeFunctions"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterInterceptNativeFunctions(
        this ContainerBuilder builder,
        InterceptNativeFunctions.Configuration config
    )
    {
        builder.RegisterMod<InterceptNativeFunctions>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="MarkNativeNames"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterMarkNativeNames(this ContainerBuilder builder)
    {
        builder.RegisterMod<MarkNativeNames>();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="MixKhronosData"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterMixKhronosData(
        this ContainerBuilder builder,
        MixKhronosData.Configuration config
    )
    {
        builder.RegisterMod<MixKhronosData>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="PrettifyNames"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterPrettifyNames(
        this ContainerBuilder builder,
        PrettifyNames.Configuration config
    )
    {
        builder.RegisterMod<PrettifyNames>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="StripAttributes"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterStripAttributes(
        this ContainerBuilder builder,
        StripAttributes.Configuration config
    )
    {
        builder.RegisterMod<StripAttributes>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="TransformEnums"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterTransformEnums(
        this ContainerBuilder builder,
        TransformEnums.Configuration config
    )
    {
        builder.RegisterMod<TransformEnums>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="TransformFunctions"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterTransformFunctions(this ContainerBuilder builder)
    {
        builder.RegisterMod<TransformFunctions>();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="TransformHandles"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterTransformHandles(
        this ContainerBuilder builder,
        TransformHandles.Configuration config
    )
    {
        builder.RegisterMod<TransformHandles>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="TransformProperties"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterTransformProperties(
        this ContainerBuilder builder,
        TransformProperties.Configuration config
    )
    {
        builder.RegisterMod<TransformProperties>();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
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
}
