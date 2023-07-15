// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IUIAnimationVariableIntegerChangeHandler"/> struct.</summary>
public static unsafe partial class IUIAnimationVariableIntegerChangeHandlerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IUIAnimationVariableIntegerChangeHandler"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IUIAnimationVariableIntegerChangeHandler).GUID, Is.EqualTo(IID_IUIAnimationVariableIntegerChangeHandler));
    }

    /// <summary>Validates that the <see cref = "IUIAnimationVariableIntegerChangeHandler"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IUIAnimationVariableIntegerChangeHandler>(), Is.EqualTo(sizeof(IUIAnimationVariableIntegerChangeHandler)));
    }

    /// <summary>Validates that the <see cref = "IUIAnimationVariableIntegerChangeHandler"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUIAnimationVariableIntegerChangeHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IUIAnimationVariableIntegerChangeHandler"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUIAnimationVariableIntegerChangeHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUIAnimationVariableIntegerChangeHandler), Is.EqualTo(4));
        }
    }
}