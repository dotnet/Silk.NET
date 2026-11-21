// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.DependencyInjection;
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
    public static SilkTouchRegistrationContext SilkTouch(this IServiceCollection services) =>
        new(services);

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
            context.Services.AddSingletonAsInterfaces<PtrRefTransformer>();
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
            context.Services.AddSingletonAsInterfaces<BoolTransformer>(
                boolTransformerConfig ?? new()
            );
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ArrayParameterTransformer"/> function transformer.
        /// </summary>
        /// <returns></returns>
        public SilkTouchRegistrationContext WithArrayParameterTransformer()
        {
            context.Services.AddSingletonAsInterfaces<ArrayParameterTransformer>();
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
            context.Services.AddSingletonAsHierarchyAndInterfaces<AddApiProfiles>(config ?? new());
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ClangScraper"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ClangScraper(ClangScraper.Configuration config)
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<ClangScraper>(config);
            return context;
        }

        /// <summary>
        /// Registers the <see cref="AddIncludes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext AddIncludes(AddIncludes.Configuration? config = null)
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<AddIncludes>(config ?? new());
            return context;
        }

        /// <summary>
        /// Registers the <see cref="AddOpaqueStructs"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext AddOpaqueStructs(AddOpaqueStructs.Configuration config)
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<AddOpaqueStructs>(config);
            return context;
        }

        /// <summary>
        /// Registers the <see cref="AddVTables"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext AddVTables(AddVTables.Configuration? config = null)
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<AddVTables>(config ?? new());
            return context;
        }

        /// <summary>
        /// Registers the <see cref="BakeSourceSets"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext BakeSourceSets(BakeSourceSets.Configuration config)
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<BakeSourceSets>(config);
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ChangeNamespace"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ChangeNamespace(ChangeNamespace.Configuration config)
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<ChangeNamespace>(config);
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ChangeNativeClass"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ChangeNativeClass(
            ChangeNativeClass.Configuration config
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<ChangeNativeClass>(config);
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractEnumConstants"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractEnumConstants()
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<ExtractEnumConstants>();
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractFunctionPointers"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractFunctionPointers()
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<ExtractFunctionPointers>();
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractHandles"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractHandles()
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<ExtractHandles>();
            return context;
        }

        /// <summary>
        /// Registers the <see cref="ExtractNestedTypes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext ExtractNestedTypes()
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<ExtractNestedTypes>();
            return context;
        }

        /// <summary>
        /// Registers the <see cref="IdentifySharedPrefixes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext IdentifySharedPrefixes(
            IdentifySharedPrefixes.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<IdentifySharedPrefixes>(config);
            return context;
        }

        /// <summary>
        /// Registers the <see cref="InterceptNativeFunctions"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext InterceptNativeFunctions(
            InterceptNativeFunctions.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<InterceptNativeFunctions>(config);
            return context;
        }

        /// <summary>
        /// Registers the <see cref="MarkNativeNames"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext MarkNativeNames()
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<MarkNativeNames>();
            return context;
        }

        /// <summary>
        /// Registers the <see cref="MixKhronosData"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext MixKhronosData(
            MixKhronosData.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<MixKhronosData>(config ?? new());
            return context;
        }

        /// <summary>
        /// Registers the <see cref="PrettifyNames"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext PrettifyNames(
            PrettifyNames.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<PrettifyNames>(config ?? new());
            return context;
        }

        /// <summary>
        /// Registers the <see cref="StripAttributes"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext StripAttributes(
            StripAttributes.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<StripAttributes>(config ?? new());
            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformEnums"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformEnums(
            TransformEnums.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<TransformEnums>(config ?? new());
            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformFunctions"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformFunctions()
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<TransformFunctions>();
            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformHandles"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformHandles(
            TransformHandles.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<TransformHandles>(
                config ?? new()
            );
            return context;
        }

        /// <summary>
        /// Registers the <see cref="TransformProperties"/> mod.
        /// </summary>
        public SilkTouchRegistrationContext TransformProperties(
            TransformProperties.Configuration? config = null
        )
        {
            context.Services.AddSingletonAsHierarchyAndInterfaces<TransformProperties>(config);
            return context;
        }
    }

    extension(IServiceCollection services)
    {
        private IServiceCollection AddSingletonAsInterfaces<T>(object? parameter = null)
            where T : class => services.AddSingletonAs<T>(typeof(T).GetInterfaces(), parameter);

        private IServiceCollection AddSingletonAsHierarchyAndInterfaces<T>(object? parameter = null)
            where T : class
        {
            var types = new HashSet<Type>(typeof(T).GetInterfaces());
            var current = typeof(T);
            while (current != null)
            {
                types.Add(current);
                current = current.BaseType;
            }

            return services.AddSingletonAs<T>(types, parameter);
        }

        private IServiceCollection AddSingletonAs<T>(IEnumerable<Type> types, object? parameter)
            where T : class
        {
            var key = new object();
            object[] parameters = parameter is null ? [] : [parameter];

            services.AddKeyedSingleton(
                typeof(T),
                key,
                (sp, _) => ActivatorUtilities.CreateInstance<T>(sp, parameters)
            );

            services.AddSingleton(typeof(T), sp => sp.GetRequiredKeyedService<T>(key));

            foreach (var type in types)
            {
                if (type != typeof(T))
                {
                    services.AddSingleton(type, sp => sp.GetRequiredKeyedService<T>(key));
                }
            }

            return services;
        }
    }

    /// <summary>
    /// Helper for registering SilkTouch to a <see cref="IServiceCollection"/>
    /// </summary>
    public record struct SilkTouchRegistrationContext(IServiceCollection Services);
}
