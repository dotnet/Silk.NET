// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autofac;
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
        // TODO: Need to add a register mod helper since we need to register interfaces, base classes, and the concrete type
        builder.RegisterType<AddApiProfiles>().SingleInstance();
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
        builder.RegisterType<AddIncludes>().SingleInstance();
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
        builder.RegisterType<AddOpaqueStructs>().SingleInstance();
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
        builder.RegisterType<AddVTables>().SingleInstance();
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
        builder.RegisterType<BakeSourceSets>().SingleInstance();
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
        builder.RegisterType<ChangeNamespace>().SingleInstance();
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
        builder.RegisterType<ChangeNativeClass>().SingleInstance();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractEnumConstants"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractEnumConstants(this ContainerBuilder builder)
    {
        builder.RegisterType<ExtractEnumConstants>().SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractFunctionPointers"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractFunctionPointers(this ContainerBuilder builder)
    {
        builder.RegisterType<ExtractFunctionPointers>().SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractHandles"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractHandles(this ContainerBuilder builder)
    {
        builder.RegisterType<ExtractHandles>().SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="ExtractNestedTypes"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterExtractNestedTypes(this ContainerBuilder builder)
    {
        builder.RegisterType<ExtractNestedTypes>().SingleInstance();
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
        builder.RegisterType<IdentifySharedPrefixes>().SingleInstance();
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
        builder.RegisterType<InterceptNativeFunctions>().SingleInstance();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="MarkNativeNames"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterMarkNativeNames(this ContainerBuilder builder)
    {
        builder.RegisterType<MarkNativeNames>().SingleInstance();
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
        builder.RegisterType<MixKhronosData>().SingleInstance();
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
        builder.RegisterType<PrettifyNames>().SingleInstance();
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
        builder.RegisterType<StripAttributes>().SingleInstance();
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
        builder.RegisterType<TransformEnums>().SingleInstance();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }

    /// <summary>
    /// Registers the <see cref="TransformFunctions"/> mod.
    /// </summary>
    public static ContainerBuilder RegisterTransformFunctions(this ContainerBuilder builder)
    {
        builder.RegisterType<TransformFunctions>().SingleInstance();
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
        builder.RegisterType<TransformHandles>().SingleInstance();
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
        builder.RegisterType<TransformProperties>().SingleInstance();
        builder.RegisterInstance(config).SingleInstance();
        return builder;
    }
}
