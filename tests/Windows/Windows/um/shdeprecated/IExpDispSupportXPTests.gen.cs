// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IExpDispSupportXP"/> struct.</summary>
public static unsafe partial class IExpDispSupportXPTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IExpDispSupportXP"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IExpDispSupportXP).GUID, Is.EqualTo(IID_IExpDispSupportXP));
    }

    /// <summary>Validates that the <see cref = "IExpDispSupportXP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IExpDispSupportXP>(), Is.EqualTo(sizeof(IExpDispSupportXP)));
    }

    /// <summary>Validates that the <see cref = "IExpDispSupportXP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IExpDispSupportXP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IExpDispSupportXP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IExpDispSupportXP), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IExpDispSupportXP), Is.EqualTo(4));
        }
    }
}