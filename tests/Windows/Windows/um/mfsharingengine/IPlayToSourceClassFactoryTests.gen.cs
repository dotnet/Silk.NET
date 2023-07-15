// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPlayToSourceClassFactory"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IPlayToSourceClassFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPlayToSourceClassFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPlayToSourceClassFactory).GUID, Is.EqualTo(IID_IPlayToSourceClassFactory));
    }

    /// <summary>Validates that the <see cref = "IPlayToSourceClassFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPlayToSourceClassFactory>(), Is.EqualTo(sizeof(IPlayToSourceClassFactory)));
    }

    /// <summary>Validates that the <see cref = "IPlayToSourceClassFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPlayToSourceClassFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPlayToSourceClassFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPlayToSourceClassFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPlayToSourceClassFactory), Is.EqualTo(4));
        }
    }
}