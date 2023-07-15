// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISpDisplayAlternates"/> struct.</summary>
public static unsafe partial class ISpDisplayAlternatesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpDisplayAlternates"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpDisplayAlternates).GUID, Is.EqualTo(IID_ISpDisplayAlternates));
    }

    /// <summary>Validates that the <see cref = "ISpDisplayAlternates"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISpDisplayAlternates>(), Is.EqualTo(sizeof(ISpDisplayAlternates)));
    }

    /// <summary>Validates that the <see cref = "ISpDisplayAlternates"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpDisplayAlternates).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpDisplayAlternates"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpDisplayAlternates), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpDisplayAlternates), Is.EqualTo(4));
        }
    }
}