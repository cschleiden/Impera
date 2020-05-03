﻿using System;
using System.Collections.Generic;
using System.Linq;
using ImperaPlus.Domain.Utilities;
using ImperaPlus.Domain.Map;
using NLog.Fluent;
using ImperaPlus.Domain.Services;

namespace ImperaPlus.Domain.Games.Distribution
{
    public class MalibuMapDistribution : IMapDistribution
    {
        public void Distribute(GameOptions gameOptions, IEnumerable<Team> teams, MapTemplate mapTemplate, Map map, IRandomGen random)
        {
            var players = teams.SelectMany(x => x.Players).ToArray();
            var numberOfPlayers = players.Count();

            var shuffledCountries = map.Countries.Shuffle(random).ToArray();
            var countryIdx = 0;

            foreach (var player in players)
            {
                bool countryDistributed = false;
                for (int i = 0; i < 10 && countryIdx < shuffledCountries.Count(); ++i)
                {
                    var country = shuffledCountries[countryIdx++];

                    var connectedCountryIdentifiers = mapTemplate.GetConnectedCountries(country.CountryIdentifier);
                    bool tryNext = false;
                    foreach(var connectedCountry in connectedCountryIdentifiers.Select(x => map.GetCountry(x)))
                    {
                        if (connectedCountry.IsNeutral)
                        {
                            // Try again with another country
                            tryNext = true;
                            break;
                        }
                    }

                    if (tryNext)
                    {
                        continue;
                    }

                    // All connected countries are without a player, claim this one.
                    map.UpdateOwnership(player, country);
                    country.Units = gameOptions.InitialCountryUnits;
                    countryDistributed = true;
                    break;
                }

                if (!countryDistributed)
                {
                    var backupCountry = shuffledCountries.FirstOrDefault(x => x.PlayerId == Guid.Empty);
                    if (backupCountry != null)
                    {
                        // Reached here because we couldn't find a country in the number of allowed iterations. Just take this one
                        map.UpdateOwnership(player, backupCountry);
                        backupCountry.Units = gameOptions.InitialCountryUnits;
                    }
                    else
                    {
                        Log.Fatal().Message("Could not distribute countries to all players in malibu").Write();
                    }
                }
            }
        }
    }
}