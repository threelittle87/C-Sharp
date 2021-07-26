using System;
using System.Linq;
using Algorithms.Knapsack;
using NUnit.Framework;

namespace Algorithms.Tests.Knapsack
{
    public static class BranchAndBoundKnapsackSolverTests
    {
        [Test]
        public static void BranchAndBoundTest_PassExpected()
        {
            // Arrange
            var items = new[] {'A', 'B', 'C', 'D'};
            var val = new[] {18, 20, 14, 18};
            var wt = new[] {2, 4, 6, 9};

            var capacity = 15;

            Func<char, int> weightSelector = x => wt[Array.IndexOf(items, x)];
            Func<char, double> valueSelector = x => val[Array.IndexOf(items, x)];

            var expected = new[] {'A', 'B', 'D'};

            // Act
            var solver = new BranchAndBoundKnapsackSolver<char>();
            var actual = solver.Solve(items, capacity, weightSelector, valueSelector);

            // Assert
            Assert.AreEqual(expected.OrderBy(x => x), actual.OrderBy(x => x));
        }
    }
}
