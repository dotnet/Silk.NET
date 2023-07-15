// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IMLOperatorRegistry"/> struct.</summary>
public static unsafe partial class IMLOperatorRegistryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMLOperatorRegistry"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMLOperatorRegistry).GUID, Is.EqualTo(IID_IMLOperatorRegistry));
    }

    /// <summary>Validates that the <see cref = "IMLOperatorRegistry"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMLOperatorRegistry>(), Is.EqualTo(sizeof(IMLOperatorRegistry)));
    }

    /// <summary>Validates that the <see cref = "IMLOperatorRegistry"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMLOperatorRegistry).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMLOperatorRegistry"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMLOperatorRegistry), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMLOperatorRegistry), Is.EqualTo(4));
        }
    }
}