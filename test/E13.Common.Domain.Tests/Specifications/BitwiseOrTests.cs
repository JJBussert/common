﻿using E13.Common.Domain.Specifications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace E13.Common.Domain.Tests.Specifications
{
    public class BitwiseOrTests
    {
        [Test]
        public void LeftTrue_RightTrue_True()
        {
            var left = new TrueSpecification();
            var right = new TrueSpecification();

            var result = left.BitwiseOr(right).IsSatisfiedBy(null);

            result.Should().BeTrue();
        }
        [Test]
        public void LeftTrue_RightFalse_False()
        {
            var left = new TrueSpecification();
            var right = new FalseSpecification();

            var result = left.BitwiseOr(right).IsSatisfiedBy(null);

            result.Should().BeTrue();
        }
        [Test]
        public void LeftFalse_RightTrue_False()
        {
            var left = new FalseSpecification();
            var right = new TrueSpecification();

            var result = left.BitwiseOr(right).IsSatisfiedBy(null);

            result.Should().BeTrue();
        }
        [Test]
        public void LeftFalse_RightFalse_False()
        {
            var left = new FalseSpecification();
            var right = new FalseSpecification();

            var result = left.BitwiseOr(right).IsSatisfiedBy(null);

            result.Should().BeFalse();
        }
    }
}
