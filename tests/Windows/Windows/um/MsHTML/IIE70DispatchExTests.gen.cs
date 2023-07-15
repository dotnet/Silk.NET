// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IIE70DispatchEx"/> struct.</summary>
public static unsafe partial class IIE70DispatchExTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IIE70DispatchEx"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IIE70DispatchEx).GUID, Is.EqualTo(IID_IIE70DispatchEx));
    }

    /// <summary>Validates that the <see cref = "IIE70DispatchEx"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IIE70DispatchEx>(), Is.EqualTo(sizeof(IIE70DispatchEx)));
    }

    /// <summary>Validates that the <see cref = "IIE70DispatchEx"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IIE70DispatchEx).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IIE70DispatchEx"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IIE70DispatchEx), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IIE70DispatchEx), Is.EqualTo(4));
        }
    }
}