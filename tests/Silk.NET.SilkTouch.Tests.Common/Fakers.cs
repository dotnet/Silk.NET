using System.Collections.Immutable;
using System.Runtime.Serialization;
using Bogus;
using Silk.NET.SilkTouch.Symbols;
#pragma warning disable CS0618

namespace Silk.NET.SilkTouch.Tests.Common;

public static class Fakers
{
    private sealed class FakeAnnotation : ISymbolAnnotation
    {
        
    }
    
    static Fakers()
    {
        // Randomizer.Seed = new Random(138957);
        Faker.DefaultStrictMode = true;
    }

    public static int StandardGenerateCount { get; } = 20;

    public static Faker<ISymbolAnnotation> Annotation = new Faker<ISymbolAnnotation>().CustomInstantiator
        (x => new FakeAnnotation());

    public static Faker<IdentifierSymbol> IdentifierSymbol { get; } = new Faker<IdentifierSymbol>().SkipConstructor()
        .RuleFor
        (
            x => x.Value,
            f => f.Random.String2(1, StandardGenerateCount, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_")
        )
        .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));

    public static Faker<ExternalTypeReference> ExternalTypeReference { get; } =
        new Faker<ExternalTypeReference>()
            .SkipConstructor()
            .RuleFor(x => x.Namespace, f => IdentifierSymbol.Generate().OrNull(f, 0.1f))
            .RuleFor(x => x.TypeIdentifier, f => IdentifierSymbol.Generate())
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));

    public static Faker<TypeReference> TypeReference { get; } = 
        new Faker<TypeReference>()
            .Ignore(x => x.Annotations)
            // TODO: Generate different type references here
            .CustomInstantiator(x => ExternalTypeReference.Generate());

    public static Faker<StaticExternalMethodSymbol> StaticExternalMethodSymbol { get; } =
        new Faker<StaticExternalMethodSymbol>()
            .SkipConstructor()
            .RuleFor(x => x.Identifier, f => IdentifierSymbol.Generate())
            .RuleFor(x => x.ReturnType, f => TypeReference.Generate())
            .RuleFor(x => x.Parameters, f =>
            {
                var numGenerate = f.Random.Int(0, StandardGenerateCount);
                return Enumerable.Zip
                        (TypeReference.Generate(numGenerate), IdentifierSymbol.Generate(numGenerate))
                    .Select(v => new Parameter(v.First, v.Second))
                    .ToImmutableArray();
            })
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));
    
    public static Faker<MethodSymbol> MethodSymbol { get; } =
        new Faker<MethodSymbol>()
            .Ignore(x => x.Identifier)
            .Ignore(x => x.Parameters)
            .Ignore(x => x.ReturnType)
            .Ignore(x => x.Annotations)
            .CustomInstantiator(x => StaticExternalMethodSymbol.Generate());
    
    public static Faker<ClassSymbol> ClassSymbol { get; } =
        new Faker<ClassSymbol>()
            .SkipConstructor()
            .RuleFor(x => x.Id, f => TypeId.From(f.Random.Guid()))
            .RuleFor(x => x.Identifier, f => IdentifierSymbol.Generate())
            .RuleFor(x => x.Members, f => MethodSymbol.GenerateImmutableArray(0, StandardGenerateCount).CastArray<MemberSymbol>())
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));
    
    public static Faker<FieldSymbol> FieldSymbol { get; } =
        new Faker<FieldSymbol>()
            .SkipConstructor()
            .RuleFor(x => x.Identifier, f => IdentifierSymbol.Generate())
            .RuleFor(x => x.Type, f => TypeReference.Generate())
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));
    
    public static Faker<FunctionPointerTypeReference> FunctionPointerTypeReference { get; } =
        new Faker<FunctionPointerTypeReference>()
            .SkipConstructor()
            .RuleFor(x => x.ReturnType, f => TypeReference.Generate())
            .RuleFor(x => x.ParameterTypes, f => TypeReference.GenerateImmutableArray(0, StandardGenerateCount))
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));
    
    public static Faker<InternalTypeReference> InternalTypeReference { get; } =
        new Faker<InternalTypeReference>()
            .SkipConstructor()
            .RuleFor(x => x.ReferencedTypeId, f => TypeId.From(f.Random.Guid()))
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));

    public static Faker<TypeSymbol> TypeSymbol { get; } = new Faker<TypeSymbol>()
        .Ignore(x => x.Id)
        .Ignore(x => x.Identifier)
        .Ignore(x => x.Annotations)
        .Ignore(x => x.Members)
        .CustomInstantiator(e => e.PickRandom(new TypeSymbol[] { ClassSymbol.Generate(), StructSymbol!.Generate() }));

    public static Faker<NamespaceSymbol> NamespaceSymbol { get; } =
        new Faker<NamespaceSymbol>()
            .SkipConstructor()
            .RuleFor(x => x.Identifier, f => IdentifierSymbol.Generate())
            .RuleFor(x => x.Types, f => TypeSymbol.GenerateImmutableArray(0, StandardGenerateCount))
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));
    
    public static Faker<PointerTypeReference> PointerTypeReference { get; } =
        new Faker<PointerTypeReference>()
            .SkipConstructor()
            .RuleFor(x => x.Underlying, f => TypeReference.Generate())
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));
    
    public static Faker<StructSymbol> StructSymbol { get; } =
        new Faker<StructSymbol>()
            .SkipConstructor()
            .RuleFor(x => x.Id, f => TypeId.From(f.Random.Guid()))
            .RuleFor(x => x.Identifier, f => IdentifierSymbol.Generate())
            .RuleFor(x => x.Members, f => FieldSymbol.GenerateImmutableArray(0, StandardGenerateCount).CastArray<MemberSymbol>())
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));
    
    public static Faker<UnresolvedTypeReference> UnresolvedTypeReference { get; } =
        new Faker<UnresolvedTypeReference>()
            .SkipConstructor()
            .RuleFor(x => x.Text, f => f.Random.String(0, StandardGenerateCount))
            .RuleFor(x => x.Annotations, () => Annotation.GenerateImmutableArray(0, StandardGenerateCount));

    private static Faker<T> SkipConstructor<T>(this Faker<T> f) where T : class
        => f.CustomInstantiator(_ => (FormatterServices.GetUninitializedObject(typeof(T)) as T)!);

    private static ImmutableArray<T> GenerateImmutableArray<T>(this Faker<T> faker, int min, int max) where T : class
    {
        var count = ((IFakerTInternal)faker).FakerHub.Random.Number(min, max);
        var builder = ImmutableArray.CreateBuilder<T>(count);
        for (int i = 0; i < count; i++)
        {
            builder.Add(faker.Generate());
        }
        return builder.MoveToImmutable();
    }
}
