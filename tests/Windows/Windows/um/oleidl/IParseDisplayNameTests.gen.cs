// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IParseDisplayName"/> struct.</summary>
public static unsafe partial class IParseDisplayNameTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IParseDisplayName"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IParseDisplayName).GUID, Is.EqualTo(IID_IParseDisplayName));
    }

    /// <summary>Validates that the <see cref = "IParseDisplayName"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IParseDisplayName>(), Is.EqualTo(sizeof(IParseDisplayName)));
    }

    /// <summary>Validates that the <see cref = "IParseDisplayName"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IParseDisplayName).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IParseDisplayName"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IParseDisplayName), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IParseDisplayName), Is.EqualTo(4));
        }
    }
}