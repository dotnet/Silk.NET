// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenAL.UnitTests;

/// <summary>Provides validation of the <see cref = "EfxEaxReverbProperties"/> struct.</summary>
public static unsafe partial class EFXEAXREVERBPROPERTIESTests
{
    /// <summary>Validates that the <see cref = "EfxEaxReverbProperties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EfxEaxReverbProperties>(),
            Is.EqualTo(sizeof(EfxEaxReverbProperties))
        );
    }

    /// <summary>Validates that the <see cref = "EfxEaxReverbProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EfxEaxReverbProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EfxEaxReverbProperties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EfxEaxReverbProperties), Is.EqualTo(108));
    }
}
