﻿using System;
using ImperaPlus.Domain.Enums;

namespace ImperaPlus.Domain.VictoryConditions
{
    internal static class VictoryConditionFactory
    {
        public static IVictoryCondition Create(VictoryConditionType victoryCondition)
        {
            switch (victoryCondition)
            {
                case VictoryConditionType.Survival:
                    return new SurvivalVictoryCondition();

                case VictoryConditionType.ControlContinent:
                    return new ControlContinentVictoryCondition();

                case VictoryConditionType.Capitals:
                    return new CapitalsVictoryCondition();

                default:
                    throw new ArgumentOutOfRangeException("victoryCondition");
            }
        }
    }
}
