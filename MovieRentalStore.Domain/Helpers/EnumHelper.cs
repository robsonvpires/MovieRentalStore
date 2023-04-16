﻿using MovieRentalStore.Domain.Enums;

namespace MovieRentalStore.Domain.Helpers;

public class EnumHelper
{
    public static List<string> GetEnumValuesAndNamesList<T>()
    {
        List<string> list = new();

        foreach (int i in Enum.GetValues(typeof(T)))
        {
            string name = Enum.GetName(typeof(T), i);

            list.Add($"{i} = {name}");
        }

        return list;
    }
}
