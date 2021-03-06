﻿using System;

namespace BattleShips
{
    internal class CheckInput
    {
        internal static string UserDirection(string userInput)
        {
            try
            {
                string direction = userInput.Split(' ')[1].ToLower();

                switch (direction)
                {
                    case "up":
                        return "up";
                    case "right":
                        return "right";
                    case "down":
                        return "down";
                    case "left":
                        return "left";
                    default:
                        return null;
                }
            }
            catch
            {
                return null;
            }
        }

        internal static int[] UserCoordinates(string userInput)
        {
            int[] coordinates = { -1, -1 };

            try
            {
                userInput = userInput.ToLower();

                string letter = userInput[0].ToString();
                string number = userInput[1].ToString();

                try
                {
                    string mightBeValue = userInput[2].ToString();

                    if (mightBeValue != " ")
                    {
                        number += mightBeValue;
                    }

                    return ConvertToValidCoordinates(coordinates, letter, number);
                }
                catch
                {
                    return ConvertToValidCoordinates(coordinates, letter, number);
                }
            }
            catch
            {
                return coordinates;
            }
        }

        internal static int[] ConvertToValidCoordinates(int[] coordinates, string letter, string number)
        {
            try
            {
                coordinates[0] = ChangeLetterToDecimal(letter);
                coordinates[1] = Convert.ToInt32(number) - 1;

                return coordinates;
            }
            catch
            {
                return coordinates;
            }
        }

        internal static int ChangeLetterToDecimal(string letter)
        {
            switch (letter)
            {
                case "a":
                    return 0;
                case "b":
                    return 1;
                case "c":
                    return 2;
                case "d":
                    return 3;
                case "e":
                    return 4;
                case "f":
                    return 5;
                case "g":
                    return 6;
                case "h":
                    return 7;
                case "i":
                    return 8;
                case "j":
                    return 9;
                default:
                    return -1;
            }
        }
    }
}