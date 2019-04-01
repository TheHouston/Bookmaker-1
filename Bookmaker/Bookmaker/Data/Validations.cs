﻿using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Bookmaker.Data.Models;

namespace Bookmaker.Data
{
    public static class Validations
    {
        public static bool IsNameValid(string name) => name.Trim().Length > 0 && Regex.IsMatch(name, @"^[a-zA-Z ]+$");

        public static bool IsAgeValid(int age)
        {
            if (age < Constants.MinAge || age > Constants.MaxAge)
            {
                return false;
            }

            return true;
        }

        public static bool IsDivisionValid(int division) => (division >= 1 && division <= Constants.DivisionsCount);

        public static bool IsBudgetValid(decimal budget) => budget > 0;

        public static bool CanTeamPlayMatch(Team team) => team.PlayersCount >= Constants.MinPlayersCountForAMatch;
    }
}