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

    extension(SilkTouchRegistrationContext context)
    {
        /// <summary>
        /// Begins a <see cref="SilkTouchRegistrationContext"/>.
        /// </summary>
        public SilkTouchModRegistrationContext Mods() => new(context.Builder);

        /// <summary>
        /// Begins a <see cref="SilkTouchRegistrationContext"/>.
        /// </summary>
        public SilkTouchRegistrationContext Mods(Action<SilkTouchModRegistrationContext> build)
        {
            build.Invoke(new SilkTouchModRegistrationContext(context.Builder));
            return context;
        }
    }

    extension(SilkTouchModRegistrationContext context)
    {
        /// <summary>
        /// Registers the <see cref="AddApiProfiles"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext AddApiProfiles(AddApiProfiles.Configuration config)
        {
            context
                .Builder.RegisterType<AddApiProfiles>()
                .WithParameter(new TypedParameter(typeof(AddApiProfiles.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="ClangScraper"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext ClangScraper(ClangScraper.Configuration config)
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
        public SilkTouchModRegistrationContext AddIncludes(AddIncludes.Configuration config)
        {
            context
                .Builder.RegisterType<AddIncludes>()
                .WithParameter(new TypedParameter(typeof(AddIncludes.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="AddOpaqueStructs"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext AddOpaqueStructs(
            AddOpaqueStructs.Configuration config
        )
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
        public SilkTouchModRegistrationContext AddVTables(AddVTables.Configuration config)
        {
            context
                .Builder.RegisterType<AddVTables>()
                .WithParameter(new TypedParameter(typeof(AddVTables.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="BakeSourceSets"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext BakeSourceSets(BakeSourceSets.Configuration config)
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
        public SilkTouchModRegistrationContext ChangeNamespace(ChangeNamespace.Configuration config)
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
        public SilkTouchModRegistrationContext ChangeNativeClass(
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
        public SilkTouchModRegistrationContext ExtractEnumConstants()
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
        public SilkTouchModRegistrationContext ExtractFunctionPointers()
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
        public SilkTouchModRegistrationContext ExtractHandles()
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
        public SilkTouchModRegistrationContext ExtractNestedTypes()
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
        public SilkTouchModRegistrationContext IdentifySharedPrefixes(
            IdentifySharedPrefixes.Configuration config
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
        public SilkTouchModRegistrationContext InterceptNativeFunctions(
            InterceptNativeFunctions.Configuration config
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
        public SilkTouchModRegistrationContext MarkNativeNames()
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
        public SilkTouchModRegistrationContext MixKhronosData(MixKhronosData.Configuration config)
        {
            context
                .Builder.RegisterType<MixKhronosData>()
                .WithParameter(new TypedParameter(typeof(MixKhronosData.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="PrettifyNames"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext PrettifyNames(PrettifyNames.Configuration config)
        {
            context
                .Builder.RegisterType<PrettifyNames>()
                .WithParameter(new TypedParameter(typeof(PrettifyNames.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="StripAttributes"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext StripAttributes(StripAttributes.Configuration config)
        {
            context
                .Builder.RegisterType<StripAttributes>()
                .WithParameter(new TypedParameter(typeof(StripAttributes.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformEnums"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext TransformEnums(TransformEnums.Configuration config)
        {
            context
                .Builder.RegisterType<TransformEnums>()
                .WithParameter(new TypedParameter(typeof(TransformEnums.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformFunctions"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext TransformFunctions(
            TransformFunctions.Configuration config
        )
        {
            context
                .Builder.RegisterType<TransformFunctions>()
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            // These probably can be moved to their own registration methods, but keeping it here since we have no reason to exclude any transformers right now
            // Also, BoolTransformer relies on TransformFunctions.Configuration, which is tech debt
            {
                context.Builder.RegisterType<FunctionTransformer>().SingleInstance();

                context
                    .Builder.RegisterType<PtrRefTransformer>()
                    .AsImplementedInterfaces()
                    .SingleInstance();

                context
                    .Builder.RegisterType<BoolTransformer>()
                    .WithParameter(
                        new TypedParameter(typeof(TransformFunctions.Configuration), config)
                    )
                    .AsImplementedInterfaces()
                    .SingleInstance();

                context
                    .Builder.RegisterType<ArrayParameterTransformer>()
                    .AsImplementedInterfaces()
                    .SingleInstance();
            }

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformHandles"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext TransformHandles(
            TransformHandles.Configuration config
        )
        {
            context
                .Builder.RegisterType<TransformHandles>()
                .WithParameter(new TypedParameter(typeof(TransformHandles.Configuration), config))
                .AsHierarchyAndInterfaces()
                .SingleInstance();

            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformProperties"/> mod.
        /// </summary>
        public SilkTouchModRegistrationContext TransformProperties(
            TransformProperties.Configuration config
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

    /// <summary>
    /// Helper for registering SilkTouch mods to a <see cref="ContainerBuilder"/>
    /// </summary>
    public record struct SilkTouchModRegistrationContext(ContainerBuilder Builder);
}
