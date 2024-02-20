using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.DataAccess
{
    internal class MigrationsData
    {
        public static readonly IReadOnlyCollection<string> StatesAbbreviations =  new[]{
            "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
            "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
            "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
            "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
            "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
        }.Distinct().ToArray().AsReadOnly();

        public static readonly IReadOnlyCollection<string> SubElementTypes = new[]{
            "Doors",
            "Window"
        }.Distinct().ToArray().AsReadOnly();
    }

    //  migrationBuilder.InsertData("States", nameof(State.Abbreviation), MigrationsData.StatesAbbreviations.ToArray());

    //  migrationBuilder.InsertData("SubElementTypes", nameof(State.Abbreviation), MigrationsData.StatesAbbreviations.ToArray());

}
