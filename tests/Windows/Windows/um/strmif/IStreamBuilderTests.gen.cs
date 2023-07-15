// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IStreamBuilder"/> struct.</summary>
public static unsafe partial class IStreamBuilderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IStreamBuilder"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IStreamBuilder).GUID, Is.EqualTo(IID_IStreamBuilder));
    }

    /// <summary>Validates that the <see cref = "IStreamBuilder"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IStreamBuilder>(), Is.EqualTo(sizeof(IStreamBuilder)));
    }

    /// <summary>Validates that the <see cref = "IStreamBuilder"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IStreamBuilder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IStreamBuilder"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IStreamBuilder), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IStreamBuilder), Is.EqualTo(4));
        }
    }
}