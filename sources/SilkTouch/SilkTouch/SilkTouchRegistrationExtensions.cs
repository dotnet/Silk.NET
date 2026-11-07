// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autofac;
using Autofac.Builder;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Transformation;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Extension methods for simplifying the registration of SilkTouch mods.
/// </summary>
public static class SilkTouchRegistrationExtensions
{
    /// <summary>
    /// Entrypoint to the rest of the SilkTouch registration methods.
    /// Begins a <see cref="SilkTouchRegistrationContext"/>.
    /// </summary>
    public static SilkTouchRegistrationContext SilkTouch(this ContainerBuilder builder) =>
        new(builder);

    // Non-mods
    extension(SilkTouchRegistrationContext context)
    {
        /// <summary>
        /// Registers the default function transformers.
        /// </summary>
        /// <returns></returns>
        public SilkTouchRegistrationContext WithDefaultFunctionTransformers(
            BoolTransformer.Configuration? boolTransformerConfig = null
        ) =>
            context
                .WithPtrRefTransformer()
                .WithBoolTransformer(boolTransformerConfig)
                .WithArrayParameterTransformer();

        /// <summary>
        /// Registers the <see cref="PtrRefTransformer"/> function transformer.
        /// </summary>
        /// <returns></returns>
        public SilkTouchRegistrationContext WithPtrRefTransformer()
        {
            context
                .Builder.RegisterType<PtrRefTransformer>()
                .AsImplementedInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="BoolTransformer"/> function transformer.
        /// </summary>
        /// <returns></returns>
        public SilkTouchRegistrationContext WithBoolTransformer(
            BoolTransformer.Configuration? boolTransformerConfig = null
        )
        {
            context
                .Builder.RegisterType<BoolTransformer>()
                .WithParameter(
                    new TypedParameter(
                        typeof(BoolTransformer.Configuration),
                        boolTransformerConfig ?? new()
                    )
                )
                .AsImplementedInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ArrayParameterTransformer"/> function transformer.
        /// </summary>
        /// <returns></returns>
        public SilkTouchRegistrationContext WithArrayParameterTransformer()
        {
            context
                .Builder.RegisterType<ArrayParameterTransformer>()
                .AsImplementedInterfaces()
                .SingleInstance();

            return context;
        }
    }

    // Mods
    extension(SilkTouchRegistrationContext context)
    {
        /// <summary>
        /// Registers the <see cref="AddApiProfiles"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext AddApiProfiles(
            AddApiProfiles.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<AddApiProfiles>()
                .WithParameter(
                    new TypedParameter(typeof(AddApiProfiles.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ClangScraper"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ClangScraper(ClangScraper.Configuration config)
        {
            context
                .Builder.RegisterType<ClangScraper>()
                .WithParameter(new TypedParameter(typeof(ClangScraper.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="AddIncludes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext AddIncludes(AddIncludes.Configuration? config = null)
        {
            context
                .Builder.RegisterType<AddIncludes>()
                .WithParameter(
                    new TypedParameter(typeof(AddIncludes.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="AddOpaqueStructs"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext AddOpaqueStructs(AddOpaqueStructs.Configuration config)
        {
            context
                .Builder.RegisterType<AddOpaqueStructs>()
                .WithParameter(new TypedParameter(typeof(AddOpaqueStructs.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="AddVTables"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext AddVTables(AddVTables.Configuration? config = null)
        {
            context
                .Builder.RegisterType<AddVTables>()
                .WithParameter(
                    new TypedParameter(typeof(AddVTables.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="BakeSourceSets"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext BakeSourceSets(BakeSourceSets.Configuration config)
        {
            context
                .Builder.RegisterType<BakeSourceSets>()
                .WithParameter(new TypedParameter(typeof(BakeSourceSets.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ChangeNamespace"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ChangeNamespace(ChangeNamespace.Configuration config)
        {
            context
                .Builder.RegisterType<ChangeNamespace>()
                .WithParameter(new TypedParameter(typeof(ChangeNamespace.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ChangeNativeClass"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ChangeNativeClass(
            ChangeNativeClass.Configuration config
        )
        {
            context
                .Builder.RegisterType<ChangeNativeClass>()
                .WithParameter(new TypedParameter(typeof(ChangeNativeClass.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractEnumConstants"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractEnumConstants()
        {
            context
                .Builder.RegisterType<ExtractEnumConstants>()
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractFunctionPointers"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractFunctionPointers()
        {
            context
                .Builder.RegisterType<ExtractFunctionPointers>()
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractHandles"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractHandles()
        {
            context
                .Builder.RegisterType<ExtractHandles>()
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractNestedTypes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractNestedTypes()
        {
            context
                .Builder.RegisterType<ExtractNestedTypes>()
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="IdentifySharedPrefixes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext IdentifySharedPrefixes(
            IdentifySharedPrefixes.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<IdentifySharedPrefixes>()
                .WithParameter(
                    new TypedParameter(typeof(IdentifySharedPrefixes.Configuration), config)
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="InterceptNativeFunctions"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext InterceptNativeFunctions(
            InterceptNativeFunctions.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<InterceptNativeFunctions>()
                .WithParameter(
                    new TypedParameter(typeof(InterceptNativeFunctions.Configuration), config)
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="MarkNativeNames"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext MarkNativeNames()
        {
            context
                .Builder.RegisterType<MarkNativeNames>()
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="MixKhronosData"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext MixKhronosData(
            MixKhronosData.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<MixKhronosData>()
                .WithParameter(
                    new TypedParameter(typeof(MixKhronosData.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="PrettifyNames"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext PrettifyNames(
            PrettifyNames.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<PrettifyNames>()
                .WithParameter(
                    new TypedParameter(typeof(PrettifyNames.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="StripAttributes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext StripAttributes(
            StripAttributes.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<StripAttributes>()
                .WithParameter(
                    new TypedParameter(typeof(StripAttributes.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformEnums"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformEnums(
            TransformEnums.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<TransformEnums>()
                .WithParameter(
                    new TypedParameter(typeof(TransformEnums.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformFunctions"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformFunctions()
        {
            context
                .Builder.RegisterType<TransformFunctions>()
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformHandles"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformHandles(
            TransformHandles.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<TransformHandles>()
                .WithParameter(
                    new TypedParameter(typeof(TransformHandles.Configuration), config ?? new())
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformProperties"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformProperties(
            TransformProperties.Configuration? config = null
        )
        {
            context
                .Builder.RegisterType<TransformProperties>()
                .WithParameter(
                    new TypedParameter(typeof(TransformProperties.Configuration), config)
                )
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }
    }

    extension<TLimit, TConcreteActivatorData>(
        IRegistrationBuilder<TLimit, TConcreteActivatorData, SingleRegistrationStyle> registration
    )
        where TConcreteActivatorData : IConcreteActivatorData
    {
        private IRegistrationBuilder<
            TLimit,
            TConcreteActivatorData,
            SingleRegistrationStyle
        > AsHierarchyAndInterfaces()
        {
            var type = registration.ActivatorData.Activator.LimitType;
            var typesToRegister = new HashSet<Type>();
            typesToRegister.UnionWith(type.GetInterfaces());

            var current = type;
            while (current != null)
            {
                typesToRegister.Add(current);
                current = current.BaseType;
            }

            return registration.As(typesToRegister.ToArray());
        }
    }

    /// <summary>
    /// Helper for registering SilkTouch to a <see cref="ContainerBuilder"/>
    /// </summary>
    public record struct SilkTouchRegistrationContext(ContainerBuilder Builder);
}
