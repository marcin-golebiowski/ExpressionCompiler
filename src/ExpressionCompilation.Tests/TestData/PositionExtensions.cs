﻿using JetBrains.Annotations;

namespace ExpressionCompilation.Tests.TestData
{
    [UsedImplicitly]
    public static class PositionExtensions
    {
        public static int GetId([NotNull] this Position position)
        {
            return position.Id;
        }
    }
}