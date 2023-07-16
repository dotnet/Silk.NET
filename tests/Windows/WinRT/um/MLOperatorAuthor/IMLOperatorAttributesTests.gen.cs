// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IMLOperatorAttributes"/> struct.</summary>
public static unsafe partial class IMLOperatorAttributesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMLOperatorAttributes"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMLOperatorAttributes).GUID, Is.EqualTo(IID_IMLOperatorAttributes));
    }

    /// <summary>Validates that the <see cref = "IMLOperatorAttributes"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMLOperatorAttributes>(), Is.EqualTo(sizeof(IMLOperatorAttributes)));
    }

    /// <summary>Validates that the <see cref = "IMLOperatorAttributes"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMLOperatorAttributes).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMLOperatorAttributes"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMLOperatorAttributes), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMLOperatorAttributes), Is.EqualTo(4));
        }
    }
}